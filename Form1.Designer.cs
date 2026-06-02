namespace Stadium_Seating
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
            this.ticketsSold = new System.Windows.Forms.TextBox();
            this.instructions = new System.Windows.Forms.TextBox();
            this.classA = new System.Windows.Forms.TextBox();
            this.classB = new System.Windows.Forms.TextBox();
            this.classC = new System.Windows.Forms.TextBox();
            this.classAinput = new System.Windows.Forms.TextBox();
            this.classBinput = new System.Windows.Forms.TextBox();
            this.classCinput = new System.Windows.Forms.TextBox();
            this.Revenue = new System.Windows.Forms.TextBox();
            this.classAo = new System.Windows.Forms.TextBox();
            this.classBo = new System.Windows.Forms.TextBox();
            this.classCo = new System.Windows.Forms.TextBox();
            this.totalO = new System.Windows.Forms.TextBox();
            this.classAoutput = new System.Windows.Forms.TextBox();
            this.classBoutput = new System.Windows.Forms.TextBox();
            this.classCoutput = new System.Windows.Forms.TextBox();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ticketsSold
            // 
            this.ticketsSold.BackColor = System.Drawing.SystemColors.Control;
            this.ticketsSold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ticketsSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsSold.Location = new System.Drawing.Point(12, 12);
            this.ticketsSold.Name = "ticketsSold";
            this.ticketsSold.Size = new System.Drawing.Size(100, 15);
            this.ticketsSold.TabIndex = 0;
            this.ticketsSold.Text = "Tickets Sold";
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.SystemColors.Control;
            this.instructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.Location = new System.Drawing.Point(26, 56);
            this.instructions.Multiline = true;
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(182, 46);
            this.instructions.TabIndex = 1;
            this.instructions.Text = "Enter the number of tickets sold for each class of seats.";
            this.instructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.instructions.WordWrap = false;
            // 
            // classA
            // 
            this.classA.BackColor = System.Drawing.SystemColors.Control;
            this.classA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classA.Location = new System.Drawing.Point(38, 120);
            this.classA.Name = "classA";
            this.classA.Size = new System.Drawing.Size(100, 13);
            this.classA.TabIndex = 2;
            this.classA.Text = "CLass A:";
            // 
            // classB
            // 
            this.classB.BackColor = System.Drawing.SystemColors.Control;
            this.classB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classB.Location = new System.Drawing.Point(38, 172);
            this.classB.Name = "classB";
            this.classB.Size = new System.Drawing.Size(100, 13);
            this.classB.TabIndex = 3;
            this.classB.Text = "CLass B:";
            // 
            // classC
            // 
            this.classC.BackColor = System.Drawing.SystemColors.Control;
            this.classC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classC.Location = new System.Drawing.Point(38, 223);
            this.classC.Name = "classC";
            this.classC.Size = new System.Drawing.Size(100, 13);
            this.classC.TabIndex = 4;
            this.classC.Text = "CLass C:";
            // 
            // classAinput
            // 
            this.classAinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classAinput.Location = new System.Drawing.Point(90, 118);
            this.classAinput.Name = "classAinput";
            this.classAinput.Size = new System.Drawing.Size(100, 20);
            this.classAinput.TabIndex = 5;
            // 
            // classBinput
            // 
            this.classBinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBinput.Location = new System.Drawing.Point(90, 170);
            this.classBinput.Name = "classBinput";
            this.classBinput.Size = new System.Drawing.Size(100, 20);
            this.classBinput.TabIndex = 6;
            // 
            // classCinput
            // 
            this.classCinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classCinput.Location = new System.Drawing.Point(90, 221);
            this.classCinput.Name = "classCinput";
            this.classCinput.Size = new System.Drawing.Size(100, 20);
            this.classCinput.TabIndex = 7;
            // 
            // Revenue
            // 
            this.Revenue.BackColor = System.Drawing.SystemColors.Control;
            this.Revenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Revenue.Location = new System.Drawing.Point(493, 12);
            this.Revenue.Name = "Revenue";
            this.Revenue.Size = new System.Drawing.Size(143, 15);
            this.Revenue.TabIndex = 8;
            this.Revenue.Text = "Revenue Generated";
            // 
            // classAo
            // 
            this.classAo.BackColor = System.Drawing.SystemColors.Control;
            this.classAo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classAo.Location = new System.Drawing.Point(493, 76);
            this.classAo.Name = "classAo";
            this.classAo.Size = new System.Drawing.Size(47, 13);
            this.classAo.TabIndex = 9;
            this.classAo.Text = "CLass A:";
            // 
            // classBo
            // 
            this.classBo.BackColor = System.Drawing.SystemColors.Control;
            this.classBo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classBo.Location = new System.Drawing.Point(493, 125);
            this.classBo.Name = "classBo";
            this.classBo.Size = new System.Drawing.Size(47, 13);
            this.classBo.TabIndex = 10;
            this.classBo.Text = "CLass B:";
            // 
            // classCo
            // 
            this.classCo.BackColor = System.Drawing.SystemColors.Control;
            this.classCo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classCo.Location = new System.Drawing.Point(493, 170);
            this.classCo.Name = "classCo";
            this.classCo.Size = new System.Drawing.Size(47, 13);
            this.classCo.TabIndex = 11;
            this.classCo.Text = "CLass C:";
            // 
            // totalO
            // 
            this.totalO.BackColor = System.Drawing.SystemColors.Control;
            this.totalO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalO.Location = new System.Drawing.Point(493, 221);
            this.totalO.Name = "totalO";
            this.totalO.Size = new System.Drawing.Size(60, 13);
            this.totalO.TabIndex = 12;
            this.totalO.Text = "Total:";
            // 
            // classAoutput
            // 
            this.classAoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classAoutput.Location = new System.Drawing.Point(546, 74);
            this.classAoutput.Name = "classAoutput";
            this.classAoutput.Size = new System.Drawing.Size(100, 20);
            this.classAoutput.TabIndex = 13;
            // 
            // classBoutput
            // 
            this.classBoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBoutput.Location = new System.Drawing.Point(546, 120);
            this.classBoutput.Name = "classBoutput";
            this.classBoutput.Size = new System.Drawing.Size(100, 20);
            this.classBoutput.TabIndex = 14;
            // 
            // classCoutput
            // 
            this.classCoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classCoutput.Location = new System.Drawing.Point(546, 165);
            this.classCoutput.Name = "classCoutput";
            this.classCoutput.Size = new System.Drawing.Size(100, 20);
            this.classCoutput.TabIndex = 15;
            // 
            // totalOutput
            // 
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutput.Location = new System.Drawing.Point(546, 214);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 20);
            this.totalOutput.TabIndex = 16;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(148, 330);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(118, 75);
            this.CalcBtn.TabIndex = 17;
            this.CalcBtn.Text = "Calculate Revenue";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(325, 330);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(118, 75);
            this.ClearBtn.TabIndex = 18;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(493, 330);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(118, 75);
            this.ExitBtn.TabIndex = 19;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.classCoutput);
            this.Controls.Add(this.classBoutput);
            this.Controls.Add(this.classAoutput);
            this.Controls.Add(this.totalO);
            this.Controls.Add(this.classCo);
            this.Controls.Add(this.classBo);
            this.Controls.Add(this.classAo);
            this.Controls.Add(this.Revenue);
            this.Controls.Add(this.classCinput);
            this.Controls.Add(this.classBinput);
            this.Controls.Add(this.classAinput);
            this.Controls.Add(this.classC);
            this.Controls.Add(this.classB);
            this.Controls.Add(this.classA);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.ticketsSold);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ticketsSold;
        private System.Windows.Forms.TextBox instructions;
        private System.Windows.Forms.TextBox classA;
        private System.Windows.Forms.TextBox classB;
        private System.Windows.Forms.TextBox classC;
        private System.Windows.Forms.TextBox classAinput;
        private System.Windows.Forms.TextBox classBinput;
        private System.Windows.Forms.TextBox classCinput;
        private System.Windows.Forms.TextBox Revenue;
        private System.Windows.Forms.TextBox classAo;
        private System.Windows.Forms.TextBox classBo;
        private System.Windows.Forms.TextBox classCo;
        private System.Windows.Forms.TextBox totalO;
        private System.Windows.Forms.TextBox classAoutput;
        private System.Windows.Forms.TextBox classBoutput;
        private System.Windows.Forms.TextBox classCoutput;
        private System.Windows.Forms.TextBox totalOutput;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

