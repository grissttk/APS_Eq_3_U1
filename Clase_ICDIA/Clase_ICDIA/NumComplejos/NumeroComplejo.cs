namespace Clase_ICDIA.NumComplejos;

public class NumeroComplejo
{
    private double parteReal;
    private double parteImaginaria;
    
    // Se va a  ocupar dos constructores,uno con parametros esenciales y uno vacio

    public NumeroComplejo(double parteReal, double parteImaginaria)
    {
        this.parteReal = parteReal;
        this.parteImaginaria = parteImaginaria;
    }

    public NumeroComplejo()
    {
        // Constructor vacio
        // El constructor debe de llamarse igual que el nombre de la clase
    }

    public double ParteReal
    {
        get => parteReal;
        set => parteReal = value;
    }

    public double ParteImaginaria
    {
        get => parteImaginaria;
        set => parteImaginaria = value;
    }

    public NumeroComplejo Suma(NumeroComplejo otro)
    {
        // Marca error si no tiene return
        
        double rReal = this.parteReal + otro.parteReal;
        double rImaginaria = this.parteImaginaria + otro.parteImaginaria;
        
        NumeroComplejo temporal = new NumeroComplejo(rReal, rImaginaria);
        return temporal;
    }
    
    public NumeroComplejo Resta(NumeroComplejo otro)
    {
        double rReal = this.parteReal - otro.parteReal;
        double rImaginaria = this.parteImaginaria - otro.parteImaginaria;
        
        NumeroComplejo temporal = new NumeroComplejo(rReal, rImaginaria);
        return temporal;
    }
    
    public NumeroComplejo Multiplicacion(NumeroComplejo otro)
    {
        double rReal = this.parteReal * otro.parteReal;
        double rImaginaria = this.parteImaginaria * otro.parteImaginaria;
        
        NumeroComplejo temporal = new NumeroComplejo(rReal, rImaginaria);
        return temporal;
    }
    
    public NumeroComplejo Division(NumeroComplejo otro)
    {
        double rReal = this.parteReal / otro.parteReal;
        double rImaginaria = this.parteImaginaria / otro.parteImaginaria;
        
        NumeroComplejo temporal = new NumeroComplejo(rReal, rImaginaria);
        return temporal;
    }
    
    public override string ToString()
    {
        if (parteImaginaria >= 0)
        {
            return ParteReal + " + " + ParteImaginaria + "i";
        }
        else
        {
            ParteImaginaria = ParteImaginaria * -1;
            return ParteReal + " + " + ParteImaginaria + "i";
        }
    }
}