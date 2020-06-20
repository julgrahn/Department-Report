namespace Avdelningsrapport_2
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
            this.Connect = new System.Windows.Forms.Button();
            this.SendObjects = new System.Windows.Forms.Button();
            this.MarkObject = new System.Windows.Forms.Button();
            this.LoadList = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Connect.Location = new System.Drawing.Point(11, 492);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(193, 104);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect to server";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // SendObjects
            // 
            this.SendObjects.Enabled = false;
            this.SendObjects.Location = new System.Drawing.Point(209, 492);
            this.SendObjects.Name = "SendObjects";
            this.SendObjects.Size = new System.Drawing.Size(133, 34);
            this.SendObjects.TabIndex = 2;
            this.SendObjects.Text = "Send all objects";
            this.SendObjects.UseVisualStyleBackColor = true;
            this.SendObjects.Click += new System.EventHandler(this.SendObjects_Click);
            // 
            // MarkObject
            // 
            this.MarkObject.Enabled = false;
            this.MarkObject.Location = new System.Drawing.Point(209, 530);
            this.MarkObject.Name = "MarkObject";
            this.MarkObject.Size = new System.Drawing.Size(132, 31);
            this.MarkObject.TabIndex = 3;
            this.MarkObject.Text = "Send highlighted object";
            this.MarkObject.UseVisualStyleBackColor = true;
            this.MarkObject.Click += new System.EventHandler(this.MarkObject_Click);
            // 
            // LoadList
            // 
            this.LoadList.Location = new System.Drawing.Point(209, 567);
            this.LoadList.Name = "LoadList";
            this.LoadList.Size = new System.Drawing.Size(133, 29);
            this.LoadList.TabIndex = 4;
            this.LoadList.Text = "Load list";
            this.LoadList.UseVisualStyleBackColor = true;
            this.LoadList.Click += new System.EventHandler(this.LoadList_Click);
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 22;
            this.ListBox.Location = new System.Drawing.Point(13, 13);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(544, 466);
            this.ListBox.TabIndex = 5;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 597);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.LoadList);
            this.Controls.Add(this.MarkObject);
            this.Controls.Add(this.SendObjects);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Avdelningsrapport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button SendObjects;
        private System.Windows.Forms.Button MarkObject;
        private System.Windows.Forms.Button LoadList;
        private System.Windows.Forms.ListBox ListBox;
    }
}

