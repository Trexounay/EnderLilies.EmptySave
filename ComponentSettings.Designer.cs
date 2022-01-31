
namespace EnderLilies.EmptySave
{
    partial class ComponentSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameSlot2 = new System.Windows.Forms.RadioButton();
            this.gameSlot3 = new System.Windows.Forms.RadioButton();
            this.gameSlot1 = new System.Windows.Forms.RadioButton();
            this.slotsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.autoOnReset = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.slotsContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameSlot2
            // 
            this.gameSlot2.AutoSize = true;
            this.gameSlot2.Location = new System.Drawing.Point(8, 31);
            this.gameSlot2.Name = "gameSlot2";
            this.gameSlot2.Size = new System.Drawing.Size(83, 17);
            this.gameSlot2.TabIndex = 0;
            this.gameSlot2.Text = "Game Slot 2";
            this.toolTip1.SetToolTip(this.gameSlot2, "Replace Game Slot 2");
            this.gameSlot2.UseVisualStyleBackColor = true;
            // 
            // gameSlot3
            // 
            this.gameSlot3.AutoSize = true;
            this.gameSlot3.Location = new System.Drawing.Point(8, 54);
            this.gameSlot3.Name = "gameSlot3";
            this.gameSlot3.Size = new System.Drawing.Size(83, 17);
            this.gameSlot3.TabIndex = 1;
            this.gameSlot3.Text = "Game Slot 3";
            this.toolTip1.SetToolTip(this.gameSlot3, "Replace Game Slot 3");
            this.gameSlot3.UseVisualStyleBackColor = true;
            // 
            // gameSlot1
            // 
            this.gameSlot1.AutoSize = true;
            this.gameSlot1.Checked = true;
            this.gameSlot1.Location = new System.Drawing.Point(8, 8);
            this.gameSlot1.Name = "gameSlot1";
            this.gameSlot1.Size = new System.Drawing.Size(83, 17);
            this.gameSlot1.TabIndex = 2;
            this.gameSlot1.TabStop = true;
            this.gameSlot1.Text = "Game Slot 1";
            this.toolTip1.SetToolTip(this.gameSlot1, "Replace Game Slot 1");
            this.gameSlot1.UseVisualStyleBackColor = true;
            // 
            // slotsContainer
            // 
            this.slotsContainer.Controls.Add(this.gameSlot1);
            this.slotsContainer.Controls.Add(this.gameSlot2);
            this.slotsContainer.Controls.Add(this.gameSlot3);
            this.slotsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slotsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.slotsContainer.Location = new System.Drawing.Point(5, 18);
            this.slotsContainer.Name = "slotsContainer";
            this.slotsContainer.Padding = new System.Windows.Forms.Padding(5);
            this.slotsContainer.Size = new System.Drawing.Size(465, 92);
            this.slotsContainer.TabIndex = 3;
            // 
            // autoOnReset
            // 
            this.autoOnReset.AutoSize = true;
            this.autoOnReset.Location = new System.Drawing.Point(24, 25);
            this.autoOnReset.Name = "autoOnReset";
            this.autoOnReset.Size = new System.Drawing.Size(103, 17);
            this.autoOnReset.TabIndex = 4;
            this.autoOnReset.Text = "Create on Reset";
            this.toolTip1.SetToolTip(this.autoOnReset, "Create an empty save file in the selected Game Slot whenever LiveSplit Resets\r\n");
            this.autoOnReset.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.autoOnReset);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 541);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.slotsContainer);
            this.groupBox2.Location = new System.Drawing.Point(13, 55);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(475, 115);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save slot to replace";
            // 
            // ComponentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ComponentSettings";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(521, 561);
            this.slotsContainer.ResumeLayout(false);
            this.slotsContainer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton gameSlot2;
        private System.Windows.Forms.RadioButton gameSlot3;
        private System.Windows.Forms.RadioButton gameSlot1;
        private System.Windows.Forms.FlowLayoutPanel slotsContainer;
        private System.Windows.Forms.CheckBox autoOnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
