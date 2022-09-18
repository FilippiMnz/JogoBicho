using System; 

namespace JogoDoBicho
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Sorteio();
        }
        static void AnimaisCliente(){
             Console.WriteLine("Manda o animal meu patrão");
            Console.WriteLine("1-Avestruz \n" +
                          "2- Aguia \n" +
                          "3-Burro \n" +
                          "4-Borboleta \n" +
                          "5-Cachorro \n" +
                          "6-Cabra \n" +
                          "7-Carneiro \n" +
                          "8-Camelo \n" +
                          "9-Cobra \n" +
                          "10-Coelho \n" +
                          "11-Cavalo \n" +
                          "12-Elefante \n" +
                          "13-Galo \n" +
                          "14-Gato \n" +
                          "15-Jacaré \n" +
                          "16-Leão \n" +
                          "17-Macaco \n" +
                          "orco \n" +
                          "-Pavão \n" +
                          "-Peru \n" +
                          "-Touro \n" +
                          "   Tigre \n" +
                          "-Urso \n" +
                          "2Veado \n" +
                          "2Vaca \n");
            short Animals = short.Parse(Console.ReadLine());

            switch(Animals){
                case 1 : Avestruz() ;break;
                case 2  : Aguia() ;break;
                case 3 : Burro() ;break;
                case 4 : Borboleta();break;
                case 5 : Cachorro();break;
                case 6 : Cabra();break;
                case 7 : Carneiro();break;
                case 8 : Camelo();break;
                case 9 : Cobra();break;
                case 10 : Coelho();break;
                case 11 : Cavalo();break;
                case 12 : Elefante();break;
                case 13 : Galo();break;
                case 14 : Gato();break;
                case 15 : Jacaré();break;
                case 16: Leão();break;
                case 17 : Macaco();break;
                case 18 : Porco();break;
                case 19 : Pavão();break;
                case 20 : Peru();break;
                case 21 : Touro();break;
                case 22 : Tigre();break;
                case 23 : Urso();break;
                case 24 : Veado();break;
                case 25 :Vaca() ;break;
               
            }
            
        }
        static void Avestruz(){
            Console.WriteLine("Você selecionou Avestruz");
        }

         static void Aguia(){
            Console.WriteLine("Você selecionou Aguia");
        }
         static void Burro(){
            Console.WriteLine("Você selecionou Burro");
        }
         static void Borboleta(){
            Console.WriteLine("Você selecionou Borboleta");
        }
         static void Cachorro(){
            Console.WriteLine("Você selecionou Cachorro");
        }
         static void Cabra(){
            Console.WriteLine("Você selecionou Cabra");
        }
         static void Carneiro(){
            Console.WriteLine("Você selecionou Carneiro");
        }
         static void Camelo(){
            Console.WriteLine("Você selecionou Camelo");
        }
         static void Cobra(){
            Console.WriteLine("Você selecionou Cobra");
        }
         static void Coelho(){
            Console.WriteLine("Você selecionou Coelho");
        }
         static void Cavalo(){
            Console.WriteLine("Você selecionou Cavalo");
        }
         static void Elefante(){
            Console.WriteLine("Você selecionou Elefante");
        }
         static void Galo(){
            Console.WriteLine("Você selecionou Galo");
        }
         static void Gato(){
            Console.WriteLine("Você selecionou Gato");
        }
         static void Jacaré(){
            Console.WriteLine("Você selecionou Jacaré");
        }
         static void Leão(){
            Console.WriteLine("Você selecionou Leão");
        }
         static void Macaco(){
            Console.WriteLine("Você selecionou Macaco");
        }
         static void Porco(){
            Console.WriteLine("Você selecionou Porco");
        }
         static void Pavão(){
            Console.WriteLine("Você selecionou Pavão");
        }
         static void Peru(){
            Console.WriteLine("Você selecionou Peru");
        }
         static void Touro(){
            Console.WriteLine("Você selecionou Touro");
        }
         static void Tigre(){
            Console.WriteLine("Você selecionou Tigre");
        }
         static void Urso(){
            Console.WriteLine("Você selecionou Urso");
        }
         static void Veado(){
            Console.WriteLine("Você selecionou Veado");
        }
         static void Vaca(){
            Console.WriteLine("Você selecionou Vaca");
        }
            
            
            static void Sorteio(){
                
                Console.Clear();
                Random rnd = new Random();
                for (uint ctr = 1; ctr <= 1; ctr++)
                Console.WriteLine($"{rnd.Next(1000, 9999)}");
                int Sorte = rnd.Next(1000, 9999);
                

            string esperanca = Sorte.ToString();
            Console.WriteLine(esperanca);

           string sobra = esperanca.Substring(2);
           short Resto = short.Parse(sobra);
           Console.WriteLine(sobra);
           switch(sobra){
                case "01" : aves();break;
                case "02" : aves();break;
                case "03" : aves();break;
                case "04" : aves();break;
                case "05" : agui();break;
                case "06" : agui();break;
                case "07" : agui();break;
                case "08" : agui();break;
                case "09" : burr();break;
                case "10" : burr();break;
                case "11" : burr();break;
                case "12" : burr();break;
                case "13" : borb();break;
                case "14" : borb();break;
                case "15" : borb();break;
                case "16" : borb();break;
                case "17" : cachr();break;
                case "18" : cachr();break;
                case "19" : cachr();break;
                case "20" : cachr();break;
                case "21" : cabr();break;
                case "22" : cabr();break;
                case "23" : cabr();break;
                case "24" : cabr();break;
                case "25" : carnei();break;
                case "26"  :carnei();break;
                case "27" : carnei();break;
                case "28" : carnei();break;
                case "29" : came() ;break;
                case "30" : came();break;
                case "31" : came();break;
                case "32" : came();break;
                case "33" : cobraa();break;
                case "34" : cobraa();break;
                case "35" : cobraa();break;
                case "36" : cobraa();break;
                case "37" : coelh();break;
                case "38" : coelh();break;
                case "39" : coelh();break;
                case "40" : coelh();break;
                case "41" : cava();break;
                case "42" : cava();break;
                case "43" : cava();break;
                case "44" : cava();break;
                case "45" : elephante();break;
                case "46" : elephante();break;
                case "47" : elephante();break;
                case "48" : elephante();break;
                case "49" : galooo();break;
                case "50" : galooo();break;
                case "51" : galooo();break;
                case "52" : galooo();break;
                case "53" : cat();break;
                case "54" : cat();break;
                case "55" : cat();break;
                case "56" : cat();break;
                case "57" : jacaree();break;
                case "58" : jacaree();break;
                case "59" : jacaree();break;
                case "60" : jacaree();break;
                case "61" : lion();break;
                case "62" : lion();break;
                case "63" : lion();break;
                case "64" : lion();break;
                case "65" : monkey();break;
                case "66" : monkey();break;
                case "67" : monkey();break;
                case "68" : monkey();break;
                case "69" : pig();break;
                case "70" : pig();break;
                case "71" : pig();break;
                case "72" : pig();break;
                case "73" : pavon();break;
                case "74" : pavon();break;
                case "75" : pavon();break;
                case "76" : pavon();break;
                case "77" : peru();break;
                case "78" : peru();break;
                case "79" : peru();break;
                case "80" : peru();break;
                case "81" : tour();break;
                case "82" : tour();break;
                case "83" : tour();break;
                case "84" : tour();break;
                case "85" : tiger();break;
                case "86" : tiger();break;
                case "87" : tiger();break;
                case "88" : tiger();break;
                case "89" : bear();break;
                case "90" : bear();break;
                case "91" : bear();break;
                case "92" : bear();break;
                case "93" : veadoa();break;
                case "94" : veadoa();break;
                case "95" : veadoa();break;
                case "96" : veadoa();break;
                case "97" : Vaca();break;
                case "98" : Vaca();break;
                case "99" : Vaca();break;
                case "00" : Vaca();break;

           }
           static void aves (){
            Console.WriteLine("O animal sortado foi Avestruz");
            
           }
            static void agui(){
            Console.WriteLine("O animal sortado foi Aguia");
           }
            static void burr (){
            Console.WriteLine("O animal sortado foi Burro");
           }
            static void borb(){
            Console.WriteLine("O animal sortado foi Borboleta");
           }
            static void cachr(){
            Console.WriteLine("O animal sortado foi Cachorro");
           }
            static void cabr (){
            Console.WriteLine("O animal sortado foi Cabra");
           }
            static void carnei(){
            Console.WriteLine("O animal sortado foi Carneiro");
           }
             static void came(){
            Console.WriteLine("O animal sortado foi Camelo");
           }
            static void cobraa(){
            Console.WriteLine("O animal sortado foi Cobra");
           }
            static void coelh(){
            Console.WriteLine("O animal sortado foi Coelho");
           }
            static void cava (){
            Console.WriteLine("O animal sortado foi Cavalo");
           }
            static void elephante(){
            Console.WriteLine("O animal sortado foi Elefante");
           }
            static void galooo(){
            Console.WriteLine("O animal sortado foi Galo");
           }
            static void cat(){
            Console.WriteLine("O animal sortado foi Gato");
           }
            static void jacaree(){
            Console.WriteLine("O animal sortado foi Jacaré");
           }
            static void lion(){
            Console.WriteLine("O animal sortado foi Leão");
           }
            static void monkey (){
            Console.WriteLine("O animal sortado foi Macaco");
           }
            static void pig(){
            Console.WriteLine("O animal sortado foi Porco");
           }
            static void pavon(){
            Console.WriteLine("O animal sortado foi pavão");
           }
            static void peru(){
            Console.WriteLine("O animal sortado foi peru");
           }
            static void tour(){
            Console.WriteLine("O animal sortado foi touro");
           }
            static void tiger (){
            Console.WriteLine("O animal sortado foi tigre");
           }
            static void bear(){
            Console.WriteLine("O animal sortado foi urso");
           }
            static void veadoa(){
            Console.WriteLine("O animal sortado foi veado");
           }
            static void Vaca(){
            Console.WriteLine("O animal sortado foi vaca");
           }


           

            }   

    }
}

           
/*  



    AVESTRUZ	01 – 02 – 03 – 04
	ÁGUIA	05 – 06 – 07 – 08
	BURRO	09 – 10 – 11 – 12
	BORBOLETA	13 – 14 – 15 – 16
	CACHORRO	17 – 18 – 19 – 20
	CABRA	21 – 22 – 23 – 247	
    CARNEIRO	25 – 26 – 27 – 28
	CAMELO	29 – 30 – 31 – 32
	COBRA	33 – 34 – 35 – 36
	COELHO	37 – 38 – 39 – 40
	CAVALO	 41 – 42 – 43 – 44
	ELEFANTE 45 – 46 – 47 – 48
	GALO	49 – 50 – 51 – 52
	GATO	53 – 54 – 55 – 56
	JACARÉ	57 – 58 – 59 – 60
	LEÃO	61 – 62 – 63 – 64
	MACACO	65 – 66 – 67 – 68
	PORCO	69 – 70 – 71 – 72
	PAVÃO	73 – 74 – 75 – 76
	PERU	77 – 78 – 79 – 80
	TOURO	81 – 82 – 83 – 84
   TIGRE	85 – 86 – 87 – 88
	URSO	89 – 90 – 91 – 92
	VEADO	93 – 94 – 95 – 96
	VACA	97 – 98 – 99 – 100




*/
            

         

            

   

        

    

    
