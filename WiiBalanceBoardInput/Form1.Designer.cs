namespace WiiBalanceBoardInput
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.Button();
            this.TextStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextX = new System.Windows.Forms.Label();
            this.TextY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDirection = new System.Windows.Forms.Label();
            this.NESW = new System.Windows.Forms.Label();
            this.sendedKey = new System.Windows.Forms.Label();
            this.TextDirection = new System.Windows.Forms.Label();
            this.TextNESW = new System.Windows.Forms.Label();
            this.TextKeyDown = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextTopLeft = new System.Windows.Forms.Label();
            this.TextTopRight = new System.Windows.Forms.Label();
            this.TextCenter = new System.Windows.Forms.Label();
            this.TextBottomLeft = new System.Windows.Forms.Label();
            this.TextBottomRight = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextProgramName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(35, 378);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(207, 28);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Connect to Wii Balance Board";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextStatus
            // 
            this.TextStatus.AutoSize = true;
            this.TextStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextStatus.Location = new System.Drawing.Point(60, 415);
            this.TextStatus.Name = "TextStatus";
            this.TextStatus.Size = new System.Drawing.Size(155, 18);
            this.TextStatus.TabIndex = 1;
            this.TextStatus.Text = "Status: Not connected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Center of gravity:";
            // 
            // TextX
            // 
            this.TextX.AutoSize = true;
            this.TextX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextX.Location = new System.Drawing.Point(24, 95);
            this.TextX.Name = "TextX";
            this.TextX.Size = new System.Drawing.Size(22, 16);
            this.TextX.TabIndex = 3;
            this.TextX.Text = "X: ";
            // 
            // TextY
            // 
            this.TextY.AutoSize = true;
            this.TextY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextY.Location = new System.Drawing.Point(145, 95);
            this.TextY.Name = "TextY";
            this.TextY.Size = new System.Drawing.Size(23, 16);
            this.TextY.TabIndex = 4;
            this.TextY.Text = "Y: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Headed direction:";
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirection.Location = new System.Drawing.Point(159, 87);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(0, 15);
            this.labelDirection.TabIndex = 6;
            // 
            // NESW
            // 
            this.NESW.AutoSize = true;
            this.NESW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NESW.Location = new System.Drawing.Point(21, 282);
            this.NESW.Name = "NESW";
            this.NESW.Size = new System.Drawing.Size(55, 16);
            this.NESW.TabIndex = 7;
            this.NESW.Text = "NESW: ";
            // 
            // sendedKey
            // 
            this.sendedKey.AutoSize = true;
            this.sendedKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendedKey.Location = new System.Drawing.Point(21, 316);
            this.sendedKey.Name = "sendedKey";
            this.sendedKey.Size = new System.Drawing.Size(69, 16);
            this.sendedKey.TabIndex = 8;
            this.sendedKey.Text = "Key down:";
            // 
            // TextDirection
            // 
            this.TextDirection.AutoSize = true;
            this.TextDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDirection.Location = new System.Drawing.Point(197, 248);
            this.TextDirection.Name = "TextDirection";
            this.TextDirection.Size = new System.Drawing.Size(37, 15);
            this.TextDirection.TabIndex = 9;
            this.TextDirection.Text = "None";
            // 
            // TextNESW
            // 
            this.TextNESW.AutoSize = true;
            this.TextNESW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNESW.Location = new System.Drawing.Point(197, 283);
            this.TextNESW.Name = "TextNESW";
            this.TextNESW.Size = new System.Drawing.Size(37, 15);
            this.TextNESW.TabIndex = 10;
            this.TextNESW.Text = "None";
            // 
            // TextKeyDown
            // 
            this.TextKeyDown.AutoSize = true;
            this.TextKeyDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextKeyDown.Location = new System.Drawing.Point(197, 316);
            this.TextKeyDown.Name = "TextKeyDown";
            this.TextKeyDown.Size = new System.Drawing.Size(37, 15);
            this.TextKeyDown.TabIndex = 11;
            this.TextKeyDown.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Weight distribution:";
            // 
            // TextTopLeft
            // 
            this.TextTopLeft.AutoSize = true;
            this.TextTopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTopLeft.Location = new System.Drawing.Point(21, 159);
            this.TextTopLeft.Name = "TextTopLeft";
            this.TextTopLeft.Size = new System.Drawing.Size(47, 15);
            this.TextTopLeft.TabIndex = 14;
            this.TextTopLeft.Text = "Top left";
            // 
            // TextTopRight
            // 
            this.TextTopRight.AutoSize = true;
            this.TextTopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTopRight.Location = new System.Drawing.Point(177, 159);
            this.TextTopRight.Name = "TextTopRight";
            this.TextTopRight.Size = new System.Drawing.Size(55, 15);
            this.TextTopRight.TabIndex = 15;
            this.TextTopRight.Text = "Top right";
            // 
            // TextCenter
            // 
            this.TextCenter.AutoSize = true;
            this.TextCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCenter.Location = new System.Drawing.Point(110, 183);
            this.TextCenter.Name = "TextCenter";
            this.TextCenter.Size = new System.Drawing.Size(43, 15);
            this.TextCenter.TabIndex = 16;
            this.TextCenter.Text = "Center";
            // 
            // TextBottomLeft
            // 
            this.TextBottomLeft.AutoSize = true;
            this.TextBottomLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBottomLeft.Location = new System.Drawing.Point(21, 209);
            this.TextBottomLeft.Name = "TextBottomLeft";
            this.TextBottomLeft.Size = new System.Drawing.Size(65, 15);
            this.TextBottomLeft.TabIndex = 17;
            this.TextBottomLeft.Text = "Bottom left";
            // 
            // TextBottomRight
            // 
            this.TextBottomRight.AutoSize = true;
            this.TextBottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBottomRight.Location = new System.Drawing.Point(177, 209);
            this.TextBottomRight.Name = "TextBottomRight";
            this.TextBottomRight.Size = new System.Drawing.Size(73, 15);
            this.TextBottomRight.TabIndex = 18;
            this.TextBottomRight.Text = "Bottom right";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(76, 349);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 19);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Seated position";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Program to send keys to:";
            // 
            // TextProgramName
            // 
            this.TextProgramName.BackColor = System.Drawing.SystemColors.Window;
            this.TextProgramName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextProgramName.Location = new System.Drawing.Point(24, 33);
            this.TextProgramName.MaxLength = 256;
            this.TextProgramName.Name = "TextProgramName";
            this.TextProgramName.Size = new System.Drawing.Size(226, 21);
            this.TextProgramName.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 444);
            this.Controls.Add(this.TextProgramName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.TextBottomRight);
            this.Controls.Add(this.TextBottomLeft);
            this.Controls.Add(this.TextCenter);
            this.Controls.Add(this.TextTopRight);
            this.Controls.Add(this.TextTopLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextKeyDown);
            this.Controls.Add(this.TextNESW);
            this.Controls.Add(this.TextDirection);
            this.Controls.Add(this.sendedKey);
            this.Controls.Add(this.NESW);
            this.Controls.Add(this.labelDirection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextY);
            this.Controls.Add(this.TextX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextStatus);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WBC Input Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label TextStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TextX;
        private System.Windows.Forms.Label TextY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.Label NESW;
        private System.Windows.Forms.Label sendedKey;
        private System.Windows.Forms.Label TextDirection;
        private System.Windows.Forms.Label TextNESW;
        private System.Windows.Forms.Label TextKeyDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TextTopLeft;
        private System.Windows.Forms.Label TextTopRight;
        private System.Windows.Forms.Label TextCenter;
        private System.Windows.Forms.Label TextBottomLeft;
        private System.Windows.Forms.Label TextBottomRight;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextProgramName;
    }
}

