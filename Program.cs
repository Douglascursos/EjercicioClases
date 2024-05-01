using EjercicioClase;

SuperPoder superHeroe1 = new SuperPoder();
SuperPoder superHeroe2 = new SuperPoder();
SuperPoder superHeroe3 = new SuperPoder();

superHeroe1.Nombre = "Terrestre";
superHeroe2.Nombre = "Espiritual";
superHeroe3.Nombre = "TerrestreEspiritual";

superHeroe1.IdentidadSecreta = "Terrestre N1";
superHeroe2.IdentidadSecreta = "Espiritual N1";
superHeroe3.IdentidadSecreta = "TE NM";

superHeroe1.Ciudad = "Ciudad Terrestre";
superHeroe2.Ciudad = "Ciudad Espiritual";
superHeroe3.Ciudad = "Ciudad Terrestre-Espiritual";

superHeroe1.PuedeVolar = false;
superHeroe2.PuedeVolar = true;
superHeroe3.PuedeVolar = true;

superHeroe1.SuperPoder = "Unidimensional";
superHeroe2.SuperPoder = "Bidimensional";
superHeroe3.SuperPoder = "Omnipotencia";

superHeroe1.Descripcion = "Poder en una sola dimension 'Dimension Terrestre'";
superHeroe2.Descripcion = "Poder en dos dimensiones 'Dimension Terrestre y Espiritual";
superHeroe3.Descripcion = "Poder absoluto";

superHeroe1.Nivel = 1;
superHeroe2.Nivel = 1;
superHeroe3.Nivel = 3;

superHeroe1.Imprimir();
superHeroe2.Imprimir();
superHeroe3.Imprimir();


