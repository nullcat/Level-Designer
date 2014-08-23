using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using LevelClass;
namespace Data_Management_Project
{
    public partial class FormMain : Form
    {
        
        Bitmap myImage;
        Pen bPen;
        Brush blackBrush;
        Brush blueBrush;
        Brush redBrush;
        Brush whiteBrush;
        Brush myBrush;
        ColorDialog colorDialog;
        Level level;
        ImageList imageList = new ImageList();
        Dimensions formDimensions=new Dimensions();
        float width_ratio;
        float height_ratio;
        public FormMain()
        {
            InitializeComponent();
            float screenWidth = Screen.PrimaryScreen.Bounds.Width;
            float screenHeight = Screen.PrimaryScreen.Bounds.Height;
            width_ratio = (screenWidth / this.Width);
            height_ratio = (screenHeight / this.Height);
            SizeF scale = new SizeF(width_ratio, height_ratio);
            //pbMain.Scale(scale);
            //this.Size = pbMain.Size;
            foreach (Control control in this.Controls)
            {
                if (control.Name == "pbMain")
                    continue;
                control.Scale(scale);
            }
            foreach (Control control in this.Controls)
            {
                control.Font = new Font(control.Font.Name, control.Font.SizeInPoints * height_ratio * width_ratio, control.Font.Style);
            }
            level = new Level(pbMain.Width, pbMain.Height);
            DrawBoard();
            bPen = new Pen(Color.Black);
            blackBrush = new SolidBrush(Color.Black);
            blueBrush = new SolidBrush(Color.Blue);
            redBrush = new SolidBrush(Color.Red);
            whiteBrush = new SolidBrush(Color.White);
            myBrush = new SolidBrush(Color.Black);
            colorDialog = new ColorDialog();
            myImage = new Bitmap(pbMain.Width, pbMain.Height);
            
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            listViewImage.Enabled = false;
            btnImage.Enabled = false;
            lblColor.Enabled = true;
            //pbMain.Image = level.GetImage();
            cbTile.SelectedIndex = 0;
            
        }
        public void HighlightGrid()
        {

        }

        private void pbMain_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            Point mouse = new Point(e.X, e.Y);
            Point currentGrid;
            currentGrid = new Point(e.X / (pbMain.Width / 15), e.Y / (pbMain.Height / 10));
            lblInfo.Text = level.getArray()[currentGrid.X, currentGrid.Y].ToString();
        }

        private void pbMain_MouseClick(object sender, MouseEventArgs e)
        {
            Point mouse = new Point(e.X, e.Y);
            Point currentGrid;
            currentGrid = new Point(e.X / (pbMain.Width / 15), e.Y / (pbMain.Height / 10));

            if (e.Button==MouseButtons.Left)
            {
                if (rbImage.Checked)
                {
                    if (cbTile.SelectedIndex < 5)
                    {
                        level.Update(myImage, currentGrid, (cbTile.SelectedIndex + 1), (cbTile.SelectedIndex + 1),Convert.ToInt32(nudSpecial.Value));
                    }
                    else
                    {
                        level.Update(myImage, currentGrid, (int)formDimensions.nudX.Value, (int)formDimensions.nudY.Value, Convert.ToInt32(nudSpecial.Value));
                    }

                }
                else
                    level.Update(myBrush, currentGrid, (cbTile.SelectedIndex + 1), (cbTile.SelectedIndex + 1), Convert.ToInt32(nudSpecial.Value));
            }
            else
                level.Erase(currentGrid);

            DrawBoard();
            
            //pbMain.Image = level.GetImage();
        }
        private void DrawBoard()
        {
            Bitmap b = new Bitmap(level.GetImage());
            //b = (Bitmap)pbMain.Image;
            Graphics g = Graphics.FromImage(b);
            Pen myPen = new Pen(Color.Black);
            int width = pbMain.Width;
            int height = pbMain.Height;
            for (int i = 0; i < 10; i++)
            {
                g.DrawLine(myPen, 0, i * height / 10, width, i * height / 10);
            }
            for (int i = 0; i < 15; i++)
            {
                g.DrawLine(myPen, i * width / 15, 0, i * width / 15, height);
            }
            if (cbGrid.Checked == true)
                pbMain.Image = b;
            else
                pbMain.Image = level.GetImage();
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                Stream myStream = null;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image Files (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.Title = "Image Browser";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        myImage = new Bitmap(myStream);
                        myStream.Close();
                        imageList.Images.Add(myImage);
                        imageList.ImageSize = new Size(75, 75);
                        ListViewItem item = new ListViewItem();
                        item.ImageIndex = imageList.Images.Count - 1;
                        item.Text = openFileDialog1.SafeFileName;
                        listViewImage.Items.Add(item);
                        listViewImage.LargeImageList = imageList;
                        listViewImage.Refresh();
                    }
                }
                
                
                
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormMain_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lblColor_MouseClick(object sender, MouseEventArgs e)
        {
            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                myBrush = new SolidBrush(colorDialog.Color);
                lblColor.BackColor = colorDialog.Color;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            level.Reset();
            DrawBoard();
            //pbMain.Image = level.GetImage();

        }
        private void importLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (DialogResult.Cancel == ofd.ShowDialog())
                    return;
                level.Read(ofd.FileName);
                pbMain.Width = level.GetImage().Width;
                pbMain.Height = level.GetImage().Height;
                DrawBoard();
                //pbMain.Image = level.GetImage();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void exportLevelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "level1.lvl";
                sfd.Filter = "Level files (*.lvl)|*.lvl|All files (*.*)|*.*";
                if (DialogResult.Cancel == sfd.ShowDialog())
                    return;
                level.Write(sfd.FileName);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void rbSolid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSolid.Checked)
            {
                listViewImage.Enabled = false;
                btnImage.Enabled = false;
                lblColor.Enabled = true;
            }
            else
            {
                listViewImage.Enabled = true;
                btnImage.Enabled =true;
                lblColor.Enabled = false;
            }
        }

        private void listViewImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listViewImage.SelectedItems)
            {
                int imgIndex = itm.ImageIndex;
                if (imgIndex >= 0 && imgIndex < this.imageList.Images.Count)
                {
                    myImage = (Bitmap)this.imageList.Images[imgIndex];
                }
            }
        }

        private void cbTile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete)
            {
                listViewImage.Items.RemoveAt(listViewImage.SelectedIndices[0]);
            }
        }

        private void listViewImage_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void listViewImage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete&&listViewImage.Items.Count>0&&listViewImage.SelectedItems.Count>0)
            {
                listViewImage.Items.RemoveAt(listViewImage.SelectedIndices[0]);
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Z)
            {
                level.Undo();
            }
        }

        private void pbMain_Click(object sender, EventArgs e)
        {

        }

        private void pbMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Z)
            {
                level.Undo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image image=Image.FromFile("Transparent.png");
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (DialogResult.Cancel == ofd.ShowDialog())
                    return;
                image = Image.FromFile(ofd.FileName);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            Bitmap bitmap = new Bitmap(pbMain.Width, pbMain.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(image, 0, 0, bitmap.Width, bitmap.Height);
            g.DrawImage(level.GetImage(), 0, 0, bitmap.Width, bitmap.Height);
            pbMain.Image = bitmap;
        }

        private void cbTile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTile.SelectedIndex==5)
                if (DialogResult.OK != formDimensions.ShowDialog())
                    return;
        }

        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.level.GetImage().Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.level.GetImage().Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.level.GetImage().Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();

            }
        }

        private void cbGrid_CheckedChanged(object sender, EventArgs e)
        {
            DrawBoard();
        }

        private void cbSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSpecial.Checked)
            {
                nudSpecial.Enabled = true;
                nudSpecial.Value = 2;
            }
            else
            {
                nudSpecial.Enabled = false;
                nudSpecial.Value = 1;
            }
        }

        

        


        
        
    }
}
