using UnityEngine;
using System.Collections;

public class BancoPreguntas : MonoBehaviour {

	public static string[,] buenasColumnas = new string[,] {
		{"H2O", "Agua"},
		{"FeO", "Oxido Ferroso"},
		{"NaCl", "Sal"}
	};

	public static string[,] malasColumnas = new string[,] {
		{ "Basket", "Fut" },
		{ "Americano", "Golf" },
		{ "Boliche", "Frisbee" },
		{ "Judo", "Karate" },
		{ "Esgrima", "Clavados" },
		{ "Canotaje", "Voleibol" }
	};

	public static string[,] buenasElige = new string[,] {
		{"¿Quién es la maestra de APIS?", "Jackeline"},
		{"¿Quien es el cliente?", "PrepaNet"}
	};

	public static string[] malasElige = new string[] {
			"Wicho", 
			"Mejorado", 
			"Raul Esparza", 
			"Elda Quiroga", 
			"Román", 
			"Yolanda"
	};

	public static string[,] tOrf = new string[,] {
		{"¿Estamos en el tec?", "si"},
		{"¿Me gusta el agua?", "no"}
	};

	//--------------------------------------------------------------------
	//-----------------Ya del juego---------------------------------------
	//--------------------------------------------------------------------

	public static string[, ,] buenasNomeclatura = new string[, ,] {{
			{"¿Cómo se llama el grupo funcional de los ácidos carboxílicos?", "Grupo carboxilo", "no"},
			{"¿Cuál es la formula general de los ácidos carboxílicos?", "R-COOH", "no"},
			{"¿Cuál es el nombre común del ácido hexadecanoico?", "Ácido palmítico", "no"},
			{"¿Cuál es el nombre común del ácido metanoico?", "Ácido fórmico", "no"},
			{"Es una propiedad física de los ácidos carboxílicos:", "Alto punto de ebullición", "no"},
			{"¿Cuál es el nombre según la IUPAC del ácido acético?", "Ácido etanoico", "no"},
			{"¿Cuál es la estructura condensada del ácido hexanoico?", "CH3(CH2)3COOH", "no"},
			{"¿ Cuál es la formula general del grupo hidroxilo?", "R-OH", "no"},
			{"¿Qué grupos funcionales coinciden en el grupo carboxilo?", "Grupo hidroxilo y grupo carbonilo", "no"},
			{"¿Cuál es el nombre del ácido con la estructura condensada HCOOH?", "Ácido fórmico", "no"},
			{"¿ Cuál es la fórmula general del grupo carbonilo?", "R-C=O", "no"},
			{"¿Cuál es el nombre común del ácido propanoico?", "Ácido propiónico", "no"},
			{"¿Cuál es el nombre común del ácido butanoico?", "Ácido butírico", "no"},
			{"¿Cuál es la estructura condensada del ácido propanoico?", "CH3CH2COOH", "no"},
			{"¿Cuál es la estructura condensada del ácido butanoico?", "CH3(CH2)2COOH", "no"},
			{"¿Cuál es la estructura condensada del ácido etanoico?", "CH3COOH", "no"},
			{"¿Nombres IUPAC del alcano lineal de 6 carbonos?", "hexano", "no"},
			{"¿Nombres IUPAC del alcano lineal de 10 carbonos?", "undecano", "no"},
			{"¿Nombres IUPAC del alcano lineal de 4 carbonos?", "butano", "no"},
			{"¿Nombres IUPAC del alcano lineal de 2 carbonos?", "etano", "no"},
			{"¿Nombres IUPAC del alcano lineal de 1 carbonos?", "metano", "no"},
			{"¿Nombres IUPAC del alcano lineal de 3 carbonos?", "propano", "no"},
			{"¿Nombres IUPAC del alcano lineal de 5 carbonos?", "pentano", "no"},
			{"¿Nombres IUPAC del alcano lineal de 7 carbonos?", "heptano", "no"},
			{"¿Nombres IUPAC del alcano lineal de 8 carbonos?", "octano", "no"},
			{"¿Nombres IUPAC del alcano lineal de 9 carbonos?", "nonano", "no"},
			{"La cadena principal de carbonos en un compuesto es la más:", "larga", "no"},
			{"Si están presentes dos cadenas diferentes de igual longitud, seleccione como cadena principal la que __________ ramificaciones.", "tiene más", "no"},
			{"La cadena principal, se numera empezando desde un extremo de tal forma que se asigne el número __________   al sustituyente.", "más bajo posible", "no"},
			{"¿Qué prefijo multiplicativo se usa cuando hay 2 sustituyentes iguales en una estructura?", "di", "no"},
			{"¿Qué prefijo multiplicativo se usa cuando hay 3 sustituyentes iguales en una estructura?", "tri", "no"},
			{"¿Qué prefijo multiplicativo se usa cuando hay 4 sustituyentes iguales en una estructura?", "tetra", "no"},
			{"¿Qué prefijo multiplicativo se usa cuando hay 5 sustituyentes iguales en una estructura?", "penta", "no"},
			{"¿Qué prefijo multiplicativo se usa cuando hay 2 sustituyentes iguales en una estructura?", "hexa", "no"},
			{"Cuando hay más de un sustituyente igual en la estructura a nombrar se utiliza el __________   para indicar la cantidad de veces que se repite en ella.", "prefijo multiplicativo", "no"},
			{"Después de escribir el prefijo multiplicativo correspondiente se debe colocar el número de carbono donde se localiza cada sustituyente repetido, los índices de cada sustituyente deben estar separados con __________.", "coma", "no"},
			{"¿Cómo se debe escribir el prefijo y el nombre del sustituyente que modifica al nombrar una estructura?", "juntos", "no"},
			{"¿Cuál forma está escrito correctamente?", "dimetil", "no"},
			{"¿Cuál forma está escrito correctamente?", "tetrametil", "no"},
			{"¿Cuál es el nombre especial de este sustituyente común?", "isobutil", "no"},
			{"¿Cuál es el nombre especial de este sustituyente común?", "isopropil", "no"},
			{"¿Cuál es el nombre especial de este sustituyente común?", "isopentil", "no"},
			{"¿Cuál es el nombre especial de este sustituyente común?", "tert-butil o t-butil", "no"},
			{"¿Cuál es el nombre especial de este sustituyente común?", "sec-butil", "no"},
			{"¿Cuál es el nombre especial de este sustituyente común?", "neopentil", "no"},
			{"¿Cómo se deben ordenar los sustituyentes?", "Por orden alfabético.", "no"},
			{"¿Cuál está escrito correctamente?", "5-sec-butil-8-isopropil-4,4-dimetil- 6-pentil-7-propilundecano", "no"},
			{"Los compuestos cíclicos normalmente se nombran como cicloalcanos sustituidos por grupos alquilo y la única excepción a esta regla ocurre cuando la cadena alquílica contiene un número __________ de carbonos que el anillo. ", "mayor", "no"},
			{"¿Cuál es el prefijo utilizado en los compuestos cíclicos?", "cicli", "no"},
			{"¿Cuándo no es necesario indicar el índice del sustituyente?", "Cuando sólo tiene 1", "no"}
		}};

	public static string[, ,] malasNomenclatura = new string[, ,] {{
			{"Grupo carbonilo", "Grupo acilo", "Grupo carboxílico"},
			{"R-COOOH", "R-COH", "R-COOHN"},
			{"Ácido caproico", "Ácido propiónico", "Ácido fórmico"},
			{"Ácido caproico", "Ácido butírico", "Ácido propiónico"},
			{"Bajo punto de ebullición","Bajo punto de fusión","Olores agradables"},
			{"Ácido pentanoico","Ácido propanoico","Ácido butírico"},
			{"CH3(CH2)2COOH","CH3(CH2)5COOH","CH3(CH2)4COOH"},
			{"R-OOH","R-COOH","R-C=O"},
			{"Grupo carbonilo y grupo acilo","Grupo carbonilo y grupo amina","Grupo hidroxilo y grupo acilo"},
			{"Ácido butírico","Ácido etanoico","Ácido caproico"},
			{"R-OH", "R-COOH", "R-COR"},
			{"Ácido caproico", "Ácido palmítico", "Ácido fórmico"},
			{"Ácido caproico", "Ácido propiónico", "Ácido fórmico"},
			{"CH3(CH2)2COOH", "CH3(CH2)3COOH", "CH3(CH2)4COOH"},
			{"CH3(CH2)3COOH", "CH3CH2COOH", "CH3(CH2)4COOH"},
			{"CH3(CH2)2COOH", "CH3CH2COOH", "CH3CH2COOH"},
			{"heptano", "butano", "metano"},
			{"diezano", "heptano", "metano"},
			{"hexano", "heptano", "metano"},
			{"heptano", "butano", "metano"},
			{"hexano", "heptano", "butano"},
			{"tresano", "butano", "metano"},
			{"hexano", "propano", "metano"},
			{"hexano", "septano", "metano"},
			{"decano", "undecano", "nonano"},
			{"decano", "undecano", "octano"},
			{"corta", "discontinua", "saturada"},
			{"tiene menos", "no tiene", "diferentes"},
			{"más alto posible ", "impar", "par"},
			{"tri", "tetra", "penta"},
			{"di", "tetra", "penta"},
			{"tri", "di", "penta"},
			{"tri", "di", "tetra"},
			{"tri", "tetra", "penta"},
			{"sufijo multiplicativo", "interfijos", "subíndice"},
			{"guión", "punto", "dos puntos"},
			{"separados por una coma", "separados por un guión", "separados por dos puntos"},
			{"di-metil", "di.metil", "di,metil"},
			{"tetra metil", "tetra-metil", "tetra,metil"},
			{"isopropil", "isopentil", "isohexil"},
			{"isobutil", "isopentil", "isohexil"},
			{"isopropil", "isobutil", "isohexil"},
			{"sec-butil", "tert-pentil", "neopentil"},
			{"tert-butil o t-butil", "tert-pentil", "neopentil"},
			{"sec-butil", "tert-butil o t-butil", "tert-pentil"},
			{"Por la cantidad de carbonos que tiene el sustituyente.", "Por el número o índice donde se encuentra el sustituyente.", "Por la cantidad de veces que se repite el sustituyente."},
			{"8-isopropil-5-sec-butil-4,4-dimetil- 6-pentil-7-propilundecano", "4,4-dimetil-5-sec-butil-8-isopropil-6-pentil-7-propilundecano", "4,4-dimetil-8-isopropil-5-sec-butil- 6-pentil-7-propilundecano"},
			{"menor", "igual", "diferente"},
			{"ciclos", "ciclo", "anillo"},
			{"Nunca", "Siempre se debe colocar el índice del sustituyente", "Siempre se debe colocar el índice del sustituyente"}
		}};

	public static string[, ,] tOrfNomenclatura = new string[, ,] {{
			{"La siguente molécula es un ácido carboxílico", "si", "no"},
			{"La siguente imagen es una representación del ácido acético", "no", "no"},
			{"La siguiente imagen es una representación del ácido etanoico:", "si", "no"},
			{"La siguiente imagen es una representación del ácido etanoico:", "no", "no"},
			{"La siguiente imagen es una representación del ácido acético:", "no", "no"},
			{"La siguiente imagen es una representación del compuesto 5-sec-butil-8-isopropilundecano", "si", "no"},
			{"La cadena principal resaltada en el siguiente compuesto es correcta:", "si", "no"},
			{"La cadena principal resaltada en el siguiente compuesto es correcta: ", "no", "no"},
			{"La siguiente imagen es una representación del compuesto Ácido 3-bromo-6-oxo-octanoico:", "si", "no"},
			{"La siguiente imagen es una representación del ácido palmítico:", "no", "no"},
			{"La numeración de los sustituyentes en el compuesto es correcta:", "si", "no"},
			{"La numeración de los sustituyentes en el compuesto es correcta:", "no", "no"},
			{"La siguiente molécula en 3D representa a la estructura condensada CH3(CH2)5COOH:", "si", "no"},
			{"La siguiente molécula en 3D representa a la estructura condensada CH3CH2COOH:", "no", "no"},
			{"La siguiente molécula en 3D representa a la estructura condensada CH3(CH2)8COOH:", "si", "no"}
		}};

	public static string[,] cadenaNomenclatura = new string[,] {
		{"Ácido 3-bromo-6-oxo-octanoico","no"},
		{"Ácido ciclohexnocarboxílico","no"},
		{"Ácido acético","no"},
		{"Ácido 4-hidroxi-3-metilpentanoico","no"},
		{"Ácido benzoico","no"},
		{"Ácido 4-bromo-5-oxo-heptanoico","no"},
		{"Ácido metanoico","no"},
		{"Ácido etanoico","no"},
		{"Ácido propanoico","no"},
		{"Ácido pentanoico","no"},
		{"Ácido hexadecanoico","no"},
		{"Ácido octanoico","no"},
		{"Ácido heptanodioico","no"},
		{"Ácido 2-hidroxipropano-1,2,3-tricarboxílico","no"},
		{"Ácido láctico","no"},
		{"Ácido hexadecanoico","no"},
		{"Ácido etanodioico","no"},
		{"Ácido 3,5-dimetilhexanoico","no"},
		{"Ácido ciclopentanocarboxílico","no"},
		{"Ácido 2-clorociclohexanocarboxílico","no"}
	};
}
