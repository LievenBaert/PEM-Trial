using System.Reflection;
using System.Windows.Forms;

/// mijn test 16 -- ++++ in dev

//include abstract compiler error

namespace ADF.UCM.Demo.HIC
{
  public partial class FormTest : Form
  {
    public FormTest()
        {
            InitializeComponent();
            //test
            Assembly assembly = Assembly.GetExecutingAssembly();
            var attributes1 = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
            if (attributes1.Length > 0)
            {
              var descriptionAttribute = (AssemblyDescriptionAttribute)attributes1[0];
              this.textBoxDescription.Text = descriptionAttribute.Description;
            }
            var attributes2 = assembly.GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false);
            if (attributes2.Length > 0)
            {
              var assFileAttribute = (AssemblyFileVersionAttribute)attributes2[0];
              this.textBoxVersion.Text = assFileAttribute.Version;
            }
    }

    private void ButtonSayHello_Click(System.Object sender, System.EventArgs e)
    {
      ADF.UCM.Demo.WebServices.Proxy.DemoServices t = new ADF.UCM.Demo.WebServices.Proxy.DemoServices();
      MessageBox.Show(t.HelloWorld());
    }

    private void ButtonSendMessage_Click(System.Object sender, System.EventArgs e)
    {
      ADF.UCM.Demo.WebServices.Proxy.DemoServices t = new ADF.UCM.Demo.WebServices.Proxy.DemoServices();
      t.SendMessage();
      MessageBox.Show("Message was send.");
    }

  }
}
