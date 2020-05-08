namespace DesktopPet
{
    partial class CareOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CareOptions));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.walkTabPage = new System.Windows.Forms.TabPage();
            this.walkLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.walkStartButton = new System.Windows.Forms.Button();
            this.walkStartTime = new System.Windows.Forms.Label();
            this.walkEndButton = new System.Windows.Forms.Button();
            this.walkEndTime = new System.Windows.Forms.Label();
            this.eatTabPage = new System.Windows.Forms.TabPage();
            this.eatLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.exerciseTabPage = new System.Windows.Forms.TabPage();
            this.exerciseLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.waterTabPage = new System.Windows.Forms.TabPage();
            this.waterLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.waterValueInput = new System.Windows.Forms.TextBox();
            this.waterValueButton = new System.Windows.Forms.Button();
            this.totalWaterLabel = new System.Windows.Forms.Label();
            this.sleepTabPage = new System.Windows.Forms.TabPage();
            this.sleepLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dressUpTabPage = new System.Windows.Forms.TabPage();
            this.dressUpLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.walkTabPage.SuspendLayout();
            this.walkLayoutPanel.SuspendLayout();
            this.eatTabPage.SuspendLayout();
            this.exerciseTabPage.SuspendLayout();
            this.waterTabPage.SuspendLayout();
            this.waterLayoutPanel.SuspendLayout();
            this.sleepTabPage.SuspendLayout();
            this.dressUpTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.walkTabPage);
            this.tabControl1.Controls.Add(this.eatTabPage);
            this.tabControl1.Controls.Add(this.exerciseTabPage);
            this.tabControl1.Controls.Add(this.waterTabPage);
            this.tabControl1.Controls.Add(this.sleepTabPage);
            this.tabControl1.Controls.Add(this.dressUpTabPage);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(40, 120);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 420);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // walkTabPage
            // 
            this.walkTabPage.Controls.Add(this.walkLayoutPanel);
            this.walkTabPage.Location = new System.Drawing.Point(124, 4);
            this.walkTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.walkTabPage.Name = "walkTabPage";
            this.walkTabPage.Size = new System.Drawing.Size(519, 412);
            this.walkTabPage.TabIndex = 0;
            this.walkTabPage.Text = "Walk";
            this.walkTabPage.UseVisualStyleBackColor = true;
            // 
            // walkLayoutPanel
            // 
            this.walkLayoutPanel.ColumnCount = 2;
            this.walkLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.walkLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.walkLayoutPanel.Controls.Add(this.walkStartButton, 0, 1);
            this.walkLayoutPanel.Controls.Add(this.walkEndButton, 0, 3);
            this.walkLayoutPanel.Controls.Add(this.walkStartTime, 0, 2);
            this.walkLayoutPanel.Controls.Add(this.walkEndTime, 0, 4);
            this.walkLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walkLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.walkLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.walkLayoutPanel.Name = "walkLayoutPanel";
            this.walkLayoutPanel.RowCount = 10;
            this.walkLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.83721F));
            this.walkLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.16279F));
            this.walkLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.walkLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.walkLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.walkLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.walkLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.walkLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.walkLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.walkLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.walkLayoutPanel.Size = new System.Drawing.Size(519, 412);
            this.walkLayoutPanel.TabIndex = 0;
            // 
            // walkStartButton
            // 
            this.walkStartButton.AutoSize = true;
            this.walkStartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walkStartButton.Location = new System.Drawing.Point(4, 21);
            this.walkStartButton.Margin = new System.Windows.Forms.Padding(4);
            this.walkStartButton.Name = "walkStartButton";
            this.walkStartButton.Size = new System.Drawing.Size(251, 47);
            this.walkStartButton.TabIndex = 0;
            this.walkStartButton.Text = "Start Walk";
            this.walkStartButton.UseVisualStyleBackColor = true;
            this.walkStartButton.Click += new System.EventHandler(this.walkStartClick);
            // 
            // walkStartLabel
            // 
            this.walkStartTime.AutoSize = true;
            this.walkStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walkStartTime.Location = new System.Drawing.Point(4, 21);
            this.walkStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.walkStartTime.Name = "walkStartTime";
            this.walkStartTime.Size = new System.Drawing.Size(251, 47);
            this.walkStartTime.TabIndex = 0;
            this.walkStartTime.Text = "";
            // 
            // walkEndButton
            // 
            this.walkEndButton.AutoSize = true;
            this.walkEndButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walkEndButton.Location = new System.Drawing.Point(4, 107);
            this.walkEndButton.Margin = new System.Windows.Forms.Padding(4);
            this.walkEndButton.Name = "walkEndButton";
            this.walkEndButton.Size = new System.Drawing.Size(251, 46);
            this.walkEndButton.TabIndex = 0;
            this.walkEndButton.Text = "End Walk";
            this.walkEndButton.UseVisualStyleBackColor = true;
            this.walkEndButton.Click += new System.EventHandler(this.walkEndClick);
            // 
            // walkEndLabel
            // 
            this.walkEndTime.AutoSize = true;
            this.walkEndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walkEndTime.Location = new System.Drawing.Point(4, 21);
            this.walkEndTime.Margin = new System.Windows.Forms.Padding(4);
            this.walkEndTime.Name = "walkEndTime";
            this.walkEndTime.Size = new System.Drawing.Size(251, 47);
            this.walkEndTime.TabIndex = 0;
            this.walkEndTime.Text = "";
            // 
            // eatTabPage
            // 
            this.eatTabPage.Controls.Add(this.eatLayoutPanel);
            this.eatTabPage.Location = new System.Drawing.Point(124, 4);
            this.eatTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.eatTabPage.Name = "eatTabPage";
            this.eatTabPage.Size = new System.Drawing.Size(519, 412);
            this.eatTabPage.TabIndex = 1;
            this.eatTabPage.Text = "Eat";
            this.eatTabPage.UseVisualStyleBackColor = true;
            // 
            // eatLayoutPanel
            // 
            this.eatLayoutPanel.ColumnCount = 2;
            this.eatLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.eatLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.eatLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eatLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.eatLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.eatLayoutPanel.Name = "eatLayoutPanel";
            this.eatLayoutPanel.RowCount = 10;
            this.eatLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.83721F));
            this.eatLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.16279F));
            this.eatLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.eatLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.eatLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.eatLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.eatLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.eatLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.eatLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.eatLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.eatLayoutPanel.Size = new System.Drawing.Size(519, 412);
            this.eatLayoutPanel.TabIndex = 0;
            // 
            // exerciseTabPage
            // 
            this.exerciseTabPage.Controls.Add(this.exerciseLayoutPanel);
            this.exerciseTabPage.Location = new System.Drawing.Point(124, 4);
            this.exerciseTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.exerciseTabPage.Name = "exerciseTabPage";
            this.exerciseTabPage.Size = new System.Drawing.Size(519, 412);
            this.exerciseTabPage.TabIndex = 1;
            this.exerciseTabPage.Text = "Exercise";
            this.exerciseTabPage.UseVisualStyleBackColor = true;
            // 
            // exerciseLayoutPanel
            // 
            this.exerciseLayoutPanel.ColumnCount = 2;
            this.exerciseLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.exerciseLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.exerciseLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exerciseLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.exerciseLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.exerciseLayoutPanel.Name = "exerciseLayoutPanel";
            this.exerciseLayoutPanel.RowCount = 10;
            this.exerciseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.83721F));
            this.exerciseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.16279F));
            this.exerciseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.exerciseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.exerciseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.exerciseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.exerciseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.exerciseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.exerciseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.exerciseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.exerciseLayoutPanel.Size = new System.Drawing.Size(519, 412);
            this.exerciseLayoutPanel.TabIndex = 0;
            // 
            // waterTabPage
            // 
            this.waterTabPage.Controls.Add(this.waterLayoutPanel);
            this.waterTabPage.Location = new System.Drawing.Point(124, 4);
            this.waterTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.waterTabPage.Name = "waterTabPage";
            this.waterTabPage.Size = new System.Drawing.Size(519, 412);
            this.waterTabPage.TabIndex = 1;
            this.waterTabPage.Text = "Water";
            this.waterTabPage.UseVisualStyleBackColor = true;
            // 
            // waterLayoutPanel
            // 
            this.waterLayoutPanel.ColumnCount = 2;
            this.waterLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.waterLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.waterLayoutPanel.Controls.Add(this.waterValueInput, 0, 0);
            this.waterLayoutPanel.Controls.Add(this.waterValueButton, 1, 0);
            this.waterLayoutPanel.Controls.Add(this.totalWaterLabel, 0, 1);
            this.waterLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.waterLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.waterLayoutPanel.Name = "waterLayoutPanel";
            this.waterLayoutPanel.RowCount = 10;
            this.waterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.waterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.waterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.waterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.waterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.waterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.waterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.waterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.waterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.waterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.waterLayoutPanel.Size = new System.Drawing.Size(519, 412);
            this.waterLayoutPanel.TabIndex = 0;
            // 
            // waterValueInput
            // 
            this.waterValueInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.waterValueInput.Location = new System.Drawing.Point(4, 36);
            this.waterValueInput.Margin = new System.Windows.Forms.Padding(4);
            this.waterValueInput.Name = "waterValueInput";
            this.waterValueInput.Size = new System.Drawing.Size(251, 22);
            this.waterValueInput.TabIndex = 0;
            // 
            // waterValueButton
            // 
            this.waterValueButton.AutoSize = true;
            this.waterValueButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.waterValueButton.Location = new System.Drawing.Point(263, 25);
            this.waterValueButton.Margin = new System.Windows.Forms.Padding(4);
            this.waterValueButton.Name = "waterValueButton";
            this.waterValueButton.Size = new System.Drawing.Size(252, 33);
            this.waterValueButton.TabIndex = 1;
            this.waterValueButton.Text = "Add oz of water";
            this.waterValueButton.UseVisualStyleBackColor = true;
            this.waterValueButton.Click += new System.EventHandler(this.waterValueAdded);
            // 
            // totalWaterLabel
            // 
            this.totalWaterLabel.AutoSize = true;
            this.waterLayoutPanel.SetColumnSpan(this.totalWaterLabel, 2);
            this.totalWaterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalWaterLabel.Location = new System.Drawing.Point(4, 62);
            this.totalWaterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalWaterLabel.Name = "totalWaterLabel";
            this.totalWaterLabel.Size = new System.Drawing.Size(511, 62);
            this.totalWaterLabel.TabIndex = 2;
            this.totalWaterLabel.Text = "Total Water Drank: 0 oz";
            this.totalWaterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sleepTabPage
            // 
            this.sleepTabPage.Controls.Add(this.sleepLayoutPanel);
            this.sleepTabPage.Location = new System.Drawing.Point(124, 4);
            this.sleepTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.sleepTabPage.Name = "sleepTabPage";
            this.sleepTabPage.Size = new System.Drawing.Size(519, 412);
            this.sleepTabPage.TabIndex = 1;
            this.sleepTabPage.Text = "Sleep";
            this.sleepTabPage.UseVisualStyleBackColor = true;
            // 
            // sleepLayoutPanel
            // 
            this.sleepLayoutPanel.ColumnCount = 2;
            this.sleepLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sleepLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sleepLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sleepLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.sleepLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sleepLayoutPanel.Name = "sleepLayoutPanel";
            this.sleepLayoutPanel.RowCount = 10;
            this.sleepLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.83721F));
            this.sleepLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.16279F));
            this.sleepLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.sleepLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.sleepLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.sleepLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.sleepLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.sleepLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.sleepLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.sleepLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.sleepLayoutPanel.Size = new System.Drawing.Size(519, 412);
            this.sleepLayoutPanel.TabIndex = 0;
            // 
            // dressUpTabPage
            // 
            this.dressUpTabPage.Controls.Add(this.dressUpLayoutPanel);
            this.dressUpTabPage.Location = new System.Drawing.Point(124, 4);
            this.dressUpTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.dressUpTabPage.Name = "dressUpTabPage";
            this.dressUpTabPage.Size = new System.Drawing.Size(519, 412);
            this.dressUpTabPage.TabIndex = 1;
            this.dressUpTabPage.Text = "Dress Up";
            this.dressUpTabPage.UseVisualStyleBackColor = true;
            // 
            // dressUpLayoutPanel
            // 
            this.dressUpLayoutPanel.ColumnCount = 2;
            this.dressUpLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dressUpLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dressUpLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dressUpLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.dressUpLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.dressUpLayoutPanel.Name = "dressUpLayoutPanel";
            this.dressUpLayoutPanel.RowCount = 10;
            this.dressUpLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.83721F));
            this.dressUpLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.16279F));
            this.dressUpLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.dressUpLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.dressUpLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.dressUpLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.dressUpLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.dressUpLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.dressUpLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.dressUpLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.dressUpLayoutPanel.Size = new System.Drawing.Size(519, 412);
            this.dressUpLayoutPanel.TabIndex = 0;
            // 
            // CareOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 421);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CareOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Care for your pets";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.tabControl1.ResumeLayout(false);
            this.walkTabPage.ResumeLayout(false);
            this.walkLayoutPanel.ResumeLayout(false);
            this.walkLayoutPanel.PerformLayout();
            this.eatTabPage.ResumeLayout(false);
            this.exerciseTabPage.ResumeLayout(false);
            this.waterTabPage.ResumeLayout(false);
            this.waterLayoutPanel.ResumeLayout(false);
            this.waterLayoutPanel.PerformLayout();
            this.sleepTabPage.ResumeLayout(false);
            this.dressUpTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage walkTabPage;
		private System.Windows.Forms.TableLayoutPanel walkLayoutPanel;
        private System.Windows.Forms.Button walkStartButton;
        private System.Windows.Forms.Label walkStartTime;
        private System.Windows.Forms.Button walkEndButton;
        private System.Windows.Forms.Label walkEndTime;
        private System.Windows.Forms.TabPage eatTabPage;
        private System.Windows.Forms.TableLayoutPanel eatLayoutPanel;
        private System.Windows.Forms.TabPage exerciseTabPage;
        private System.Windows.Forms.TableLayoutPanel exerciseLayoutPanel;
        private System.Windows.Forms.TabPage waterTabPage;
        private System.Windows.Forms.TableLayoutPanel waterLayoutPanel;
        private System.Windows.Forms.TextBox waterValueInput;
        private System.Windows.Forms.Button waterValueButton;
        private System.Windows.Forms.Label totalWaterLabel;
        private System.Windows.Forms.TabPage sleepTabPage;
        private System.Windows.Forms.TableLayoutPanel sleepLayoutPanel;
        private System.Windows.Forms.TabPage dressUpTabPage;
        private System.Windows.Forms.TableLayoutPanel dressUpLayoutPanel;
    }
}
