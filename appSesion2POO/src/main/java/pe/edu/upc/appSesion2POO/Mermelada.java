package pe.edu.upc.appSesion2POO;

/*No se puede realizar herencia multiple en JAVA, como en C*/
public class Mermelada extends Fruta{
	private int duracionDias;
	private String tipoEnvase;
	
	public string prepararMermelada(){
		return ("Preparando meremelada con alegria: " + this.getNombre());
	}

	public Mermelada(String nombre, String color, String sabor, int duracionDias, String tipoEnvase) {
		super(nombre, color, sabor);
		this.duracionDias = duracionDias;
		this.tipoEnvase = tipoEnvase;
	}

	
	
	/*heredar el constructor...*/
	
}
