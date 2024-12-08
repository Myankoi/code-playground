using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Login___Register_Form
{
    public partial class Kasir : Form
    {
        Login frm1;
        List<Member> members;
        Utils utils = new Utils();
        string todayDay;
        public Kasir(Login form1, Identity identity)
        {
            InitializeComponent();
            this.frm1 = form1;
            this.members = form1.user.memberList;

            lblIdentity.Text = identity.getIdentity();
            lblInfo.Visible = false;
            gbMemberInfo.Visible = false;
            gbId.Visible = false;

            DateTime localDate = DateTime.Now;
            todayDay = localDate.ToString("dddd");

            lblDatetime.Text = localDate.ToString("dddd, MMMM, yyyy");
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Logout?", "Mau Logout?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frm1.Show();
            }
            else
            {
                return;
            }
        }
        private void generateID()
        {
            DateTime localDate = DateTime.Now;
            string ID = localDate.ToString("ddd").ToUpper() +
                localDate.ToString("dd") +
                localDate.ToString("MM") +
                localDate.ToString("yy") +
                localDate.ToString("HH") +
                localDate.ToString("mm") +
                localDate.ToString("ss");
            lblMemberId.Text = ID;
        }

        private void cbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMember.SelectedIndex == 0)
            {
                gbMemberInfo.Visible = true;
                gbId.Visible = false;
            } else
            {
                gbMemberInfo.Visible = false;
                gbId.Visible = true;
                generateID();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (gbMemberInfo.Visible)
            {
                gbMemberInfo.Visible = false;
            } else
            {
                gbMemberInfo.Visible = true;
                generateID();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (utils.IsEmpty(tbNama, "Name") || utils.IsEmpty(tbAlamat, "Address") || utils.IsEmpty(tbNoHp, "Number Phone"))
            {
                return;
            }
            members.Add(new Member(lblMemberId.Text, tbNama.Text, tbAlamat.Text, tbNoHp.Text));
            MessageBox.Show($"Data Successfully Added!\nID: {lblMemberId.Text} ", "Succsess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gbMemberInfo.Visible = false;
            utils.ClearAllTextBoxes(gbMemberInfo);
        }

        private void btnCheckID_Click(object sender, EventArgs e)
        {
            if (utils.IsEmpty(tbMemberId, "MemberID")) {
                return;
            }
            var isMember = members.Find(x => x.Id == tbMemberId.Text);
            if (isMember != null)
            {
                MessageBox.Show($"Your MemberID is Valid!\nID: {tbMemberId.Text}", "Succsess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show($"Your MemberID is Invalid!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
