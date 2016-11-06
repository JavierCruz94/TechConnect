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
			{"¿Cuál es el nombre común del ácido metanoico?", "Ácido fórmico", "no"},
			{"Es una propiedad física de los ácidos carboxílicos:", "Alto punto de ebullición", "no"},
			{"¿Cuál es el nombre según la IUPAC del ácido acético?", "Ácido etanoico", "no"},
			{"¿Cuál es la estructura condensada del ácido hexanoico?", "CH3(CH2)3COOH", "no"},
			{"¿ Cuál es la formula general del grupo hidroxilo?", "R-OH", "no"},
			{"¿Qué grupos funcionales coinciden en el grupo carboxilo?", "Grupo hidroxilo y grupo carbonilo", "no"},
			{"¿Cuál es el nombre del ácido con la estructura condensada HCOOH?", "Ácido fórmico", "no"}
		}};

	public static string[, ,] malasNomenclatura = new string[, ,] {{
			{"Grupo carbonilo", "Grupo acilo", "Grupo carboxílico"},
			{"R-COOOH", "R-COH", "R-COOHN"},
			{"Ácido caproico", "Ácido butírico", "Ácido propiónico"},
			{"Bajo punto de ebullición","Bajo punto de fusión","Olores agradables"},
			{"Ácido pentanoico","Ácido propanoico","Ácido butírico"},
			{"CH3(CH2)2COOH","CH3(CH2)5COOH","CH3(CH2)4COOH"},
			{"R-OOH","R-COOH","R-C=O"},
			{"Grupo carbonilo y grupo acilo","Grupo carbonilo y grupo amina","Grupo hidroxilo y grupo acilo"},
			{"Ácido butírico","Ácido etanoico","Ácido caproico"}
		}};

	public static string[, ,] tOrfNomenclatura = new string[, ,] {{
		{"La siguente molécula es un ácido carboxílico", "si", "no"},
		{"La siguente imagen es una representación del ácido acético", "no", "no"},
			{"Este proyecto fue un éxito", "no", "no"}
		}};
}
