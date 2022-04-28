namespace EXA2;

public partial class Form1 : Form
{
     public CheckBox USD,MX,YN,EUR,CAD;
     public Label lblMoneda;
     public Label lblMonto;
     public Label lblMx;
     public Label lblUSD, lblcad, lblEur, lblJPY;
     public Button btnCalcular;
     public ComboBox ListaMonedas;
     public GroupBox boxGrupoConversion;
     public TextBox cajaMonto, cajaMX,cajaUSD,cajaEUR,cajaCAD,cajaJPY;
    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
        
    }

    private void InicializarComponentes()
    {
        this.Size = new Size(320, 350);
        //Etiquta Moneda
        lblMoneda = new Label();
        lblMoneda.Text = "Moneda";
        lblMoneda.AutoSize = true;
        lblMoneda.Location = new Point(10, 10);
        
        //Etiquta Monto
        lblMonto = new Label();
        lblMonto.Text = "Monto";
        lblMonto.AutoSize = true;
        lblMonto.Location = new Point(200, 10);
        
        //Etiquta MXN-PESO
        lblMx = new Label();
        lblMx.Text = "MXN-Peso";
        lblMx.AutoSize = true;
        lblMx.Location = new Point(10, 25);
        lblMx.Visible = false;
        
        //cajamx
        cajaMX = new TextBox();
        cajaMX.Text = "";
        cajaMX.AutoSize = true;
        cajaMX.Location = new Point(150,25);
        cajaMX.Visible = false;
        
        //Etiquta USD-Dolar
        lblUSD = new Label();
        lblUSD.Text = "USD-Dólar";
        lblUSD.AutoSize = true;
        lblUSD.Location = new Point(10, 60);
        lblUSD.Visible = false;
        
        //cajamx
        cajaUSD = new TextBox();
        cajaUSD.Text = "";
        cajaUSD.AutoSize = true;
        cajaUSD.Location = new Point(150,60);
        cajaUSD.Visible = false;

        //Etiquta CAD-Dolar
        lblcad = new Label();
        lblcad.Text = "CAD-Dólar";
        lblcad.AutoSize = true;
        lblcad.Location = new Point(10, 90);
        lblcad.Visible = false;
        
        //cajamx
        cajaCAD = new TextBox();
        cajaCAD.Text = "";
        cajaCAD.AutoSize = true;
        cajaCAD.Location = new Point(150,90);
        cajaCAD.Visible = false;
        
        //Etiquta EUR-Euro
        lblEur = new Label();
        lblEur.Text = "EUR-Euro";
        lblEur.AutoSize = true;
        lblEur.Location = new Point(10, 120);
        lblEur.Visible = false;
        
        //cajamx
        cajaEUR = new TextBox();
        cajaEUR.Text = "";
        cajaEUR.AutoSize = true;
        cajaEUR.Location = new Point(150,120);
        cajaEUR.Visible = false;
        
        //Etiquta JPY-Yen
        lblJPY = new Label();
        lblJPY.Text = "JPY-Yen japonés";
        lblJPY.AutoSize = true;
        lblJPY.Location = new Point(10, 150);
        lblJPY.Visible = false;
        
        //cajamx
        cajaJPY = new TextBox();
        cajaJPY.Text = "";
        cajaJPY.AutoSize = true;
        cajaJPY.Location = new Point(150,150);
        cajaJPY.Visible = false;
        
        //Lista de monedas
        ListaMonedas = new ComboBox();
        ListaMonedas.Items.AddRange(new object[]{"USD-Dólar estadunidense","MXN-Peso mexicano","CAD-Dolar canadiense","EUR-Euro","JPY-Yen japonés"});
        ListaMonedas.AutoSize = true;
        ListaMonedas.Location = new Point(15, 40);
        
        //Monto
        cajaMonto = new TextBox();
        cajaMonto.AutoSize = true;
        cajaMonto.Location = new Point(200, 40);
        
        //Boton de calcular
        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location = new Point(200, 80);
        btnCalcular.Click += new EventHandler(btnCalcular_click);
        
        //GroupBox de converciones
        boxGrupoConversion = new GroupBox();
        boxGrupoConversion.Text = "Conversiones";
        boxGrupoConversion.AutoSize = true;
        boxGrupoConversion.Location = new Point(10, 120);
        
        

        this.Controls.Add(btnCalcular);
        this.Controls.Add(cajaMonto);
        this.Controls.Add(ListaMonedas);
        this.Controls.Add(lblMoneda);
        this.Controls.Add(lblMonto);
        boxGrupoConversion.Controls.Add(lblMx);
        boxGrupoConversion.Controls.Add(cajaMX);
        boxGrupoConversion.Controls.Add(cajaUSD);
        boxGrupoConversion.Controls.Add(cajaEUR);
        boxGrupoConversion.Controls.Add(cajaJPY);
        boxGrupoConversion.Controls.Add(cajaCAD);
        boxGrupoConversion.Controls.Add(lblUSD);
        boxGrupoConversion.Controls.Add(lblcad);
        boxGrupoConversion.Controls.Add(lblEur);
        boxGrupoConversion.Controls.Add(lblJPY);
        
        this.Controls.Add(lblMonto);
        this.Controls.Add(lblMoneda);
        this.Controls.Add(lblMonto);
        this.Controls.Add(boxGrupoConversion);
    }

    private void btnCalcular_click(object sender, EventArgs e)
    {
        int moneda = 0;
        double monto =0;
        if (ListaMonedas.SelectedItem.ToString() == "USD-Dólar estadunidense")
        {
            moneda = 1;
        }
        if (ListaMonedas.SelectedItem.ToString() == "MXN-Peso mexicano")
        {
            moneda = 2;
        }
        if (ListaMonedas.SelectedItem.ToString() == "CAD-Dolar canadiense")
        {
            moneda = 3;
        }
        if (ListaMonedas.SelectedItem.ToString() == "EUR-Euro")
        {
            moneda = 4;
        }
        if (ListaMonedas.SelectedItem.ToString() == "JPY-Yen japonés")
        {
            moneda = 5;
        }

        if (cajaMonto.Text != "")
        {
            monto =  Convert.ToDouble(cajaMonto.Text);
        }
        
        Form2 form = new Form2(monto,moneda); 
        AddOwnedForm(form);
        form.Show();
    }
    
}