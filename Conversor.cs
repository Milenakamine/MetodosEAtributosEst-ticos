namespace MetodosEAtributosEst_ticos
{
    public static class Conversor
    {
        //so para problemas especificos *static*

public static  float CotacaoDolar = 5.23f;

public static float RealParaDolar(float valor){
    return valor*CotacaoDolar;
}
public static float DolarParaReal(float valor){
    return valor/CotacaoDolar;
}

public static float CotacaoEuro= 5.90f ;

public static float RealParaEuro(float valor){
    return valor*CotacaoDolar;
}
public static float EuroParaReal(float valor){
    return valor/CotacaoDolar;
}



    }
}