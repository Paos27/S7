using S7.Models;

namespace S7.Vista;

public partial class vPersona 

{
	public vPersona()
	{
		InitializeComponent();
	}

    private void btnAgregar_Clicked(object sender, EventArgs e)
    {
        lblStatus.Text = "";
        App.personRepo.AddNewPerson(txtNombre.Text);
        lblStatus.Text=App.personRepo.StatusMessage;


    }

    private void btnObtener_Clicked(object sender, EventArgs e)
    {
        lblStatus.Text = "";
        List<Persona> personas=App.personRepo.getAllPeople();
        listaPersona.ItemsSource = personas;
        lblStatus.Text = App.personRepo.StatusMessage;
    }

    private void btnActualizar_Clicked(object sender, EventArgs e)
    {

    }

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {
        lblStatus.Text = "";
        if (!string.IsNullOrEmpty(txtId.Text))
        {
            App.personRepo.EliminarPerson(int.Parse(txtId.Text));
            lblStatus.Text = App.personRepo.StatusMessage;
        }
        else
        {
            DisplayAlert("Error", "Por favor ingrese un ID", "Cerrar");
        }
    }
}