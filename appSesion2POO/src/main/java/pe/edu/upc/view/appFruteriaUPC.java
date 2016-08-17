package pe.edu.upc.view;

import pe.edu.upc.appSesion2POO.Fruta;


public class appFruteriaUPC {

	public static void main(String[] args) {
		Fruta objFruta = 
				new Fruta("Mango", "Amarillo", "Dulce");
		System.out.println(objFruta.toString());
		
		Fruta.LugarOrigen = "Otro lugar";
		System.out.println(Fruta.LugarOrigen);
	}

}
