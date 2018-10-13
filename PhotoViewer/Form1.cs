using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PictureBox.MouseWheel += OnMouseWheel;
            LibUtility.ClassUtility.InitialComboBox(ref ComboBox_SaveType, new String[] {"*.bmp","*.jpg","*.jpeg","*.*"});
            Button_SaveImage.Enabled = false;
            Button_FitImage.Enabled = false;
        }

        private Emgu.CV.Image<Emgu.CV.Structure.Bgr, Byte> m_Image = null;
        private String m_OpenImagePath = String.Empty;
        private String m_SaveImagePath = String.Empty;
        
        private void Button_OpenImage_Click(object sender, EventArgs e)
        {
            if(this.m_Image != null)
            {
                this.m_Image.Dispose();
                this.m_Image = null;
            }
            
            m_OpenImagePath = LibUtility.ClassUtility.OpenImageFile();
            if(m_OpenImagePath == String.Empty)
            {
                return;
            }
            ToolStripStatusLabel_Directory.Text = System.IO.Path.GetDirectoryName(m_OpenImagePath);
            ToolStripStatusLabel_ImageName.Text = System.IO.Path.GetFileName(m_OpenImagePath);
            ToolStripStatusLabel_Status.Text = "Open Image File";

            this.m_Image = new Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte>(this.m_OpenImagePath);

            m_ImageZoom = (float)LibUtility.ClassUtility.ZoomImageFit(PictureBox.Size, m_Image.Size);
            m_ImagePan = MoveImageToCenter(PictureBox.Size, m_Image.Size, m_ImageZoom);
            this.PictureBox.Refresh();

            Button_SaveImage.Enabled = true;
            Button_FitImage.Enabled = true;

        }
        Point m_MouseDownPoint;
        Point m_ImageOldPan = new Point(0, 0);  // offset of image when mouse was pressed
        Point m_ImagePan = new Point(0, 0);     // current offset of image
        bool m_IsMousePressed = false;         // true as long as left mousebutton is pressed
        float m_ImageZoom = 1;                  // the zooming show of image

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEventArgs mouse = e as MouseEventArgs;

            if (mouse.Button == MouseButtons.Left)
            {
                if (!m_IsMousePressed)
                {
                    m_IsMousePressed = true;
                    m_MouseDownPoint = mouse.Location;
                    m_ImageOldPan = m_ImagePan;
                }
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEventArgs mouse = e as MouseEventArgs;
            ToolStripStatusLabel_MouseOnPictureBox.Text = "Mouse On PictureBox : " + e.X + ", " + e.Y;
            ToolStripStatusLabel_MouseOnImage.Text = "Mouse On Image : " + (e.X / m_ImageZoom - m_ImagePan.X) + ", " + (e.Y / m_ImageZoom - m_ImagePan.Y) ;
            if (mouse.Button == MouseButtons.Left)
            {
                Point t_mousePosNow = mouse.Location;

                // the distance the mouse has been moved since mouse was pressed
                int deltaX = t_mousePosNow.X - m_MouseDownPoint.X;
                int deltaY = t_mousePosNow.Y - m_MouseDownPoint.Y;

                // calculate new offset of image based on the current zoom factor
                m_ImagePan.X = (int)(m_ImageOldPan.X + (deltaX / m_ImageZoom));
                m_ImagePan.Y = (int)(m_ImageOldPan.Y + (deltaY / m_ImageZoom));

                PictureBox.Refresh();
            };
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            m_IsMousePressed = false;
        }
        
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics t_Graphic = e.Graphics;
            //(Why) There are something Event triggered.
            //Graphics t_Graphic = PictureBox.CreateGraphics(); 
            t_Graphic.Clear(Color.White);
            
            if (this.m_Image != null)
            {
                t_Graphic.ScaleTransform(m_ImageZoom, m_ImageZoom);
                t_Graphic.DrawImage(this.m_Image.ToBitmap(), m_ImagePan.X, m_ImagePan.Y);
            }

        }
        private void OnMouseWheel(object sender, MouseEventArgs e)
        {
            //MouseEventArgs mouse = e as MouseEventArgs;
            float t_OldImageZoom = m_ImageZoom;

            if (e.Delta > 0)
            {
                m_ImageZoom += 0.1F;
            }
            else if (e.Delta < 0)
            {
                m_ImageZoom = Math.Max(m_ImageZoom - 0.1F, 0.05F);
            }
            
            Point t_MousePosNow = e.Location;
            
            //I Use the PictureBox Event, so the 
            // Where location of the mouse in the pictureframe
            //int x = t_MousePosNow.X - PictureBox.Location.X;
            //int y = t_MousePosNow.Y - PictureBox.Location.Y;

            // Where in the Image is it now
            int t_oldimagex = (int)(t_MousePosNow.X / t_OldImageZoom);
            int t_oldimagey = (int)(t_MousePosNow.Y / t_OldImageZoom);

            // Where in the IMAGE will it be when the new zoom I made
            int t_newimagex = (int)(t_MousePosNow.X / m_ImageZoom);
            int t_newimagey = (int)(t_MousePosNow.Y / m_ImageZoom);

            // Where to move image to keep focus on one point
            m_ImagePan.X = t_newimagex - t_oldimagex + m_ImagePan.X;
            m_ImagePan.Y = t_newimagey - t_oldimagey + m_ImagePan.Y;

            PictureBox.Refresh();  // calls imageBox_Paint
        }

        private void Button_FitImage_Click(object sender, EventArgs e)
        {
            m_ImageZoom = (float)LibUtility.ClassUtility.ZoomImageFit(PictureBox.Size, this.m_Image.Size);
            m_ImagePan = MoveImageToCenter(PictureBox.Size, m_Image.Size, m_ImageZoom);
            PictureBox.Refresh();
        }

        private Point MoveImageToCenter(Size f_PictureBoxSize, Size f_Image, float ZoomValue = 1)
        {
            Point t_CenterPoint = Point.Empty;
            t_CenterPoint.X = (int)(f_PictureBoxSize.Width - f_Image.Width* ZoomValue) / 2;
            t_CenterPoint.Y = (int)(f_PictureBoxSize.Height - f_Image.Height * ZoomValue) / 2;
            t_CenterPoint.X = (int)(t_CenterPoint.X / m_ImageZoom);
            t_CenterPoint.Y = (int)(t_CenterPoint.Y / m_ImageZoom);
            return t_CenterPoint;
        }

        private void Button_SaveImage_Click(object sender, EventArgs e)
        {
            String t_SaveImagePath = LibUtility.ClassUtility.SaveImageFile();
            m_Image.Save(t_SaveImagePath);
        }
    }
}
