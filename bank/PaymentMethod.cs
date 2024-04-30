using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace bank
{
    internal class PaymentMethod
    {
        List<PaymentMethod> paymentMethods = new List<PaymentMethod>();

        public string Name { get; set; }
        public string AccountId { get; set; }
        public PictureBox Logo { get; set; }
        public BunifuLabel NameLabel { get; set; }
        public BunifuRadioButton RadioButton { get; set; }
        public Panel LinePanel { get; set; }
        public bool IsVisible { get; set; }

        public void AddOrUpdatePaymentMethod(string name, string accountId, bool isVisible)
        {
            var existingMethod = paymentMethods.FirstOrDefault(pm => pm.Name == name);
            if (existingMethod != null)
            {
                existingMethod.AccountId = accountId;
                existingMethod.IsVisible = isVisible;
            }
            else
            {
                paymentMethods.Add(new PaymentMethod
                {
                    Name = name,
                    AccountId = accountId,
                    IsVisible = isVisible
                });
            }
        }
    }

}
