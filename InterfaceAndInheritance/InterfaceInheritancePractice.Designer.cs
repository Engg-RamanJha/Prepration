
namespace InterfaceAndInheritance
{
    partial class InterfaceInheritancePractice
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
            this.buttonInterface = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInterface
            // 
            this.buttonInterface.Location = new System.Drawing.Point(54, 36);
            this.buttonInterface.Name = "buttonInterface";
            this.buttonInterface.Size = new System.Drawing.Size(157, 45);
            this.buttonInterface.TabIndex = 0;
            this.buttonInterface.Text = "Interface";
            this.buttonInterface.UseVisualStyleBackColor = true;
            this.buttonInterface.Click += new System.EventHandler(this.buttonInterface_Click);
            // 
            // InterfaceInheritancePractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 456);
            this.Controls.Add(this.buttonInterface);
            this.Name = "InterfaceInheritancePractice";
            this.Text = "Interface and Inheritance";
            this.Load += new System.EventHandler(this.InterfaceInheritancePractice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInterface;
    }
}

