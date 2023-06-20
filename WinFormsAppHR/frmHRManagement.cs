using WinFormsAppHR.Repository;
namespace WinFormsAppHR
{
    public partial class frmHRManagement : Form
    {
        private IEmpRepository empRepository;

        public frmHRManagement()
        {
            empRepository = new EmpRepsitory();

           var data= empRepository.GetEmployees();

            InitializeComponent();
        }

        private void frmHRManagement_Load(object sender, EventArgs e)
        {

        }


    }
}