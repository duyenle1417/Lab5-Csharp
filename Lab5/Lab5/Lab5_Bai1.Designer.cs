namespace Lab5
{
    partial class MathGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.textBoxSub = new System.Windows.Forms.TextBox();
            this.textBoxMult = new System.Windows.Forms.TextBox();
            this.textBoxDiv = new System.Windows.Forms.TextBox();
            this.lb_Add1 = new System.Windows.Forms.Label();
            this.lb_Add2 = new System.Windows.Forms.Label();
            this.lb_Sub1 = new System.Windows.Forms.Label();
            this.lb_Sub2 = new System.Windows.Forms.Label();
            this.lb_Mult1 = new System.Windows.Forms.Label();
            this.lb_Mult2 = new System.Windows.Forms.Label();
            this.lb_Div1 = new System.Windows.Forms.Label();
            this.lb_Div2 = new System.Windows.Forms.Label();
            this.lbDiv = new System.Windows.Forms.Label();
            this.lbMult = new System.Windows.Forms.Label();
            this.lbSub = new System.Windows.Forms.Label();
            this.lbAdd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxQuiz = new System.Windows.Forms.GroupBox();
            this.labelAns4 = new System.Windows.Forms.Label();
            this.labelAns3 = new System.Windows.Forms.Label();
            this.labelAns2 = new System.Windows.Forms.Label();
            this.labelAns1 = new System.Windows.Forms.Label();
            this.labelPtn = new System.Windows.Forms.Label();
            this.labelPoint = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbCount = new System.Windows.Forms.Label();
            this.groupBoxMenu2 = new System.Windows.Forms.GroupBox();
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbSecond = new System.Windows.Forms.Label();
            this.groupBoxTimer = new System.Windows.Forms.GroupBox();
            this.groupBoxPoint = new System.Windows.Forms.GroupBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.groupBoxQuiz.SuspendLayout();
            this.groupBoxMenu2.SuspendLayout();
            this.groupBoxTimer.SuspendLayout();
            this.groupBoxPoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Submit.AutoSize = true;
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(21, 39);
            this.btn_Submit.MinimumSize = new System.Drawing.Size(150, 50);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(150, 50);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Visible = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Continue
            // 
            this.btn_Continue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Continue.AutoSize = true;
            this.btn_Continue.Enabled = false;
            this.btn_Continue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Continue.Location = new System.Drawing.Point(21, 137);
            this.btn_Continue.MinimumSize = new System.Drawing.Size(150, 50);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(150, 50);
            this.btn_Continue.TabIndex = 5;
            this.btn_Continue.Text = "Continue";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Visible = false;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Quit.AutoSize = true;
            this.btn_Quit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.Location = new System.Drawing.Point(21, 235);
            this.btn_Quit.MinimumSize = new System.Drawing.Size(150, 50);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(150, 50);
            this.btn_Quit.TabIndex = 6;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Visible = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAdd.Enabled = false;
            this.textBoxAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdd.Location = new System.Drawing.Point(337, 50);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(94, 34);
            this.textBoxAdd.TabIndex = 10;
            // 
            // textBoxSub
            // 
            this.textBoxSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSub.Enabled = false;
            this.textBoxSub.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSub.Location = new System.Drawing.Point(337, 109);
            this.textBoxSub.Name = "textBoxSub";
            this.textBoxSub.Size = new System.Drawing.Size(94, 34);
            this.textBoxSub.TabIndex = 11;
            // 
            // textBoxMult
            // 
            this.textBoxMult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMult.Enabled = false;
            this.textBoxMult.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMult.Location = new System.Drawing.Point(337, 170);
            this.textBoxMult.Name = "textBoxMult";
            this.textBoxMult.Size = new System.Drawing.Size(94, 34);
            this.textBoxMult.TabIndex = 12;
            // 
            // textBoxDiv
            // 
            this.textBoxDiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDiv.Enabled = false;
            this.textBoxDiv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiv.Location = new System.Drawing.Point(337, 232);
            this.textBoxDiv.Name = "textBoxDiv";
            this.textBoxDiv.Size = new System.Drawing.Size(94, 34);
            this.textBoxDiv.TabIndex = 13;
            // 
            // lb_Add1
            // 
            this.lb_Add1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Add1.AutoSize = true;
            this.lb_Add1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Add1.Location = new System.Drawing.Point(108, 53);
            this.lb_Add1.Name = "lb_Add1";
            this.lb_Add1.Size = new System.Drawing.Size(29, 26);
            this.lb_Add1.TabIndex = 14;
            this.lb_Add1.Text = "A";
            // 
            // lb_Add2
            // 
            this.lb_Add2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Add2.AutoSize = true;
            this.lb_Add2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Add2.Location = new System.Drawing.Point(246, 53);
            this.lb_Add2.Name = "lb_Add2";
            this.lb_Add2.Size = new System.Drawing.Size(28, 26);
            this.lb_Add2.TabIndex = 15;
            this.lb_Add2.Text = "B";
            // 
            // lb_Sub1
            // 
            this.lb_Sub1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Sub1.AutoSize = true;
            this.lb_Sub1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sub1.Location = new System.Drawing.Point(108, 112);
            this.lb_Sub1.Name = "lb_Sub1";
            this.lb_Sub1.Size = new System.Drawing.Size(29, 26);
            this.lb_Sub1.TabIndex = 16;
            this.lb_Sub1.Text = "A";
            // 
            // lb_Sub2
            // 
            this.lb_Sub2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Sub2.AutoSize = true;
            this.lb_Sub2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sub2.Location = new System.Drawing.Point(246, 112);
            this.lb_Sub2.Name = "lb_Sub2";
            this.lb_Sub2.Size = new System.Drawing.Size(28, 26);
            this.lb_Sub2.TabIndex = 17;
            this.lb_Sub2.Text = "B";
            // 
            // lb_Mult1
            // 
            this.lb_Mult1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Mult1.AutoSize = true;
            this.lb_Mult1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mult1.Location = new System.Drawing.Point(108, 173);
            this.lb_Mult1.Name = "lb_Mult1";
            this.lb_Mult1.Size = new System.Drawing.Size(29, 26);
            this.lb_Mult1.TabIndex = 18;
            this.lb_Mult1.Text = "A";
            // 
            // lb_Mult2
            // 
            this.lb_Mult2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Mult2.AutoSize = true;
            this.lb_Mult2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mult2.Location = new System.Drawing.Point(246, 173);
            this.lb_Mult2.Name = "lb_Mult2";
            this.lb_Mult2.Size = new System.Drawing.Size(28, 26);
            this.lb_Mult2.TabIndex = 19;
            this.lb_Mult2.Text = "B";
            // 
            // lb_Div1
            // 
            this.lb_Div1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Div1.AutoSize = true;
            this.lb_Div1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Div1.Location = new System.Drawing.Point(108, 235);
            this.lb_Div1.Name = "lb_Div1";
            this.lb_Div1.Size = new System.Drawing.Size(29, 26);
            this.lb_Div1.TabIndex = 20;
            this.lb_Div1.Text = "A";
            // 
            // lb_Div2
            // 
            this.lb_Div2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Div2.AutoSize = true;
            this.lb_Div2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Div2.Location = new System.Drawing.Point(246, 235);
            this.lb_Div2.Name = "lb_Div2";
            this.lb_Div2.Size = new System.Drawing.Size(28, 26);
            this.lb_Div2.TabIndex = 21;
            this.lb_Div2.Text = "B";
            // 
            // lbDiv
            // 
            this.lbDiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiv.AutoSize = true;
            this.lbDiv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiv.Location = new System.Drawing.Point(187, 235);
            this.lbDiv.Name = "lbDiv";
            this.lbDiv.Size = new System.Drawing.Size(19, 26);
            this.lbDiv.TabIndex = 25;
            this.lbDiv.Text = "/";
            // 
            // lbMult
            // 
            this.lbMult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMult.AutoSize = true;
            this.lbMult.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMult.Location = new System.Drawing.Point(187, 173);
            this.lbMult.Name = "lbMult";
            this.lbMult.Size = new System.Drawing.Size(24, 26);
            this.lbMult.TabIndex = 24;
            this.lbMult.Text = "x";
            // 
            // lbSub
            // 
            this.lbSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSub.AutoSize = true;
            this.lbSub.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSub.Location = new System.Drawing.Point(187, 112);
            this.lbSub.Name = "lbSub";
            this.lbSub.Size = new System.Drawing.Size(20, 26);
            this.lbSub.TabIndex = 23;
            this.lbSub.Text = "-";
            // 
            // lbAdd
            // 
            this.lbAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAdd.AutoSize = true;
            this.lbAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdd.Location = new System.Drawing.Point(184, 53);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(26, 26);
            this.lbAdd.TabIndex = 22;
            this.lbAdd.Text = "+";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "Chia:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(16, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nhân:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Trừ:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(16, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cộng:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 26);
            this.label5.TabIndex = 33;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 26);
            this.label6.TabIndex = 32;
            this.label6.Text = "=";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(305, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 26);
            this.label7.TabIndex = 31;
            this.label7.Text = "=";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(305, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 26);
            this.label8.TabIndex = 30;
            this.label8.Text = "=";
            // 
            // groupBoxQuiz
            // 
            this.groupBoxQuiz.Controls.Add(this.labelAns4);
            this.groupBoxQuiz.Controls.Add(this.label5);
            this.groupBoxQuiz.Controls.Add(this.label6);
            this.groupBoxQuiz.Controls.Add(this.label7);
            this.groupBoxQuiz.Controls.Add(this.label8);
            this.groupBoxQuiz.Controls.Add(this.labelAns3);
            this.groupBoxQuiz.Controls.Add(this.label1);
            this.groupBoxQuiz.Controls.Add(this.label2);
            this.groupBoxQuiz.Controls.Add(this.label3);
            this.groupBoxQuiz.Controls.Add(this.textBoxMult);
            this.groupBoxQuiz.Controls.Add(this.labelAns2);
            this.groupBoxQuiz.Controls.Add(this.label4);
            this.groupBoxQuiz.Controls.Add(this.textBoxDiv);
            this.groupBoxQuiz.Controls.Add(this.lbDiv);
            this.groupBoxQuiz.Controls.Add(this.textBoxAdd);
            this.groupBoxQuiz.Controls.Add(this.lbMult);
            this.groupBoxQuiz.Controls.Add(this.textBoxSub);
            this.groupBoxQuiz.Controls.Add(this.lbSub);
            this.groupBoxQuiz.Controls.Add(this.labelAns1);
            this.groupBoxQuiz.Controls.Add(this.lbAdd);
            this.groupBoxQuiz.Controls.Add(this.lb_Div2);
            this.groupBoxQuiz.Controls.Add(this.lb_Div1);
            this.groupBoxQuiz.Controls.Add(this.lb_Mult2);
            this.groupBoxQuiz.Controls.Add(this.lb_Mult1);
            this.groupBoxQuiz.Controls.Add(this.lb_Sub2);
            this.groupBoxQuiz.Controls.Add(this.lb_Sub1);
            this.groupBoxQuiz.Controls.Add(this.lb_Add2);
            this.groupBoxQuiz.Controls.Add(this.lb_Add1);
            this.groupBoxQuiz.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxQuiz.Location = new System.Drawing.Point(11, 47);
            this.groupBoxQuiz.Name = "groupBoxQuiz";
            this.groupBoxQuiz.Size = new System.Drawing.Size(509, 296);
            this.groupBoxQuiz.TabIndex = 34;
            this.groupBoxQuiz.TabStop = false;
            this.groupBoxQuiz.Text = "Quiz";
            // 
            // labelAns4
            // 
            this.labelAns4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAns4.AutoSize = true;
            this.labelAns4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAns4.ForeColor = System.Drawing.Color.Red;
            this.labelAns4.Location = new System.Drawing.Point(440, 235);
            this.labelAns4.Name = "labelAns4";
            this.labelAns4.Size = new System.Drawing.Size(0, 32);
            this.labelAns4.TabIndex = 37;
            // 
            // labelAns3
            // 
            this.labelAns3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAns3.AutoSize = true;
            this.labelAns3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAns3.ForeColor = System.Drawing.Color.Red;
            this.labelAns3.Location = new System.Drawing.Point(440, 173);
            this.labelAns3.Name = "labelAns3";
            this.labelAns3.Size = new System.Drawing.Size(0, 32);
            this.labelAns3.TabIndex = 36;
            // 
            // labelAns2
            // 
            this.labelAns2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAns2.AutoSize = true;
            this.labelAns2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAns2.ForeColor = System.Drawing.Color.Red;
            this.labelAns2.Location = new System.Drawing.Point(440, 112);
            this.labelAns2.Name = "labelAns2";
            this.labelAns2.Size = new System.Drawing.Size(0, 32);
            this.labelAns2.TabIndex = 35;
            // 
            // labelAns1
            // 
            this.labelAns1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAns1.AutoSize = true;
            this.labelAns1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAns1.ForeColor = System.Drawing.Color.Red;
            this.labelAns1.Location = new System.Drawing.Point(440, 53);
            this.labelAns1.Name = "labelAns1";
            this.labelAns1.Size = new System.Drawing.Size(0, 32);
            this.labelAns1.TabIndex = 34;
            // 
            // labelPtn
            // 
            this.labelPtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPtn.AutoSize = true;
            this.labelPtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPtn.ForeColor = System.Drawing.Color.Red;
            this.labelPtn.Location = new System.Drawing.Point(9, 13);
            this.labelPtn.Name = "labelPtn";
            this.labelPtn.Size = new System.Drawing.Size(92, 35);
            this.labelPtn.TabIndex = 35;
            this.labelPtn.Text = "Điểm:";
            // 
            // labelPoint
            // 
            this.labelPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoint.AutoSize = true;
            this.labelPoint.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoint.ForeColor = System.Drawing.Color.Red;
            this.labelPoint.Location = new System.Drawing.Point(107, 13);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(30, 35);
            this.labelPoint.TabIndex = 36;
            this.labelPoint.Text = "0";
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Start.AutoSize = true;
            this.btn_Start.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(21, 88);
            this.btn_Start.MinimumSize = new System.Drawing.Size(150, 50);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(150, 50);
            this.btn_Start.TabIndex = 37;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(21, 186);
            this.btn_Exit.MinimumSize = new System.Drawing.Size(150, 50);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(150, 50);
            this.btn_Exit.TabIndex = 38;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbCount
            // 
            this.lbCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCount.AutoSize = true;
            this.lbCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbCount.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.ForeColor = System.Drawing.Color.Black;
            this.lbCount.Location = new System.Drawing.Point(7, 9);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(116, 35);
            this.lbCount.TabIndex = 39;
            this.lbCount.Text = "Còn lại:";
            // 
            // groupBoxMenu2
            // 
            this.groupBoxMenu2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMenu2.Controls.Add(this.btn_Exit);
            this.groupBoxMenu2.Controls.Add(this.btn_Quit);
            this.groupBoxMenu2.Controls.Add(this.btn_Start);
            this.groupBoxMenu2.Controls.Add(this.btn_Continue);
            this.groupBoxMenu2.Controls.Add(this.btn_Submit);
            this.groupBoxMenu2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMenu2.Location = new System.Drawing.Point(526, 47);
            this.groupBoxMenu2.Name = "groupBoxMenu2";
            this.groupBoxMenu2.Size = new System.Drawing.Size(189, 296);
            this.groupBoxMenu2.TabIndex = 42;
            this.groupBoxMenu2.TabStop = false;
            this.groupBoxMenu2.Text = "Menu";
            // 
            // lbTimer
            // 
            this.lbTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.Red;
            this.lbTimer.Location = new System.Drawing.Point(141, 9);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(45, 35);
            this.lbTimer.TabIndex = 40;
            this.lbTimer.Text = "30";
            // 
            // lbSecond
            // 
            this.lbSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSecond.AutoSize = true;
            this.lbSecond.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecond.ForeColor = System.Drawing.Color.Black;
            this.lbSecond.Location = new System.Drawing.Point(194, 9);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(67, 35);
            this.lbSecond.TabIndex = 41;
            this.lbSecond.Text = "giây";
            // 
            // groupBoxTimer
            // 
            this.groupBoxTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTimer.Controls.Add(this.lbSecond);
            this.groupBoxTimer.Controls.Add(this.lbTimer);
            this.groupBoxTimer.Controls.Add(this.lbCount);
            this.groupBoxTimer.Location = new System.Drawing.Point(445, 344);
            this.groupBoxTimer.Name = "groupBoxTimer";
            this.groupBoxTimer.Size = new System.Drawing.Size(270, 51);
            this.groupBoxTimer.TabIndex = 44;
            this.groupBoxTimer.TabStop = false;
            this.groupBoxTimer.Visible = false;
            // 
            // groupBoxPoint
            // 
            this.groupBoxPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxPoint.Controls.Add(this.labelPoint);
            this.groupBoxPoint.Controls.Add(this.labelPtn);
            this.groupBoxPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxPoint.Location = new System.Drawing.Point(11, 344);
            this.groupBoxPoint.Name = "groupBoxPoint";
            this.groupBoxPoint.Size = new System.Drawing.Size(174, 51);
            this.groupBoxPoint.TabIndex = 45;
            this.groupBoxPoint.TabStop = false;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.ForeColor = System.Drawing.Color.Blue;
            this.labelQuestion.Location = new System.Drawing.Point(0, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(188, 32);
            this.labelQuestion.TabIndex = 46;
            this.labelQuestion.Text = "Question Set #";
            // 
            // MathGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 402);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.groupBoxPoint);
            this.Controls.Add(this.groupBoxTimer);
            this.Controls.Add(this.groupBoxMenu2);
            this.Controls.Add(this.groupBoxQuiz);
            this.Name = "MathGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathGame";
            this.groupBoxQuiz.ResumeLayout(false);
            this.groupBoxQuiz.PerformLayout();
            this.groupBoxMenu2.ResumeLayout(false);
            this.groupBoxMenu2.PerformLayout();
            this.groupBoxTimer.ResumeLayout(false);
            this.groupBoxTimer.PerformLayout();
            this.groupBoxPoint.ResumeLayout(false);
            this.groupBoxPoint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.Button btn_Quit;
        
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.TextBox textBoxSub;
        private System.Windows.Forms.TextBox textBoxMult;
        private System.Windows.Forms.TextBox textBoxDiv;
        private System.Windows.Forms.Label lb_Add1;
        private System.Windows.Forms.Label lb_Add2;
        private System.Windows.Forms.Label lb_Sub1;
        private System.Windows.Forms.Label lb_Sub2;
        private System.Windows.Forms.Label lb_Mult1;
        private System.Windows.Forms.Label lb_Mult2;
        private System.Windows.Forms.Label lb_Div1;
        private System.Windows.Forms.Label lb_Div2;
        private System.Windows.Forms.Label lbDiv;
        private System.Windows.Forms.Label lbMult;
        private System.Windows.Forms.Label lbSub;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxQuiz;
        private System.Windows.Forms.Label labelAns4;
        private System.Windows.Forms.Label labelAns3;
        private System.Windows.Forms.Label labelAns2;
        private System.Windows.Forms.Label labelAns1;
        private System.Windows.Forms.Label labelPtn;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.GroupBox groupBoxMenu2;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.GroupBox groupBoxTimer;
        private System.Windows.Forms.GroupBox groupBoxPoint;
        private System.Windows.Forms.Label labelQuestion;
    }
}

