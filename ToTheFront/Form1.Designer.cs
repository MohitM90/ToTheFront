namespace ToTheFront {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.txtHandle = new System.Windows.Forms.TextBox();
            this.btnToFront = new System.Windows.Forms.Button();
            this.btnToNormal = new System.Windows.Forms.Button();
            this.chkOnTop = new System.Windows.Forms.CheckBox();
            this.tmrGetHandle = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtHandle
            // 
            this.txtHandle.Location = new System.Drawing.Point(12, 12);
            this.txtHandle.Name = "txtHandle";
            this.txtHandle.Size = new System.Drawing.Size(128, 20);
            this.txtHandle.TabIndex = 0;
            // 
            // btnToFront
            // 
            this.btnToFront.Location = new System.Drawing.Point(12, 38);
            this.btnToFront.Name = "btnToFront";
            this.btnToFront.Size = new System.Drawing.Size(128, 23);
            this.btnToFront.TabIndex = 1;
            this.btnToFront.Text = "In den Vordergrund";
            this.btnToFront.UseVisualStyleBackColor = true;
            this.btnToFront.Click += new System.EventHandler(this.btnToFront_Click);
            // 
            // btnToNormal
            // 
            this.btnToNormal.Location = new System.Drawing.Point(12, 67);
            this.btnToNormal.Name = "btnToNormal";
            this.btnToNormal.Size = new System.Drawing.Size(128, 23);
            this.btnToNormal.TabIndex = 2;
            this.btnToNormal.Text = "Wirkung aufheben";
            this.btnToNormal.UseVisualStyleBackColor = true;
            this.btnToNormal.Click += new System.EventHandler(this.btnToNormal_Click);
            // 
            // chkOnTop
            // 
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.Location = new System.Drawing.Point(12, 96);
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.Size = new System.Drawing.Size(128, 17);
            this.chkOnTop.TabIndex = 3;
            this.chkOnTop.Text = "Immer im Vordergrund";
            this.chkOnTop.UseVisualStyleBackColor = true;
            this.chkOnTop.CheckedChanged += new System.EventHandler(this.chkOnTop_CheckedChanged);
            // 
            // tmrGetHandle
            // 
            this.tmrGetHandle.Enabled = true;
            this.tmrGetHandle.Interval = 1;
            this.tmrGetHandle.Tick += new System.EventHandler(this.tmrGetHandle_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 126);
            this.Controls.Add(this.chkOnTop);
            this.Controls.Add(this.btnToNormal);
            this.Controls.Add(this.btnToFront);
            this.Controls.Add(this.txtHandle);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHandle;
        private System.Windows.Forms.Button btnToFront;
        private System.Windows.Forms.Button btnToNormal;
        private System.Windows.Forms.CheckBox chkOnTop;
        private System.Windows.Forms.Timer tmrGetHandle;
    }
}

