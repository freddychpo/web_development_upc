package pe.edu.upc.appSesion2POO;

public class Fruta {

	private String nombre;
	private String color;			
	private String sabor;
	private boolean puedoHacerFruta; 

	
	/*SOBRECARGA DE METODOS*/
	/*No hay SI, donde los objetos no tengan comunicacion*/
	public Fruta(){
		/**/
		this.nombre = "Indefinido";
		this.color = "S/C";
		this.sabor = "S/S";
		this.puedoHacerFruta = false;
	}
	
	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getColor() {
		return color;
	}

	public void setColor(String color) {
		this.color = color;
	}

	public String getSabor() {
		return sabor;
	}

	public void setSabor(String sabor) {
		this.sabor = sabor;
	}

	public boolean isPuedoHacerFruta() {
		return puedoHacerFruta;
	}

	public void setPuedoHacerFruta(boolean puedoHacerFruta) {
		this.puedoHacerFruta = puedoHacerFruta;
	}

	public Fruta(String nombre, String color, String sabor) {
		super(); /*heredar constructor de la clase PADRE*/
		this.nombre = nombre;
		this.color = color;
		this.sabor = sabor;
	}

	public static String LugarOrigen="UPC";

    /*Sobreescritura de metodos heredados*/
	@Override
	public String toString() {
		return "Fruta [nombre=" + nombre + ", color=" + color + ", sabor=" + sabor + ", puedoHacerFruta="
				+ puedoHacerFruta + "]";
	} 
		
}
