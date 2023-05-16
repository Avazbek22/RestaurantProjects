namespace Restaraunt_1.Core
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Menu = new System.Windows.Forms.GroupBox();
            this.radBtn_Egg = new System.Windows.Forms.RadioButton();
            this.radBtn_Chicken = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_GetQuantity = new System.Windows.Forms.TextBox();
            this.btnNewReq = new System.Windows.Forms.Button();
            this.btnCopyReq = new System.Windows.Forms.Button();
            this.labelEggQuality = new System.Windows.Forms.Label();
            this.labelEggQualValue = new System.Windows.Forms.Label();
            this.btnPrepareFood = new System.Windows.Forms.Button();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.labelResults = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.radBtn_Egg);
            this.Menu.Controls.Add(this.radBtn_Chicken);
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Menu.Location = new System.Drawing.Point(17, 25);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(197, 64);
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.Text = "Menu";
            // 
            // radBtn_Egg
            // 
            this.radBtn_Egg.AutoSize = true;
            this.radBtn_Egg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBtn_Egg.Location = new System.Drawing.Point(127, 30);
            this.radBtn_Egg.Name = "radBtn_Egg";
            this.radBtn_Egg.Size = new System.Drawing.Size(59, 24);
            this.radBtn_Egg.TabIndex = 1;
            this.radBtn_Egg.TabStop = true;
            this.radBtn_Egg.Text = "Egg";
            this.radBtn_Egg.UseVisualStyleBackColor = true;
            // 
            // radBtn_Chicken
            // 
            this.radBtn_Chicken.AutoSize = true;
            this.radBtn_Chicken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBtn_Chicken.Location = new System.Drawing.Point(15, 30);
            this.radBtn_Chicken.Name = "radBtn_Chicken";
            this.radBtn_Chicken.Size = new System.Drawing.Size(90, 24);
            this.radBtn_Chicken.TabIndex = 0;
            this.radBtn_Chicken.TabStop = true;
            this.radBtn_Chicken.Text = "Chicken";
            this.radBtn_Chicken.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // TxtBox_GetQuantity
            // 
            this.TxtBox_GetQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBox_GetQuantity.Location = new System.Drawing.Point(97, 138);
            this.TxtBox_GetQuantity.Name = "TxtBox_GetQuantity";
            this.TxtBox_GetQuantity.Size = new System.Drawing.Size(117, 22);
            this.TxtBox_GetQuantity.TabIndex = 2;
            // 
            // btnNewReq
            // 
            this.btnNewReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewReq.Location = new System.Drawing.Point(231, 135);
            this.btnNewReq.Name = "btnNewReq";
            this.btnNewReq.Size = new System.Drawing.Size(180, 29);
            this.btnNewReq.TabIndex = 3;
            this.btnNewReq.Text = "Submit new request";
            this.btnNewReq.UseVisualStyleBackColor = true;
            this.btnNewReq.Click += new System.EventHandler(this.btnNewReq_Click);
            // 
            // btnCopyReq
            // 
            this.btnCopyReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopyReq.Location = new System.Drawing.Point(17, 188);
            this.btnCopyReq.Name = "btnCopyReq";
            this.btnCopyReq.Size = new System.Drawing.Size(394, 34);
            this.btnCopyReq.TabIndex = 4;
            this.btnCopyReq.Text = "Copy the previous request";
            this.btnCopyReq.UseVisualStyleBackColor = true;
            this.btnCopyReq.Click += new System.EventHandler(this.btnCopyReq_Click);
            // 
            // labelEggQuality
            // 
            this.labelEggQuality.AutoSize = true;
            this.labelEggQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEggQuality.Location = new System.Drawing.Point(17, 258);
            this.labelEggQuality.Name = "labelEggQuality";
            this.labelEggQuality.Size = new System.Drawing.Size(91, 20);
            this.labelEggQuality.TabIndex = 5;
            this.labelEggQuality.Text = "Egg quality";
            // 
            // labelEggQualValue
            // 
            this.labelEggQualValue.AutoSize = true;
            this.labelEggQualValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEggQualValue.Location = new System.Drawing.Point(114, 258);
            this.labelEggQualValue.Name = "labelEggQualValue";
            this.labelEggQualValue.Size = new System.Drawing.Size(0, 20);
            this.labelEggQualValue.TabIndex = 6;
            // 
            // btnPrepareFood
            // 
            this.btnPrepareFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrepareFood.Location = new System.Drawing.Point(17, 296);
            this.btnPrepareFood.Name = "btnPrepareFood";
            this.btnPrepareFood.Size = new System.Drawing.Size(394, 30);
            this.btnPrepareFood.TabIndex = 7;
            this.btnPrepareFood.Text = "Prepare food";
            this.btnPrepareFood.UseVisualStyleBackColor = true;
            this.btnPrepareFood.Click += new System.EventHandler(this.btnPrepareFood_Click);
            // 
            // listBoxResults
            // 
            this.listBoxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 20;
            this.listBoxResults.Location = new System.Drawing.Point(17, 377);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(394, 164);
            this.listBoxResults.TabIndex = 8;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResults.Location = new System.Drawing.Point(17, 354);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(75, 22);
            this.labelResults.TabIndex = 9;
            this.labelResults.Text = "Results:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 566);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.btnPrepareFood);
            this.Controls.Add(this.labelEggQualValue);
            this.Controls.Add(this.labelEggQuality);
            this.Controls.Add(this.btnCopyReq);
            this.Controls.Add(this.btnNewReq);
            this.Controls.Add(this.TxtBox_GetQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Restaraunt by Avazbek";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox Menu;
        private RadioButton radBtn_Egg;
        private RadioButton radBtn_Chicken;
        private Label label1;
        private TextBox TxtBox_GetQuantity;
        private Button btnNewReq;
        private Button btnCopyReq;
        private Label labelEggQuality;
        private Label labelEggQualValue;
        private Button btnPrepareFood;
        private ListBox listBoxResults;
        private Label labelResults;
    }
}