Question 2:Browse Button
code:

    private void btnBrowse_Click(object sender, EventArgs e)
{
    OpenFileDialog ofd = new OpenFileDialog();
    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

    if (ofd.ShowDialog() == DialogResult.OK)
    {
        pictureBox1.Image = Image.FromFile(ofd.FileName);
    }
}

Question 3: Insert Data into ComboBox
code:

    private void Form1_Load(object sender, EventArgs e)
{
    cboPrograms.Items.Add("BS Computer Engineering");
    cboPrograms.Items.Add("BS Civil Engineering");
    cboPrograms.Items.Add("BS Electrical Engineering");
    cboPrograms.Items.Add("BS Electronics Engineering");
    cboPrograms.Items.Add("BS Mechanical Engineering");
}

Question 4: Clear All TextBoxes
code:

    private void btnNewCancel_Click(object sender, EventArgs e)
{
    txtStudentName.Text = "";
    txtStudentNumber.Text = "";
    txtYearLevel.Text = "";
    txtScholar.Text = "";
    txtCourseNumber.Text = "";
    txtCourseCode.Text = "";
    txtCourseDesc.Text = "";
    txtUnitLecture.Text = "";
    txtUnitLaboratory.Text = "";
    txtTime.Text = "";
    txtDay.Text = "";
    cboPrograms.SelectedIndex = -1; //adds tet boxex if needed
    pictureBox1.Image = null;
}

Question 5: Transfer TextBox Data to ListBoxes/TextBoxes
code:

    private void btnSubmit_Click(object sender, EventArgs e)
{
    lstCourses.Items.Add(txtCourseNumber.Text); //adds course info

    txtTotalTuitionFee.Text = txtCourseTuitionFee.Text;  //transfers total to sum boxess
    txtTotalMiscFee.Text = txtCourseMiscFee.Text;
    txtTotalUnits.Text = txtCreditUnits.Text;
    txtTotalTuitionAndFees.Text = txtCourseTotalTuitionAndFee.Text;
}