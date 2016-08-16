package pe.edu.upc.appEjercicio1;
import java.util.Scanner;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {
    	//Creacion del objeto
    	Scanner s = new Scanner(System.in); 
    	
    	int numero;
    	String[] arrNombres = new String [3];
    	
    	for (int i = 0; i < arrNombres.length; i++) {
			System.out.print("Nombre" + (i+1));
			arrNombres[i] = s.nextLine(); //nextLine agrega lo ingresado por consola... 
		}
    	
    
        System.out.println( "Hello World!" );
    }
}

