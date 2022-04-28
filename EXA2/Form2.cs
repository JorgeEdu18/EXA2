using System.Security.Cryptography.Pkcs;
using System.Windows.Forms;

namespace EXA2;

public partial class Form2 : Form
{
     CheckBox? chUSD;
     CheckBox? chMX;
     CheckBox?chJPY;
     CheckBox?chEUR;
     CheckBox?chCAD;
     double totalMx, totalUSD, totalJPY, totalEUR, totalCAD;
     Button? btnCancelar, btnAceptar;
     double monto = 0;
     double moneda = 0;
     FlowLayoutPanel? panel;
     string Moneda;
    
    public Form2(double monto, int moneda)
    {
        InitializeComponent();
        Inicializar();
        ObtenerDatos(monto,moneda);

    }

    public void Inicializar()
    {
        this.Size = new Size(300, 350);

        //boton Mexico
        chMX = new CheckBox();
        chMX.Text = "MEX-Peso Mexicano";
        chMX.AutoSize = true;
        chMX.Location = new Point(20, 20);
        chMX.Visible = true;

        //Boton USD
        chUSD = new CheckBox();
        chUSD.Text = "USD-Dólar Estadunidense";
        chUSD.AutoSize = true;
        chUSD.Visible = true;
        chUSD.Location = new Point(20, 50);
        
        //Bton Canaiense
        chCAD = new CheckBox();
        chCAD.Text = "CAD-Dólar canadiense";
        chCAD.AutoSize = true;
        chCAD.Location = new Point(20, 75);
        chCAD.Visible = true;

        //Boton Euro
        chEUR = new CheckBox();
        chEUR.Text = "EUR-Euro";
        chEUR.AutoSize = true;
        chEUR.Location = new Point(20, 95);
        chEUR.Visible = true;
        
        //Boton JPY
        chJPY = new CheckBox();
        chJPY.Text = "JPY-Yen Japones";
        chJPY.AutoSize = true;
        chJPY.Location = new Point(20, 120);
        chJPY.Visible = true;
        
        //Boton cancelar
        btnCancelar = new Button();
        btnCancelar.Text = "Cancelar";
        btnCancelar.AutoSize = true;
        btnCancelar.Location = new Point(20, 170);
        btnCancelar.Click += new EventHandler(cerrarVentana);
        
        //Boton Aceptar
        
        btnAceptar = new Button();
        btnAceptar.Text = "Aceptar";
        btnAceptar.AutoSize = true;
        btnAceptar.Location = new Point(180, 170);
        btnAceptar.Click += new EventHandler(btnCalcular_click);
        
        this.Controls.Add(btnCancelar);
        this.Controls.Add(btnAceptar);
        this.Controls.Add(chMX);
        this.Controls.Add(chUSD);
        this.Controls.Add(chEUR);
        this.Controls.Add(chCAD);
        this.Controls.Add(chJPY);
        this.Controls.Add(panel);
        
    }

    private void btnCalcular_click(object sender, EventArgs e)
    {
        
        if (moneda == 1)
        {
            totalUSD = 0;
            if (chMX.Checked == true)
            {
                totalMx = monto * 21.23;
            }
            else
            {
                totalMx = 0;}

            if (chCAD.Checked == true)
            {
                totalCAD = monto * 1.28;
            }
            else
            {
                totalCAD = 0;}

            if (chEUR.Checked == true)
            {
                totalEUR = monto * 0.89;
            }
            else
            {
                totalEUR = 0;}

            if (chJPY.Checked == true)
            {
                totalJPY = monto * 113.05;
            }
            else
            {
                totalJPY = 0;
            }
        }
        if (moneda == 2)
        {
            totalMx = 0;
            if (chUSD.Checked == true)
            {
                totalUSD = monto * 0.05;
            }
            else
            {
                totalUSD = 0;
            }

            if (chCAD.Checked == true)
            {
                totalCAD = monto * 0.05;
            }
            else
            {
                totalCAD = 0;}

            if (chEUR.Checked == true)
            {
                totalEUR = monto * 0.04;
            }
            else
            {
                totalEUR = 0;}

            if (chJPY.Checked == true)
            {
                totalJPY = monto * 5.32;
            }
            else
            {
                totalJPY = 0;
            }
        }
        if (moneda == 3)
        {
            totalCAD = 0;
            if (chMX.Checked == true)
            {
                totalMx = monto * 16.55;
            }
            else
            { totalMx = 0;}

            if (chUSD.Checked == true)
            {
                totalUSD = monto * 0.78;
            }
            else
            {
                totalUSD = 0;}

            if (chEUR.Checked == true)
            {
                totalEUR = monto * 0.69;
            }
            else
            {
                totalEUR = 0;}

            if (chJPY.Checked == true)
            {
                totalJPY = monto * 88.12;
            }
            else
            {
                totalJPY = 0;
            }
        }if (moneda == 4)
        {
            totalEUR = 0;
            if (chMX.Checked == true)
            {
                totalMx = monto * 23.96;
            }
            else
            {
                totalMx = 0;}

            if (chCAD.Checked == true)
            {
                totalCAD = monto * 1.45;
            }
            else
            {
                totalCAD = 0;}

            if (chUSD.Checked == true)
            {
                totalUSD = monto * 1.45;
            }
            else
            {
                totalUSD = 0;}

            if (chJPY.Checked == true)
            {
                totalJPY = monto * 127.56;
            }
            else
            {
                totalJPY = 0;
            }
        }
        if (moneda == 5)
        {
            totalJPY = 0;
            if (chMX.Checked == true)
            {
                totalMx = monto * 0.1878;
            }
            else
            {
                totalMx = 0;}

            if (chCAD.Checked == true)
            {
                totalCAD = monto * 0.0113;
            }
            else
            {
                totalCAD = 0;}

            if (chEUR.Checked == true)
            {
                totalEUR = monto * 0.0113;
            }
            else
            {
                totalEUR = 0;}

            if (chUSD.Checked == true)
            {
                totalUSD = monto * 0.0078;
            }
            else
            {
                totalUSD = 0;
            }
        }

        Form1 ventana1 = Owner as Form1;
        if (totalMx == 0.0)
        {
            ventana1.lblMx.Visible = false;
            ventana1.cajaMX.Visible = false;
            
        }

        if (totalMx > 0)
        {
            ventana1.lblMx.Visible = true;
            ventana1.cajaMX.Visible = true;
            ventana1.cajaMX.Text = "$ " + totalMx;
            
        }
        if (totalUSD == 0.0)
        {
            ventana1.lblUSD.Visible = false;
            ventana1.cajaUSD.Visible = false;
        }

        if (totalUSD > 0.0)
        {
            ventana1.lblUSD.Visible = true;
            ventana1.cajaUSD.Visible = true;
            ventana1.cajaUSD.Text = "$ " + totalUSD;
            
        }
        if (totalEUR == 0.0)
        {
            ventana1.lblEur.Visible = false;
            ventana1.cajaEUR.Visible = false;
        }

        if (totalEUR > 0.0)
        {
            ventana1.lblEur.Visible = true;
            ventana1.cajaEUR.Visible = true;
            ventana1.cajaEUR.Text = "€ " + totalEUR;
            
        }
        if (totalJPY == 0.0)
        {
            ventana1.lblJPY.Visible = false;
            ventana1.cajaJPY.Visible = false;
        }

        if (totalJPY > 0.0)
        {
            ventana1.lblJPY.Visible = true;
            ventana1.cajaJPY.Visible = true;
            ventana1.cajaJPY.Text = "¥ " + totalJPY;
            
        }
        if (totalCAD == 0.0)
        {
            ventana1.lblcad.Visible = false;
            ventana1.cajaCAD.Visible = false;
        }

        if (totalCAD > 0.0)
        {
            ventana1.lblcad.Visible = true;
            ventana1.cajaCAD.Visible = true;
            ventana1.cajaCAD.Text = "$ " + totalCAD;
        }
    }

    private void ObtenerDatos(double Monto, int Moneda)
    {
        monto = Monto;
        moneda = Moneda;
        
        if (moneda == 1)
        {
            chUSD.Visible = false;
        }

        if (moneda == 2)
        {
            chMX.Visible = false;
        }

        if (moneda == 3)
        {
            chCAD.Visible = false;
        }

        if (moneda == 4)
        {
            chEUR.Visible = false;
        }

        if (moneda == 5)
        {
            chJPY.Visible = false;
        }
    }

    private void cerrarVentana(object sender, EventArgs e)
    {
        Close();
    }
}