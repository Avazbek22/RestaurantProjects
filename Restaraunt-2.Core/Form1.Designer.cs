namespace Restaraunt_2.Core
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
            groupBoxMenu = new GroupBox();
            comboBoxDrinks = new ComboBox();
            txtboxAmountEgg = new TextBox();
            txtboxAmountChicken = new TextBox();
            ReceiveRequest = new Button();
            labelHowManyEggs = new Label();
            labelHowManyChickens = new Label();
            labelEggQuality = new Label();
            labelResults = new Label();
            SendToCook = new Button();
            ServeFood = new Button();
            listBoxResults = new ListBox();
            labelEggQualValue = new Label();
            groupBoxMenu.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMenu
            // 
            groupBoxMenu.Controls.Add(comboBoxDrinks);
            groupBoxMenu.Controls.Add(txtboxAmountEgg);
            groupBoxMenu.Controls.Add(txtboxAmountChicken);
            groupBoxMenu.Controls.Add(ReceiveRequest);
            groupBoxMenu.Controls.Add(labelHowManyEggs);
            groupBoxMenu.Controls.Add(labelHowManyChickens);
            groupBoxMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxMenu.Location = new Point(12, 12);
            groupBoxMenu.Name = "groupBoxMenu";
            groupBoxMenu.Size = new Size(466, 169);
            groupBoxMenu.TabIndex = 0;
            groupBoxMenu.TabStop = false;
            groupBoxMenu.Text = "Menu";
            // 
            // comboBoxDrinks
            // 
            comboBoxDrinks.FormattingEnabled = true;
            comboBoxDrinks.Items.AddRange(new object[] { "NoDrink", "CocaCola", "Pepsi", "Sprite", "Tea", "Cofe", "Water" });
            comboBoxDrinks.Location = new Point(302, 29);
            comboBoxDrinks.Name = "comboBoxDrinks";
            comboBoxDrinks.Size = new Size(158, 33);
            comboBoxDrinks.TabIndex = 5;
            // 
            // txtboxAmountEgg
            // 
            txtboxAmountEgg.Location = new Point(174, 76);
            txtboxAmountEgg.Name = "txtboxAmountEgg";
            txtboxAmountEgg.Size = new Size(112, 31);
            txtboxAmountEgg.TabIndex = 4;
            // 
            // txtboxAmountChicken
            // 
            txtboxAmountChicken.Location = new Point(174, 31);
            txtboxAmountChicken.Name = "txtboxAmountChicken";
            txtboxAmountChicken.Size = new Size(112, 31);
            txtboxAmountChicken.TabIndex = 3;
            // 
            // ReceiveRequest
            // 
            ReceiveRequest.Location = new Point(31, 113);
            ReceiveRequest.Name = "ReceiveRequest";
            ReceiveRequest.Size = new Size(429, 42);
            ReceiveRequest.TabIndex = 2;
            ReceiveRequest.Text = "Receive this request from a customer";
            ReceiveRequest.UseVisualStyleBackColor = true;
            ReceiveRequest.Click += ReceiveRequest_Click;
            // 
            // labelHowManyEggs
            // 
            labelHowManyEggs.AutoSize = true;
            labelHowManyEggs.Location = new Point(10, 79);
            labelHowManyEggs.Name = "labelHowManyEggs";
            labelHowManyEggs.Size = new Size(142, 25);
            labelHowManyEggs.TabIndex = 1;
            labelHowManyEggs.Text = "How many egg?";
            // 
            // labelHowManyChickens
            // 
            labelHowManyChickens.AutoSize = true;
            labelHowManyChickens.Location = new Point(9, 34);
            labelHowManyChickens.Name = "labelHowManyChickens";
            labelHowManyChickens.Size = new Size(169, 25);
            labelHowManyChickens.TabIndex = 0;
            labelHowManyChickens.Text = "How many chicken?";
            // 
            // labelEggQuality
            // 
            labelEggQuality.AutoSize = true;
            labelEggQuality.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelEggQuality.Location = new Point(21, 250);
            labelEggQuality.Name = "labelEggQuality";
            labelEggQuality.Size = new Size(110, 25);
            labelEggQuality.TabIndex = 2;
            labelEggQuality.Text = "Egg quality: ";
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelResults.Location = new Point(12, 342);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(71, 25);
            labelResults.TabIndex = 3;
            labelResults.Text = "Results:";
            // 
            // SendToCook
            // 
            SendToCook.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            SendToCook.Location = new Point(43, 199);
            SendToCook.Name = "SendToCook";
            SendToCook.Size = new Size(429, 38);
            SendToCook.TabIndex = 3;
            SendToCook.Text = "Send all customer requests to the cook";
            SendToCook.UseVisualStyleBackColor = true;
            SendToCook.Click += SendToCook_Click;
            // 
            // ServeFood
            // 
            ServeFood.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ServeFood.Location = new Point(43, 288);
            ServeFood.Name = "ServeFood";
            ServeFood.Size = new Size(429, 38);
            ServeFood.TabIndex = 4;
            ServeFood.Text = "Serve prepared food to the customers";
            ServeFood.UseVisualStyleBackColor = true;
            ServeFood.Click += ServeFood_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 25;
            listBoxResults.Location = new Point(12, 370);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(466, 229);
            listBoxResults.TabIndex = 5;
            // 
            // labelEggQualValue
            // 
            labelEggQualValue.AutoSize = true;
            labelEggQualValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelEggQualValue.Location = new Point(147, 250);
            labelEggQualValue.Name = "labelEggQualValue";
            labelEggQualValue.Size = new Size(0, 25);
            labelEggQualValue.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 603);
            Controls.Add(labelEggQualValue);
            Controls.Add(listBoxResults);
            Controls.Add(ServeFood);
            Controls.Add(SendToCook);
            Controls.Add(labelResults);
            Controls.Add(labelEggQuality);
            Controls.Add(groupBoxMenu);
            Name = "Form1";
            Text = "Restaraunt 2 by Avazbek";
            groupBoxMenu.ResumeLayout(false);
            groupBoxMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxMenu;
        private ComboBox comboBoxDrinks;
        private TextBox txtboxAmountEgg;
        private TextBox txtboxAmountChicken;
        private Button ReceiveRequest;
        private Label labelHowManyEggs;
        private Label labelHowManyChickens;
        private Label labelEggQuality;
        private Label labelResults;
        private Button SendToCook;
        private Button ServeFood;
        private ListBox listBoxResults;
        private Label labelEggQualValue;
    }
}