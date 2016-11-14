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

	//--------NOMENCLATURA------------------------------------------------

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
			{"Cuando hay más de un sustituyente igual en la estructura a nombrar se utiliza el __________ para indicar la cantidad de veces que se repite en ella.", "prefijo multiplicativo", "no"},
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

	//----------------------REACCIONES DE ACIDOS C--------------
	public static string[, ,] eligeBienReacciones = new string[, ,] { {
			{ "¿Cual es la formula molecular del acido acético?", "CH3COOH", "no" },
			{ "Los aldehídos o los alcoholes primarios se oxidan normalmente para producer acidos emapleando __________:", "Acido Cromico", "no" },
			{ "El permanganato de potasio reacciona con los alquenos para dar __________:", "Glicoles", "no" },
			{ "¿Cómo se diferencian las reacciones de lo ácidos carboxílicos a la de las cetonas o aldehídos?", "Reaccionan principalmente por sustitución nucleofílica de acilo", "no" },
			{ "Los mejores reactivos para convertir los ácidos carboxílicos en cloruros de ácido son el __________ y __________:", "Cloruro de tionilo y Cloruro de oxalilo", "no" },
			{ "¿Con respecto a la pregunta anterior, porque son estos los mejores reactivos?", "Porque requieren menor cantidad de energía para reaccionar", "no" },
			{ "Los ácidos carboxílicos se convierten directamente en __________ mediante la esterificación de Fischer, al reaccionar un alcohol con catálisis ácida:", "Esteres", "no" },
			{ "El hidruro de litio y aluminio reduce los acidos carboxilicos para formar __________:", "Alcoholes", "no" },
			{ "Los ácidos carboxílicos se pueden convertir en halogenuros de alquilo con pérdida de __________ átomo(s) de carbono mediante la reacción de Hunsdiecker:", "1", "no" },
			{ "A medida que aumenta la longitud de la cadena de carbono, la solubilidad en agua:", "Disminuye", "no" },
			{ "Los ácidos carboxílicos son muy solubles en alcoholes porque:", "Forman enlaces de hidrógeno con ellos", "no" },
			{ "¿Cuál es la constante de equilibrio para las reacciones de ácidos carboxílicos?", "Ka", "no" },
			{ "¿Cuál de las siguientes se usa como indicador como indicador de la acidez relativa de diferentes aceites?", "pKa", "no" },
			{ "Es una propiedad física de los ácidos carboxílicos:", "Alto punto de ebullicion", "no" },
			{ "Los átomos electronegativos __________ la fuerza de un ácido:", "Aumentan", "no" },
			{ "¿Cuál es la fórmula molecular del Ácido Acrílico, aceptado por la IUPAC?", "CH2=CHCOOH", "no" },
			{ "¿Cuál es la fórmula molecular del Ácido Acético, aceptado por la IUPAC?", "CH3COOH", "no" },
			{ "¿Cuál es la fórmula molecular del Ácido Benzoico, aceptado por la IUPAC?", "C6H5COOH", "no" },
			{ "¿Qué cuando un ácido carboxílico reacciona con una base?", "Se forma la sal del ácido y agua", "no" },
			{ "¿Qué se le debe de agregar a los reactivos de Grignard para formar las sales de magnesio de los ácidos carboxílicos?", "CO2", "no" },
			{ "¿Con qué se debe desplazar un halogenuro de alquilo convertirlo en un ácido carboxílico con un átomo de carbono adicional?", "Cianuro de Sodio", "no" },
			{ "Los puntos de ebullición de los ácidos carboxílicos son el resultado de la formación de un dimero estable con:", "Puentes de Hidrógenos", "no" },
			{ "Los ácidos carboxílicos que contienen más de __________ , por lo general son sólidos, a menos que tengan dobles enlaces:", "6", "no" },
			{ "¿Qué se agrega a los reactivos de Grignard para formar las sales de magnesio de los ácidos carboxílicos?", "CO2", "no" },
			{ "¿Qué sal se forma cuando se le agrega dióxido de carbono a los reactivos de Grignard?", "De Magnesio", "no" },
			{ "¿Cuál es el ácido más importante de todos los ácidos carboxílicos?", "Ácido ", "no" },
			{ "Un ácido carboxílico se convierte en un __________ calentándolo con un alcohol en presencia de un poco de ácido mineral?", "Ester", "no" },
			{ "En presencia de una pequeña cantidad de __________, los ácidos carboxílicos alifaticos reaccionan suavemente con el Cl2 o Br2 para dar un compuesto en el que se ha reemplazada un hidrogeno alfa por un halógeno:", "Fósforo", "no" },
			{ "Entre MAS ALTO es el pka, un ácido carboxílico es:", "Menos ácido", "no" }
		}};
	
	public static string[, ,] eligeMalReacciones = new string[, ,] { {
			{ "CH3-CO-CH2-COOH", "C6H5COOH", "H-COOH" },
			{ "Acido Acetico", "Acido Formico", "Acido Glicolico" },
			{ "Alcoholes", "Cetonals", "Fenoles" },
			{ "Reaccionan más fácil en presencia de H2O", "Reaccionan normalmente por adición nucleofílica del grupo carbonilo", "Reaccionan más fácil con metales" },
			{ "Cloruro de potasio y Cloruro de sodio", "Cloruro de tionilo y Cloruro de potasio", "Cloruro de potasio y Cloruro de oxalilo" },
			{ "Porque no liberan tanto gas", "Porque no contaminan el producto", "Porque requieren mayor cantidad de energía para reaccionar" },
			{ "Cetonas", "Aminas", "Eteres" },
			{ "Cetonas", "Aminas", "Esteres" },
			{ "2", "3", "6" },
			{ "Aumenta", "Se queda igual", "No se ve afectada" },
			{ "Hay presencia de un precipitado", "Forman enlaces iónicos con ellos", "Forman enlaces covalentes con ellos" },
			{ "Kp", "Kc", "Ke" },
			{ "pKp", "pKc", "pKe" },
			{ "Bajo punto de ebullición", "Bajo punto de fusión", "Olores agradables" },
			{ "Disminuyen", "Disminuyen a la mitad", "No afecta" },
			{ "CH3COOH", "OHC-COOH", "H-COOH" },
			{ "C6H5COOH", "HOOC-CH=CH-COOH", "OHC-COOH" },
			{ "HOOC-CH=CH-COOH", "OHC-COOH", "CH3COOH" },
			{ "Se forma un alcohol primario y un aldehído", "Se forma un alqueno y una cetona", "Se forma un Halogenuro de acilo y una Cetona" },
			{ "SO2", "CH4", "SO4" },
			{ "Cloruro de Sodio", "Cloruro de Potasio", "Dióxido de Carbono" },
			{ "Enlaces Covalentes", "Enlaces Iónicos", "Enlaces Polares" },
			{ "14", "8", "10" },
			{ "H20", "CO", "KCl" },
			{ "De Potasio", "De Cloro", "De Manganeso" },
			{ "Ácido benzoico", "Ácido cromico", "Ácido formico" },
			{ "Amina", "Amida", "Eter" },
			{ "Calcio", "Magnesio", "Cromo" },
			{ "Más ácido", "Más estable", "Menos estable" }
		}};

	public static string[,] relacionaReacciones = new string[,] {
		{"Ácido Benzoico + NaHCO3","no"},
		{"CH3(CH2)3COOH + NaOH","no"},
		{"2CH3COOH + Zn","no"},
		{"Ácido benzoico + PCl5","no"},
		{"Ácido hexanoico + SOCl2","no"},
		{"Ácido benzoico + Metanol","no"},
		{"Ácido acético + Alcohol bencílico","no"},
		{"Ácido trimetilacetico + SOCl2","no"},
		{"Ácido adipico + Etanol (P.e= 78 e)","no"},
		{"Ácido mandelico + C2H5OH","no"},
		{"Ácido benzoico + CH3OH","no"},
		{"Ácido fenilacetico + SOCl2","no"},
		{"Ácido trimetilacetico + 3LiAlH4","no"},
		{"Ácido m-toluico + LiAlH4","no"},
		{"Ácido benzico + PCl5","no"},
		{"Ácido metanoico + PCl3","no"},
		{"Ácido benzoico + HNO3","no"},
		{"2-Metil-1-butanol + KMnO4","no"},
		{"Alcohol isobutilico + KMnO4","no"},
		{"4-Metil-1-pentanol + CrO3","no"},
		{"Hexanol + H3O","no"},
		{"P-Nitrotolueno + K2Cr2O7,H2SO4","no"},
		{"o-Bromotolueno + KMnO4,OH","no"},
		{"Fenilacetonitrilo + H2SO4 70%","no"},
		{"Ácido benzoico + Na2CO3","no"}
	};

	public static string[, ,] tOrfReacciones = new string[, ,] {{
			{"Ka es la consante de equilibrio usada para los acidos carboxilicos.", "si", "no"},
			{"Los ácidos carboxílicos tienen bajo punto de ebullición.", "no", "no"},
			{"Los átomos electronegativos disminuyen la fuerza de una ácido.", "no", "no"},
			{"H-COOH es la fórmula molecular del ácido acético.", "no", "no"},
			{"Cuando un ácido carboxílico reacciona con una base se forma la sal del ácido y agua.", "si", "no"},
			{"A los reactivos de Grignard se le agrega SO2 para formar las sales de magnesio.", "no", "no"},
			{"El alto punto de ebullición de los ácidos carboxílicos se debe a los enlaces covalentes presentes.", "no", "no"},
			{"Un ácido carboxílico se convierte en un ester cuando se calienta con un alcohol en presencia de un poco de ácido mineral.", "si", "no"},
			{"Entre más bajo sea el pKa de un ácido, este es MAS ACIDO.", "si", "no"},
			{"A medida que la longitud de la cadena de carbón, la solubilidad en agua aumenta.", "no", "no"},
			{"Los ácidos carboxílicos son muy solubles en alcoholes porque forman enlaces iónicos con ellos.", "no", "no"},
			{"Los nitrilos se hidrolizan acido o básico para dar ácidos carboxílicos.", "si", "no"},
			{"El PCl5 es uno de los compuestos que se usan para cloruros de ácido mediante la reacción de ácidos carboxílicos.", "si", "no"},
			{"Las reacciones de los ácidos carboxílicos se diferencian a la de las cetonas o aldehídos en que estos reaccionan más fácil con los metales.", "no", "no"},
			{"C6H5COOH es la fórmula molecular del ácido benzoico.", "si", "no"}
		}};

	//---------------APLICACIONES------------------
	public static string[, ,] eligeBienAplicaciones = new string[, ,] { {
			{ "¿Nombre IUPAC del compuesto conocido comúnmente como ácido fumárico?", "Ácido (E)-Butenodioico", "no" },
			{ "No es una propiedad física del ácido fumárico:", "Sublima a 100ºC", "no" },
			{ "Es la fórmula molecular del ácido fumárico:", "C4H4O4", "no" },
			{ "¿Cuál es la aplicación del ácido fumárico en la industria alimentaria?", "Se utiliza en la conservación de los alimentos.", "no" },
			{ "¿Nombre IUPAC del compuesto conocido comúnmente como ácido málico?", "Ácido 2-hidroxi-1,4-butanodioico", "no" },
			{ "No es una propiedad física del ácido málico:", "Sublima a 200ºC", "no" },
			{ "Es la fórmula molecular del ácido málico:", "C4H6O5", "no" },
			{ "¿Cuál es la aplicación del ácido fumárico en la industria alimentaria?", "Se utiliza como acidulante", "no" },
			{ "¿Nombre IUPAC del compuesto conocido comúnmente como ácido butírico?", "Ácido butanoico", "no" },
			{ "Es la fórmula molecular del ácido butírico:", "C4H8O2", "no" },
			{ "¿Cuál es la aplicación del ácido butírico en la industria alimentaria?", "Da olor a la mantequilla", "no" },
			{ "Es la fórmula molecular del ácido propanoico:", "C3H6O2", "no" },
			{ "¿Cuál es la aplicación del ácido propanoico en la industria alimentaria?", "Se utiliza en la conservación de productos panificados", "no" },
			{ "¿Nombre IUPAC del compuesto conocido comúnmente como ácido oleico?", "Ácido cis-9-octadecenoico", "no" },
			{ "No es una propiedad física del ácido oleico:", "Es soluble en agua", "no" },
			{ "Es la fórmula molecular del ácido oleico:", "C18H34O2", "no" },
			{ "¿Cuál es la aplicación del ácido oleico en la industria alimentaria?", "Se utiliza en la producción de aceite natural", "no" },
			{ "Es un beneficio comprobando por consumir productos con ácido oleico:", "Disminuye el colesterol", "no" },
			{ "¿Cuál es el nombres IUPAC del compuesto conocido comúnmente como ácido láctico?", "Ácido 2-hidroxipropanoico", "no" },
			{ "Es la fórmula molecular del ácido láctico:", "C3H6O3", "no" },
			{ "¿Cuál es la aplicación del ácido láctico en la industria alimentaria?", "Se utiliza en la elaboración de queso", "no" },
			{ "¿Cuál es la fuente de la producción de ácido láctico a nivel industrial?", "De bacterias como la Lactobacillus delbrueckii", "no" },
			{ "¿Cuál enantiómero del ácido láctico tiene importancia biológica?", "L-ácido láctico", "no" },
			{ "¿Nombre IUPAC del compuesto conocido comúnmente como ácido cítrico?", "Ácido 2-hidroxipropano-1,2,3-tricarboxílico", "no" },
			{ "No es una propiedad física del ácido cítrico:", "Tiene como punto de fusión 135ºC", "no" },
			{ "Es la fórmula molecular del ácido cítrico:", "C6H8O7", "no" },
			{ "¿Cuál es la aplicación del ácido cítrico en la industria alimentaria?", "Se utiliza como aditivo en bebidas y alimentos.", "no" },
			{ "¿Cuál es la fuente de la producción de ácido cítrico a nivel industrial?", "La fermentación de azúcares por el hongo  Aspergillus niger.", "no" },
			{ "Es un riesgo al emplear ácido cítrico:", "Irritación de la piel y ojos", "no" },
			{"El 92% de la producción de ácido cítrico mundial es elaborado en Estados Unidos, China, Brasil, la Unión Europea y:", "Colombia", "no"}
		}};

	public static string[, ,] eligeMalAplicaciones = new string[, ,] { {
			{ "Ácido (E)-Propanoico", "Ácido (E)-Propanodioico", "Ácido (E)-Butenoico" },
			{ "Compuesto color blanco", "Sublima a 200ºC", "Compuesto en forma de polvo " },
			{ "C4H6O4", "C6H4O4", "C6H6O6" },
			{ "Se utiliza en la fabricación de vinagre", "Se utiliza en producción de queso", "Se utiliza para fabricar pintura" },
			{ "Ácido 2-hidroxi-1,6-butanodioico", "Ácido 2-hidroxi-2,4-butanodioico", "Ácido 2-hidroxi-1-4-butano-dioico" },
			{ "Compuesto color blanco", "Compuesto en forma de polvo ", "Sublima a 100ºC" },
			{ "C4H4O4", "C6H4O4", "C6H6O6" },
			{ "Se utiliza en la conservación de los alimentos.", "Se utiliza en la fabricación de vinagre", "Se utiliza para fabricar pintura" },
			{ "Ácido pentanoico", "Ácido hexanoico", "Ácido etanoico" },
			{ "C4H4O4", "C8H4O2", "C8H4O2" },
			{ "Se utiliza en la fabricación de vinagre", "Se utiliza como acidulante", "Se utiliza para fabricar pintura" },
			{ "C4H4O3", "C4H3O2", "C2H6O3" },
			{ "Se utiliza en la fabricación de vinagre", "Se utiliza en producción de queso", "Se utiliza para fabricar pintura" },
			{ "Ácido cis-9-decenoico", "Ácido cis-9-octanoico", "Ácido cis-8-octadecenoico" },
			{ "Es soluble en benceno", "Se funde a los 14ºC ", "Se solidifica por enfriamiento" },
			{ "C18H18O2", "C4H6O2", "C18H34O18" },
			{ "Se utiliza en la fabricación de vinagre", "Se utiliza como acidulante", "Se utiliza para fabricar pintura" },
			{ "Te ayuda a adelgazar", "Previene el cáncer", "Disminuye los signos del envejecimiento" },
			{ "Ácido 2-hidroxi-propanoico", "Ácido 2-hidroxipentanoico", "Ácido 3-hidroxipropiónico" },
			{ "C3H7O3", "C3H3O6", "C3H6O13" },
			{ "Se utiliza en la fabricación de vinagre", "Se utiliza para fabricar pintura", "Se utiliza para fabricar aceite" },
			{ "La lactosa", "Del páncreas de los cerdos", "Del cuero" },
			{ "D-ácido láctico", "Ninguno", "Ácido láctico" },
			{ "Ácido 2-hidroxipropano-1,3-dicarboxílico", "Ácido 3-hidroxipropano-1,2,3-tricarboxílico", "Ácido 2-hidroxipropano-1,2,4-tricarboxílico" },
			{ "Compuesto color cristalino blanco", "Tiene como punto de fusión 153ºC", "Compuesto soluble en agua " },
			{ "C6H4O7", "C6H7O8", "C7H8O6" },
			{ "Se utiliza como abrillantador de metales.", "Se utiliza en producción de queso", "Se utiliza para para acelerar el efecto de la levadura" },
			{ "De bacterias como la Lactobacillus delbrueckii", "Precipitando con óxido de calcio al jugo de los frutos cítricos.", "De todo el reino fungus" },
			{ "Infecciones", "Pérdida de la vista", "Pérdida del olfato" },
			{ "México", "Chile", "Uruguay" }
		}};

	public static string[,] relacionaAplicaciones = new string[,] {
		{ "", "no" },
	};

	public static string[, ,] tOrfAplicaciones = new string[, ,] {{
			{"Algunos ácidos carboxílicos se usan en la producción de alimentos.", "si", "no"},
			{"El ácido palmítico es usado como acidulante en bebidas.", "no", "no"},
			{"El ácido cítrico se produce a nivel industrial mediante la bacteria Lactobacillus delbrueckii.", "no", "no"},
			{"El ácido láctico se produce a nivel industrial mediante la bacteria Lactobacillus delbrueckii.", "si", "no"},
			{"El ácido fumárico se utiliza en la conservación de alimentos por su fuerte acción antimicrobiana.", "si", "no"},
			{"El ácido málico se usa como materia prima para la producción de aceites.", "no", "no"},
			{"El ácido málico se usa como acidulante para regular la acidez de los alimentos.", "si", "no"},
			{"El ácido butanoico es el responsable del olor de la cerveza.", "no", "no"},
			{"El ácido butanoico es el responsable del olor de la mantequilla.", "si", "no"},
			{"El ácido propanoico tiene una aplicación similar en la industria alimentaria que el ácido fumárico.", "si", "no"},
			{"El ácido propanoico se usa como materia prima para la producción de aceites.", "no", "no"},
			{"En los aceites naturales podemos encontrar el ácido oléico.", "si", "no"},
			{"El aceite de cártamo tiene el mayor porcentaje de ácido oléico.", "no", "no"},
			{"Los productos con ácido oléico son malos para la salud.", "no", "no"},
			{"Consumir ácido oléico reduce el colesterol en el organismo humano.", "si", "no"},
			{"El ácido láctico es usado para producir queso y yogurt.", "si", "no"},
			{"El ácido cítrico se produce a nivel industrial mediante el hongo Aspergillus niger.", "si", "no"},
			{"México es uno de los grandes productores de ácido cítrico en el mundo.", "no", "no"},
			{"El ácido propanoico es el responsable del olor de la mantequilla.", "no", "no"},
			{"El ácido acrílico es usado en muchos procesos de la industria alimentaria.", "no", "no"}
		}};
}
