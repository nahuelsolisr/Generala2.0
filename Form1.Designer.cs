namespace Yahtzee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PictureBox picture_d5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_lanzar = new Button();
            picture_d1 = new PictureBox();
            picture_d2 = new PictureBox();
            picture_d3 = new PictureBox();
            picture_d4 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lbl_img1 = new Label();
            lbl_img2 = new Label();
            label17 = new Label();
            lbl_img3 = new Label();
            label9 = new Label();
            lbl_img4 = new Label();
            pictureBox7 = new PictureBox();
            lbl_img5 = new Label();
            pictureBox8 = new PictureBox();
            lbl_img6 = new Label();
            label12 = new Label();
            label10 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolTip = new ToolTip(components);
            picture_d5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picture_d5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_d1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_d2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_d3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_d4).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // picture_d5
            // 
            picture_d5.Cursor = Cursors.Hand;
            picture_d5.Location = new Point(831, 245);
            picture_d5.Name = "picture_d5";
            picture_d5.Size = new Size(90, 90);
            picture_d5.SizeMode = PictureBoxSizeMode.Zoom;
            picture_d5.TabIndex = 24;
            picture_d5.TabStop = false;
            picture_d5.Click += ToggleRetenido;
            // 
            // btn_lanzar
            // 
            btn_lanzar.Location = new Point(927, 266);
            btn_lanzar.Name = "btn_lanzar";
            btn_lanzar.Size = new Size(90, 39);
            btn_lanzar.TabIndex = 6;
            btn_lanzar.Text = "Tirar";
            btn_lanzar.UseVisualStyleBackColor = true;
            btn_lanzar.Click += btn_lanzar_Click;
            // 
            // picture_d1
            // 
            picture_d1.Cursor = Cursors.Hand;
            picture_d1.Location = new Point(447, 245);
            picture_d1.Name = "picture_d1";
            picture_d1.Size = new Size(90, 90);
            picture_d1.SizeMode = PictureBoxSizeMode.Zoom;
            picture_d1.TabIndex = 20;
            picture_d1.TabStop = false;
            picture_d1.Click += ToggleRetenido;
            // 
            // picture_d2
            // 
            picture_d2.Cursor = Cursors.Hand;
            picture_d2.Location = new Point(543, 245);
            picture_d2.Name = "picture_d2";
            picture_d2.Size = new Size(90, 90);
            picture_d2.SizeMode = PictureBoxSizeMode.Zoom;
            picture_d2.TabIndex = 21;
            picture_d2.TabStop = false;
            picture_d2.Click += ToggleRetenido;
            // 
            // picture_d3
            // 
            picture_d3.Cursor = Cursors.Hand;
            picture_d3.Location = new Point(639, 245);
            picture_d3.Name = "picture_d3";
            picture_d3.Size = new Size(90, 90);
            picture_d3.SizeMode = PictureBoxSizeMode.Zoom;
            picture_d3.TabIndex = 22;
            picture_d3.TabStop = false;
            picture_d3.Click += ToggleRetenido;
            // 
            // picture_d4
            // 
            picture_d4.Cursor = Cursors.Hand;
            picture_d4.Location = new Point(735, 245);
            picture_d4.Name = "picture_d4";
            picture_d4.Size = new Size(90, 90);
            picture_d4.SizeMode = PictureBoxSizeMode.Zoom;
            picture_d4.TabIndex = 23;
            picture_d4.TabStop = false;
            picture_d4.Click += ToggleRetenido;
            // 
            // panel1
            // 
            panel1.Controls.Add(picture_d1);
            panel1.Controls.Add(picture_d2);
            panel1.Controls.Add(btn_lanzar);
            panel1.Controls.Add(picture_d3);
            panel1.Controls.Add(picture_d5);
            panel1.Controls.Add(picture_d4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 550);
            panel1.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lbl_img1);
            panel2.Controls.Add(lbl_img2);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(lbl_img3);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(lbl_img4);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(lbl_img5);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(lbl_img6);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.FromArgb(63, 63, 63);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 550);
            panel2.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(63, 63, 63);
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(15, 511);
            label6.Name = "label6";
            label6.Size = new Size(111, 30);
            label6.TabIndex = 35;
            label6.Text = "Total         ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(165, 165, 165);
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(236, 328);
            label5.Name = "label5";
            label5.Size = new Size(65, 30);
            label5.TabIndex = 34;
            label5.Text = "37/63";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(165, 165, 165);
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(157, 328);
            label4.Name = "label4";
            label4.Size = new Size(65, 30);
            label4.TabIndex = 33;
            label4.Text = "37/63";
            // 
            // lbl_img1
            // 
            lbl_img1.AutoSize = true;
            lbl_img1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_img1.ForeColor = Color.Black;
            lbl_img1.Location = new Point(6, 126);
            lbl_img1.Name = "lbl_img1";
            lbl_img1.Size = new Size(138, 30);
            lbl_img1.TabIndex = 3;
            lbl_img1.Text = "       Unos      ";
            lbl_img1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_img2
            // 
            lbl_img2.AutoSize = true;
            lbl_img2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_img2.ForeColor = Color.Black;
            lbl_img2.Location = new Point(6, 155);
            lbl_img2.Name = "lbl_img2";
            lbl_img2.Size = new Size(135, 30);
            lbl_img2.TabIndex = 18;
            lbl_img2.Text = "       Doses    ";
            lbl_img2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.DimGray;
            label17.Location = new Point(236, 9);
            label17.Name = "label17";
            label17.Size = new Size(80, 30);
            label17.TabIndex = 32;
            label17.Text = "Player2";
            // 
            // lbl_img3
            // 
            lbl_img3.AutoSize = true;
            lbl_img3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_img3.ForeColor = Color.Black;
            lbl_img3.Location = new Point(6, 185);
            lbl_img3.Name = "lbl_img3";
            lbl_img3.Size = new Size(135, 30);
            lbl_img3.TabIndex = 20;
            lbl_img3.Text = "       Treses    ";
            lbl_img3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(157, 8);
            label9.Name = "label9";
            label9.Size = new Size(80, 30);
            label9.TabIndex = 31;
            label9.Text = "Player1";
            // 
            // lbl_img4
            // 
            lbl_img4.AutoSize = true;
            lbl_img4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_img4.ForeColor = Color.Black;
            lbl_img4.Location = new Point(6, 215);
            lbl_img4.Name = "lbl_img4";
            lbl_img4.Size = new Size(132, 30);
            lbl_img4.TabIndex = 22;
            lbl_img4.Text = "       Cuatros ";
            lbl_img4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(160, 41);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(72, 72);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 30;
            pictureBox7.TabStop = false;
            // 
            // lbl_img5
            // 
            lbl_img5.AutoSize = true;
            lbl_img5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_img5.ForeColor = Color.Black;
            lbl_img5.Location = new Point(6, 245);
            lbl_img5.Name = "lbl_img5";
            lbl_img5.Size = new Size(134, 30);
            lbl_img5.TabIndex = 24;
            lbl_img5.Text = "       Cincos   ";
            lbl_img5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(238, 41);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(72, 72);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 29;
            pictureBox8.TabStop = false;
            // 
            // lbl_img6
            // 
            lbl_img6.AutoSize = true;
            lbl_img6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_img6.ForeColor = Color.Black;
            lbl_img6.Location = new Point(6, 275);
            lbl_img6.Name = "lbl_img6";
            lbl_img6.Size = new Size(135, 30);
            lbl_img6.TabIndex = 26;
            lbl_img6.Text = "       Seises    ";
            lbl_img6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(63, 63, 63);
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(12, 328);
            label12.Name = "label12";
            label12.Size = new Size(114, 30);
            label12.TabIndex = 16;
            label12.Text = "Subtotal    ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(63, 63, 63);
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(12, 358);
            label10.Name = "label10";
            label10.Size = new Size(112, 30);
            label10.TabIndex = 15;
            label10.Text = "Bonus +35";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(12, 478);
            label13.Name = "label13";
            label13.Size = new Size(95, 30);
            label13.TabIndex = 13;
            label13.Text = "Generala";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(12, 448);
            label14.Name = "label14";
            label14.Size = new Size(64, 30);
            label14.TabIndex = 12;
            label14.Text = "Poker";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(12, 418);
            label15.Name = "label15";
            label15.Size = new Size(45, 30);
            label15.TabIndex = 11;
            label15.Text = "Full";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(12, 388);
            label16.Name = "label16";
            label16.Size = new Size(88, 30);
            label16.TabIndex = 10;
            label16.Text = "Escalera";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(63, 63, 63);
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(144, 37);
            label3.TabIndex = 2;
            label3.Text = "Categorias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(33, 28);
            label2.Name = "label2";
            label2.Size = new Size(91, 47);
            label2.TabIndex = 1;
            label2.Text = "9/12";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(45, 4);
            label1.Name = "label1";
            label1.Size = new Size(67, 30);
            label1.TabIndex = 0;
            label1.Text = "Turno";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 550);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picture_d5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_d1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_d2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_d3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_d4).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_lanzar;
        private PictureBox picture_d1;
        private PictureBox picture_d2;
        private PictureBox picture_d3;
        private PictureBox picture_d4;
        private PictureBox picture_d5;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label12;
        private Label label10;
        private Label lbl_img6;
        private Label lbl_img5;
        private Label lbl_img4;
        private Label lbl_img3;
        private Label lbl_img2;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Label label17;
        private Label label9;
        private Label lbl_img1;
        private Label label6;
        private Label label5;
        private Label label4;
        private ToolTip toolTip;
    }
}
