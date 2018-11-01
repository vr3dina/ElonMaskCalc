namespace EM.Calc.WinFormsApp
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
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.lblResultL = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblInputErr = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.lblOperands = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbOperation
            // 
            this.cbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbOperation.Location = new System.Drawing.Point(53, 44);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(159, 25);
            this.cbOperation.Sorted = true;
            this.cbOperation.TabIndex = 0;
            this.cbOperation.SelectedIndexChanged += new System.EventHandler(this.cbOperation_SelectedIndexChanged);
            // 
            // lblResultL
            // 
            this.lblResultL.AutoSize = true;
            this.lblResultL.Font = new System.Drawing.Font("Cambria", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultL.Location = new System.Drawing.Point(54, 164);
            this.lblResultL.Name = "lblResultL";
            this.lblResultL.Size = new System.Drawing.Size(80, 19);
            this.lblResultL.TabIndex = 1;
            this.lblResultL.Text = "Результат";
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("NSimSun", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(53, 103);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(387, 28);
            this.tbInput.TabIndex = 2;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // btnExec
            // 
            this.btnExec.Font = new System.Drawing.Font("Cambria", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExec.Location = new System.Drawing.Point(446, 90);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(91, 54);
            this.btnExec.TabIndex = 3;
            this.btnExec.Text = "Вычислить";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(332, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = " 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(384, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = " 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(436, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 45);
            this.button4.TabIndex = 6;
            this.button4.Text = " 3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(491, 150);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 45);
            this.button5.TabIndex = 7;
            this.button5.Text = " 4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // lblInputErr
            // 
            this.lblInputErr.AutoSize = true;
            this.lblInputErr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInputErr.Location = new System.Drawing.Point(49, 133);
            this.lblInputErr.Name = "lblInputErr";
            this.lblInputErr.Size = new System.Drawing.Size(0, 19);
            this.lblInputErr.TabIndex = 8;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(54, 23);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(159, 19);
            this.lblOperation.TabIndex = 9;
            this.lblOperation.Text = "Выберите операцию";
            // 
            // lblOperands
            // 
            this.lblOperands.AutoSize = true;
            this.lblOperands.Location = new System.Drawing.Point(54, 81);
            this.lblOperands.Name = "lblOperands";
            this.lblOperands.Size = new System.Drawing.Size(146, 19);
            this.lblOperands.TabIndex = 10;
            this.lblOperands.Text = "Введите операдны";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Cambria", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(58, 187);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 22);
            this.lblResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 246);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblOperands);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.lblInputErr);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lblResultL);
            this.Controls.Add(this.cbOperation);
            this.Font = new System.Drawing.Font("Cambria", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.Label lblResultL;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblInputErr;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label lblOperands;
        private System.Windows.Forms.Label lblResult;
    }
}

