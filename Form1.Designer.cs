namespace Calculator
{
    partial class Form1
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
            this.buttoneight = new System.Windows.Forms.Button();
            this.buttonseven = new System.Windows.Forms.Button();
            this.buttonnine = new System.Windows.Forms.Button();
            this.buttondivide = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonmultiply = new System.Windows.Forms.Button();
            this.buttonsix = new System.Windows.Forms.Button();
            this.buttonfive = new System.Windows.Forms.Button();
            this.buttonfour = new System.Windows.Forms.Button();
            this.buttonsubtract = new System.Windows.Forms.Button();
            this.buttonthree = new System.Windows.Forms.Button();
            this.buttontwo = new System.Windows.Forms.Button();
            this.buttonone = new System.Windows.Forms.Button();
            this.buttonequalto = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttondot = new System.Windows.Forms.Button();
            this.buttonzero = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttoneight
            // 
            this.buttoneight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneight.Location = new System.Drawing.Point(127, 110);
            this.buttoneight.Name = "buttoneight";
            this.buttoneight.Size = new System.Drawing.Size(60, 60);
            this.buttoneight.TabIndex = 0;
            this.buttoneight.Text = "8";
            this.buttoneight.UseVisualStyleBackColor = true;
            this.buttoneight.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonseven
            // 
            this.buttonseven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonseven.Location = new System.Drawing.Point(61, 110);
            this.buttonseven.Name = "buttonseven";
            this.buttonseven.Size = new System.Drawing.Size(60, 60);
            this.buttonseven.TabIndex = 1;
            this.buttonseven.Text = "7";
            this.buttonseven.UseVisualStyleBackColor = true;
            this.buttonseven.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonnine
            // 
            this.buttonnine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnine.Location = new System.Drawing.Point(193, 110);
            this.buttonnine.Name = "buttonnine";
            this.buttonnine.Size = new System.Drawing.Size(60, 60);
            this.buttonnine.TabIndex = 2;
            this.buttonnine.Text = "9";
            this.buttonnine.UseVisualStyleBackColor = true;
            this.buttonnine.Click += new System.EventHandler(this.button_Click);
            // 
            // buttondivide
            // 
            this.buttondivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondivide.Location = new System.Drawing.Point(259, 110);
            this.buttondivide.Name = "buttondivide";
            this.buttondivide.Size = new System.Drawing.Size(60, 60);
            this.buttondivide.TabIndex = 3;
            this.buttondivide.Text = "/";
            this.buttondivide.UseVisualStyleBackColor = true;
            this.buttondivide.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(325, 110);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(60, 60);
            this.buttonCE.TabIndex = 4;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(325, 176);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(60, 60);
            this.buttonC.TabIndex = 9;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonmultiply
            // 
            this.buttonmultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmultiply.Location = new System.Drawing.Point(259, 176);
            this.buttonmultiply.Name = "buttonmultiply";
            this.buttonmultiply.Size = new System.Drawing.Size(60, 60);
            this.buttonmultiply.TabIndex = 8;
            this.buttonmultiply.Text = "*";
            this.buttonmultiply.UseVisualStyleBackColor = true;
            this.buttonmultiply.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonsix
            // 
            this.buttonsix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsix.Location = new System.Drawing.Point(193, 176);
            this.buttonsix.Name = "buttonsix";
            this.buttonsix.Size = new System.Drawing.Size(60, 60);
            this.buttonsix.TabIndex = 7;
            this.buttonsix.Text = "6";
            this.buttonsix.UseVisualStyleBackColor = true;
            this.buttonsix.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonfive
            // 
            this.buttonfive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfive.Location = new System.Drawing.Point(127, 176);
            this.buttonfive.Name = "buttonfive";
            this.buttonfive.Size = new System.Drawing.Size(60, 60);
            this.buttonfive.TabIndex = 6;
            this.buttonfive.Text = "5";
            this.buttonfive.UseVisualStyleBackColor = true;
            this.buttonfive.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonfour
            // 
            this.buttonfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfour.Location = new System.Drawing.Point(61, 176);
            this.buttonfour.Name = "buttonfour";
            this.buttonfour.Size = new System.Drawing.Size(60, 60);
            this.buttonfour.TabIndex = 5;
            this.buttonfour.Text = "4";
            this.buttonfour.UseVisualStyleBackColor = true;
            this.buttonfour.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonsubtract
            // 
            this.buttonsubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsubtract.Location = new System.Drawing.Point(259, 242);
            this.buttonsubtract.Name = "buttonsubtract";
            this.buttonsubtract.Size = new System.Drawing.Size(60, 60);
            this.buttonsubtract.TabIndex = 13;
            this.buttonsubtract.Text = "-";
            this.buttonsubtract.UseVisualStyleBackColor = true;
            this.buttonsubtract.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonthree
            // 
            this.buttonthree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonthree.Location = new System.Drawing.Point(193, 242);
            this.buttonthree.Name = "buttonthree";
            this.buttonthree.Size = new System.Drawing.Size(60, 60);
            this.buttonthree.TabIndex = 12;
            this.buttonthree.Text = "3";
            this.buttonthree.UseVisualStyleBackColor = true;
            this.buttonthree.Click += new System.EventHandler(this.button_Click);
            // 
            // buttontwo
            // 
            this.buttontwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontwo.Location = new System.Drawing.Point(127, 242);
            this.buttontwo.Name = "buttontwo";
            this.buttontwo.Size = new System.Drawing.Size(60, 60);
            this.buttontwo.TabIndex = 11;
            this.buttontwo.Text = "2";
            this.buttontwo.UseVisualStyleBackColor = true;
            this.buttontwo.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonone
            // 
            this.buttonone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonone.Location = new System.Drawing.Point(61, 242);
            this.buttonone.Name = "buttonone";
            this.buttonone.Size = new System.Drawing.Size(60, 60);
            this.buttonone.TabIndex = 10;
            this.buttonone.Text = "1";
            this.buttonone.UseVisualStyleBackColor = true;
            this.buttonone.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonequalto
            // 
            this.buttonequalto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonequalto.Location = new System.Drawing.Point(325, 242);
            this.buttonequalto.Name = "buttonequalto";
            this.buttonequalto.Size = new System.Drawing.Size(60, 126);
            this.buttonequalto.TabIndex = 19;
            this.buttonequalto.Text = "=";
            this.buttonequalto.UseVisualStyleBackColor = true;
            this.buttonequalto.Click += new System.EventHandler(this.buttonequalto_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.Location = new System.Drawing.Point(259, 308);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(60, 60);
            this.buttonadd.TabIndex = 18;
            this.buttonadd.Text = "+";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.operator_click);
            // 
            // buttondot
            // 
            this.buttondot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondot.Location = new System.Drawing.Point(193, 308);
            this.buttondot.Name = "buttondot";
            this.buttondot.Size = new System.Drawing.Size(60, 60);
            this.buttondot.TabIndex = 17;
            this.buttondot.Text = ".";
            this.buttondot.UseVisualStyleBackColor = true;
            this.buttondot.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonzero
            // 
            this.buttonzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonzero.Location = new System.Drawing.Point(61, 308);
            this.buttonzero.Name = "buttonzero";
            this.buttonzero.Size = new System.Drawing.Size(126, 60);
            this.buttonzero.TabIndex = 15;
            this.buttonzero.Text = "0";
            this.buttonzero.UseVisualStyleBackColor = true;
            this.buttonzero.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(61, 65);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(324, 39);
            this.textBoxResult.TabIndex = 20;
            this.textBoxResult.Text = "0";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 442);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonequalto);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.buttondot);
            this.Controls.Add(this.buttonzero);
            this.Controls.Add(this.buttonsubtract);
            this.Controls.Add(this.buttonthree);
            this.Controls.Add(this.buttontwo);
            this.Controls.Add(this.buttonone);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonmultiply);
            this.Controls.Add(this.buttonsix);
            this.Controls.Add(this.buttonfive);
            this.Controls.Add(this.buttonfour);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttondivide);
            this.Controls.Add(this.buttonnine);
            this.Controls.Add(this.buttonseven);
            this.Controls.Add(this.buttoneight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoneight;
        private System.Windows.Forms.Button buttonseven;
        private System.Windows.Forms.Button buttonnine;
        private System.Windows.Forms.Button buttondivide;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonmultiply;
        private System.Windows.Forms.Button buttonsix;
        private System.Windows.Forms.Button buttonfive;
        private System.Windows.Forms.Button buttonfour;
        private System.Windows.Forms.Button buttonsubtract;
        private System.Windows.Forms.Button buttonthree;
        private System.Windows.Forms.Button buttontwo;
        private System.Windows.Forms.Button buttonone;
        private System.Windows.Forms.Button buttonequalto;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttondot;
        private System.Windows.Forms.Button buttonzero;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

