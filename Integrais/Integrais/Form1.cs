using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;
using OxyPlot;
using OxyPlot.Series;

namespace Integrais {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            DesenhaGrafico();
        }

        class DadosGauss {
            public static double[] wConst2   = { 1.0000000000000000000000000, 1.0000000000000000000000000};
            public static double[] tConst2   = {-0.5773502691896257645091488, 0.5773502691896257645091488};
            public static double[] wConst4   = { 0.3478548451374538573730639, 0.6521451548625461426269361, 0.6521451548625461426269361, 0.3478548451374538573730639};
            public static double[] tConst4   = {-0.8611363115940525752239465,-0.3399810435848562648026658, 0.3399810435848562648026658, 0.8611363115940525752239465};
            public static double[] wConst8   = { 0.1012285362903762591525314, 0.2223810344533744705443560, 0.3137066458778872873379622, 0.3626837833783619829651504, 0.3626837833783619829651504, 0.3137066458778872873379622, 0.2223810344533744705443560, 0.1012285362903762591525314};
            public static double[] tConst8   = {-0.9602898564975362316835609,-0.7966664774136267395915539,-0.5255324099163289858177390,-0.1834346424956498049394761, 0.1834346424956498049394761, 0.5255324099163289858177390, 0.7966664774136267395915539, 0.9602898564975362316835609};
            public static double[] wConst16  = { 0.0271524594117540948517806, 0.0622535239386478928628438, 0.0951585116824927848099251, 0.1246289712555338720524763, 0.1495959888165767320815017, 0.1691565193950025381893121, 0.1826034150449235888667637, 0.1894506104550684962853967, 0.1894506104550684962853967, 0.1826034150449235888667637, 0.1691565193950025381893121, 0.1495959888165767320815017, 0.1246289712555338720524763, 0.0951585116824927848099251, 0.0622535239386478928628438, 0.0271524594117540948517806};
            public static double[] tConst16  = {-0.9894009349916499325961542,-0.9445750230732325760779884,-0.8656312023878317438804679,-0.7554044083550030338951012,-0.6178762444026437484466718,-0.4580167776572273863424194,-0.2816035507792589132304605,-0.0950125098376374401853193, 0.0950125098376374401853193, 0.2816035507792589132304605, 0.4580167776572273863424194, 0.6178762444026437484466718, 0.7554044083550030338951012, 0.8656312023878317438804679, 0.9445750230732325760779884, 0.9894009349916499325961542};
            public static double[] wConst32  = { 0.0070186100094700966004071, 0.0162743947309056706051706, 0.0253920653092620594557526, 0.0342738629130214331026877, 0.0428358980222266806568786, 0.0509980592623761761961632, 0.0586840934785355471452836, 0.0658222227763618468376501, 0.0723457941088485062253994, 0.0781938957870703064717409, 0.0833119242269467552221991, 0.0876520930044038111427715, 0.0911738786957638847128686, 0.0938443990808045656391802, 0.0956387200792748594190820, 0.0965400885147278005667648, 0.0965400885147278005667648, 0.0956387200792748594190820, 0.0938443990808045656391802, 0.0911738786957638847128686, 0.0876520930044038111427715, 0.0833119242269467552221991, 0.0781938957870703064717409, 0.0723457941088485062253994, 0.0658222227763618468376501, 0.0586840934785355471452836, 0.0509980592623761761961632, 0.0428358980222266806568786, 0.0342738629130214331026877, 0.0253920653092620594557526, 0.0162743947309056706051706, 0.0070186100094700966004071};
            public static double[] tConst32  = {-0.9972638618494815635449811,-0.9856115115452683354001750,-0.9647622555875064307738119,-0.9349060759377396891709191,-0.8963211557660521239653072,-0.8493676137325699701336930,-0.7944837959679424069630973,-0.7321821187402896803874267,-0.6630442669302152009751152,-0.5877157572407623290407455,-0.5068999089322293900237475,-0.4213512761306353453641194,-0.3318686022821276497799168,-0.2392873622521370745446032,-0.1444719615827964934851864,-0.0483076656877383162348126, 0.0483076656877383162348126, 0.1444719615827964934851864, 0.2392873622521370745446032, 0.3318686022821276497799168, 0.4213512761306353453641194, 0.5068999089322293900237475, 0.5877157572407623290407455, 0.6630442669302152009751152, 0.7321821187402896803874267, 0.7944837959679424069630973, 0.8493676137325699701336930, 0.8963211557660521239653072, 0.9349060759377396891709191, 0.9647622555875064307738119, 0.9856115115452683354001750, 0.9972638618494815635449811};
            public static double[] wConst64  = { 0.0017832807216964329472961, 0.0041470332605624676352875, 0.0065044579689783628561174, 0.0088467598263639477230309, 0.0111681394601311288185905, 0.0134630478967186425980608, 0.0157260304760247193219660, 0.0179517157756973430850453, 0.0201348231535302093723403, 0.0222701738083832541592983, 0.0243527025687108733381776, 0.0263774697150546586716918, 0.0283396726142594832275113, 0.0302346570724024788679741, 0.0320579283548515535854675, 0.0338051618371416093915655, 0.0354722132568823838106931, 0.0370551285402400460404151, 0.0385501531786156291289625, 0.0399537411327203413866569, 0.0412625632426235286101563, 0.0424735151236535890073398, 0.0435837245293234533768279, 0.0445905581637565630601347, 0.0454916279274181444797710, 0.0462847965813144172959532, 0.0469681828162100173253263, 0.0475401657148303086622822, 0.0479993885964583077281262, 0.0483447622348029571697695, 0.0485754674415034269347991, 0.0486909570091397203833654, 0.0486909570091397203833654, 0.0485754674415034269347991, 0.0483447622348029571697695, 0.0479993885964583077281262, 0.0475401657148303086622822, 0.0469681828162100173253263, 0.0462847965813144172959532, 0.0454916279274181444797710, 0.0445905581637565630601347, 0.0435837245293234533768279, 0.0424735151236535890073398, 0.0412625632426235286101563, 0.0399537411327203413866569, 0.0385501531786156291289625, 0.0370551285402400460404151, 0.0354722132568823838106931, 0.0338051618371416093915655, 0.0320579283548515535854675, 0.0302346570724024788679741, 0.0283396726142594832275113, 0.0263774697150546586716918, 0.0243527025687108733381776, 0.0222701738083832541592983, 0.0201348231535302093723403, 0.0179517157756973430850453, 0.0157260304760247193219660, 0.0134630478967186425980608, 0.0111681394601311288185905, 0.0088467598263639477230309, 0.0065044579689783628561174, 0.0041470332605624676352875, 0.0017832807216964329472961};
            public static double[] tConst64  = {-0.9993050417357721394569056,-0.9963401167719552793469245,-0.9910133714767443207393824,-0.9833362538846259569312993,-0.9733268277899109637418535,-0.9610087996520537189186141,-0.9464113748584028160624815,-0.9295691721319395758214902,-0.9105221370785028057563807,-0.8893154459951141058534040,-0.8659993981540928197607834,-0.8406292962525803627516915,-0.8132653151227975597419233,-0.7839723589433414076102205,-0.7528199072605318966118638,-0.7198818501716108268489402,-0.6852363130542332425635584,-0.6489654712546573398577612,-0.6111553551723932502488530,-0.5718956462026340342838781,-0.5312794640198945456580139,-0.4894031457070529574785263,-0.4463660172534640879849477,-0.4022701579639916036957668,-0.3572201583376681159504426,-0.3113228719902109561575127,-0.2646871622087674163739642,-0.2174236437400070841496487,-0.1696444204239928180373136,-0.1214628192961205544703765,-0.0729931217877990394495429,-0.0243502926634244325089558, 0.0243502926634244325089558, 0.0729931217877990394495429, 0.1214628192961205544703765, 0.1696444204239928180373136, 0.2174236437400070841496487, 0.2646871622087674163739642, 0.3113228719902109561575127, 0.3572201583376681159504426, 0.4022701579639916036957668, 0.4463660172534640879849477, 0.4894031457070529574785263, 0.5312794640198945456580139, 0.5718956462026340342838781, 0.6111553551723932502488530, 0.6489654712546573398577612, 0.6852363130542332425635584, 0.7198818501716108268489402, 0.7528199072605318966118638, 0.7839723589433414076102205, 0.8132653151227975597419233, 0.8406292962525803627516915, 0.8659993981540928197607834, 0.8893154459951141058534040, 0.9105221370785028057563807, 0.9295691721319395758214902, 0.9464113748584028160624815, 0.9610087996520537189186141, 0.9733268277899109637418535, 0.9833362538846259569312993, 0.9910133714767443207393824, 0.9963401167719552793469245, 0.9993050417357721394569056};
            public static double[] wConst100 = { 0.0007346344905056717304063, 0.0017093926535181052395294, 0.0026839253715534824194396, 0.0036559612013263751823425, 0.0046244500634221193510958, 0.0055884280038655151572119, 0.0065469484508453227641521, 0.0074990732554647115788287, 0.0084438714696689714026208, 0.0093804196536944579514182, 0.0103078025748689695857821, 0.0112251140231859771172216, 0.0121314576629794974077448, 0.0130259478929715422855586, 0.0139077107037187726879541, 0.0147758845274413017688800, 0.0156296210775460027239369, 0.0164680861761452126431050, 0.0172904605683235824393442, 0.0180959407221281166643908, 0.0188837396133749045529412, 0.0196530874944353058653815, 0.0204032326462094327668389, 0.0211334421125276415426723, 0.0218430024162473863139537, 0.0225312202563362727017970, 0.0231974231852541216224889, 0.0238409602659682059625604, 0.0244612027079570527199750, 0.0250575444815795897037642, 0.0256294029102081160756420, 0.0261762192395456763423087, 0.0266974591835709626603847, 0.0271926134465768801364916, 0.0276611982207923882942042, 0.0281027556591011733176483, 0.0285168543223950979909368, 0.0289030896011252031348762, 0.0292610841106382766201190, 0.0295904880599126425117545, 0.0298909795933328309168368, 0.0301622651051691449190687, 0.0304040795264548200165079, 0.0306161865839804484964594, 0.0307983790311525904277139, 0.0309504788504909882340635, 0.0310723374275665165878102, 0.0311638356962099067838183, 0.0312248842548493577323765, 0.0312554234538633569476425, 0.0312554234538633569476425, 0.0312248842548493577323765, 0.0311638356962099067838183, 0.0310723374275665165878102, 0.0309504788504909882340635, 0.0307983790311525904277139, 0.0306161865839804484964594, 0.0304040795264548200165079, 0.0301622651051691449190687, 0.0298909795933328309168368, 0.0295904880599126425117545, 0.0292610841106382766201190, 0.0289030896011252031348762, 0.0285168543223950979909368, 0.0281027556591011733176483, 0.0276611982207923882942042, 0.0271926134465768801364916, 0.0266974591835709626603847, 0.0261762192395456763423087, 0.0256294029102081160756420, 0.0250575444815795897037642, 0.0244612027079570527199750, 0.0238409602659682059625604, 0.0231974231852541216224889, 0.0225312202563362727017970, 0.0218430024162473863139537, 0.0211334421125276415426723, 0.0204032326462094327668389, 0.0196530874944353058653815, 0.0188837396133749045529412, 0.0180959407221281166643908, 0.0172904605683235824393442, 0.0164680861761452126431050, 0.0156296210775460027239369, 0.0147758845274413017688800, 0.0139077107037187726879541, 0.0130259478929715422855586, 0.0121314576629794974077448, 0.0112251140231859771172216, 0.0103078025748689695857821, 0.0093804196536944579514182, 0.0084438714696689714026208, 0.0074990732554647115788287, 0.0065469484508453227641521, 0.0055884280038655151572119, 0.0046244500634221193510958, 0.0036559612013263751823425, 0.0026839253715534824194396, 0.0017093926535181052395294, 0.0007346344905056717304063};
            public static double[] tConst100 = {-0.9997137267734412336782285,-0.9984919506395958184001634,-0.9962951347331251491861317,-0.9931249370374434596520099,-0.9889843952429917480044187,-0.9838775407060570154961002,-0.9778093584869182885537811,-0.9707857757637063319308979,-0.9628136542558155272936593,-0.9539007829254917428493369,-0.9440558701362559779627747,-0.9332885350430795459243337,-0.9216092981453339526669513,-0.9090295709825296904671263,-0.8955616449707269866985210,-0.8812186793850184155733168,-0.8660146884971646234107400,-0.8499645278795912842933626,-0.8330838798884008235429158,-0.8153892383391762543939888,-0.7968978923903144763895729,-0.7776279096494954756275514,-0.7575981185197071760356680,-0.7368280898020207055124277,-0.7153381175730564464599671,-0.6931491993558019659486479,-0.6702830156031410158025870,-0.6467619085141292798326303,-0.6226088602037077716041908,-0.5978474702471787212648065,-0.5725019326213811913168704,-0.5465970120650941674679943,-0.5201580198817630566468157,-0.4932107892081909335693088,-0.4657816497733580422492166,-0.4378974021720315131089780,-0.4095852916783015425288684,-0.3808729816246299567633625,-0.3517885263724217209723438,-0.3223603439005291517224766,-0.2926171880384719647375559,-0.2625881203715034791689293,-0.2323024818449739696495100,-0.2017898640957359972360489,-0.1710800805386032748875324,-0.1402031372361139732075146,-0.1091892035800611150034260,-0.0780685828134366366948174,-0.0468716824215916316149239,-0.0156289844215430828722167, 0.0156289844215430828722167, 0.0468716824215916316149239, 0.0780685828134366366948174, 0.1091892035800611150034260, 0.1402031372361139732075146, 0.1710800805386032748875324, 0.2017898640957359972360489, 0.2323024818449739696495100, 0.2625881203715034791689293, 0.2926171880384719647375559, 0.3223603439005291517224766, 0.3517885263724217209723438, 0.3808729816246299567633625, 0.4095852916783015425288684, 0.4378974021720315131089780, 0.4657816497733580422492166, 0.4932107892081909335693088, 0.5201580198817630566468157, 0.5465970120650941674679943, 0.5725019326213811913168704, 0.5978474702471787212648065, 0.6226088602037077716041908, 0.6467619085141292798326303, 0.6702830156031410158025870, 0.6931491993558019659486479, 0.7153381175730564464599671, 0.7368280898020207055124277, 0.7575981185197071760356680, 0.7776279096494954756275514, 0.7968978923903144763895729, 0.8153892383391762543939888, 0.8330838798884008235429158, 0.8499645278795912842933626, 0.8660146884971646234107400, 0.8812186793850184155733168, 0.8955616449707269866985210, 0.9090295709825296904671263, 0.9216092981453339526669513, 0.9332885350430795459243337, 0.9440558701362559779627747, 0.9539007829254917428493369, 0.9628136542558155272936593, 0.9707857757637063319308979, 0.9778093584869182885537811, 0.9838775407060570154961002, 0.9889843952429917480044187, 0.9931249370374434596520099, 0.9962951347331251491861317, 0.9984919506395958184001634, 0.9997137267734412336782285};
        }

        private void Form1_Load(object sender, EventArgs e) {
            CarregaDataGridViewSolucao();
        }

        void CarregaDataGridViewSolucao() {
            dataGridViewSolucao.Rows.Clear();
            dataGridViewSolucao.Rows.Add(6);

            dataGridViewSolucao.Rows[0].Cells[0].Value = "Retângulos à Esquerda";
            dataGridViewSolucao.Rows[1].Cells[0].Value = "Retângulos à Direita";
            dataGridViewSolucao.Rows[2].Cells[0].Value = "Regra dos Trapézios";
            dataGridViewSolucao.Rows[3].Cells[0].Value = "Regra 1/3 de Simpson";
            dataGridViewSolucao.Rows[4].Cells[0].Value = "Regra 3/8 de Simpson";
            dataGridViewSolucao.Rows[5].Cells[0].Value = "Regra de Gauss";
        }

        void DesenhaGrafico() {
            PlotController plotControles = new PlotController();
            PlotModel grafico = new PlotModel();
            plotControles.UnbindAll();

            var areaSeries = new AreaSeries(){
                StrokeThickness = 1,
                LineStyle = OxyPlot.LineStyle.Solid,
                Color = OxyColors.Black,
                Color2 = OxyColors.Transparent,
                Fill = OxyColor.FromRgb(153, 231, 242)
            };

            grafico.Series.Add(areaSeries);

            ////Assign PlotModel to PlotView
            plotView.Model = grafico;
            plotView.Controller = plotControles;
        }

        void DesenhaGrafico(Function f, double a, double b, int n) {
            int i;
            double x_, fx, passo;

            PlotController plotControles = new PlotController();
            PlotModel grafico = new PlotModel();

            Func<double, double> funcao = (x) => f.calculate(x);

            plotControles.UnbindAll();



            grafico.Series.Add(new FunctionSeries(funcao, a, b, (b - a) / n, "Função") {
                Color = OxyColors.Black,
                StrokeThickness = 2,
                LineStyle = OxyPlot.LineStyle.Solid
            });

            var areaSeries = new AreaSeries(){
                Title = "Área",
                StrokeThickness = 1,
                LineStyle = OxyPlot.LineStyle.Solid,
                Color = OxyColors.Black,
                Color2 = OxyColors.Transparent,
                Fill = OxyColor.FromRgb(153, 231, 242)
            };

            passo = (b - a) / n;
            for (i = 0; i <= n; i++) {
                x_ = a + i * passo;

                fx = f.calculate(x_);

                if (double.IsNaN(fx) || double.IsInfinity(fx))
                    fx = 0;

                areaSeries.Points.Add(new DataPoint(x_, fx));
            }

            grafico.Series.Add(areaSeries);

            ////Assign PlotModel to PlotView
            plotView.Model = grafico;
            plotView.Controller = plotControles;
        }

        double RetanguloEsquerda(Function f, double a, double b, int n) {
            int i;
            double h, fx, soma, integral;

            soma = 0;
            h = (b - a) / n;

            for (i = 0; i <= n-1; i++) {
                fx = f.calculate(a + i * h);

                // caso não seja possível calcular fx, atribui 0 (zero) para fx
                if (double.IsNaN(fx) || double.IsInfinity(fx))
                    fx = 0;

                soma += fx;
            }

            integral = soma * h;

            return integral;
        }

        double RetanguloDireita(Function f, double a, double b, int n) {
            int i;
            double h, fx, soma, integral;

            soma = 0;
            h = (b - a) / n;

            for (i = 1; i <= n; i++) {
                fx = f.calculate(a + i * h);

                // caso não seja possível calcular fx, atribui 0 (zero) para fx
                if (double.IsNaN(fx) || double.IsInfinity(fx))
                    fx = 0;

                soma += fx;
            }

            integral = soma * h;

            return integral;
        }

        double Trapezios(Function f, double a, double b, int n) {
            int i;
            double h, fa, fb, fx, soma, integral;

            fa = f.calculate(a);
            // caso não seja possível calcular fa, atribui 0 (zero) para fa
            if (double.IsNaN(fa) || double.IsInfinity(fa))
                fa = 0;

            fb = f.calculate(b);
            // caso não seja possível calcular fb, atribui 0 (zero) para fb
            if (double.IsNaN(fb) || double.IsInfinity(fb))
                fb = 0;

            h = (b - a) / n;
            soma = (fa + fb) / 2;

            for (i = 1; i <= n-1; i++) {
                fx = f.calculate(a + i * h);

                // caso não seja possível calcular fx, atribui 0 (zero) para fx
                if (double.IsNaN(fx) || double.IsInfinity(fx))
                    fx = 0;

                soma += fx;
            }

            integral = soma * h;

            return integral;
        }

        double Simpson13(Function f, double a, double b, int n) {
            int i;
            double h, fa, fb, fx, somaM4, somaM2, somaFaltante, integral;
            // somaM4, soma dos indices impares que serão multiplicados por 4
            // somaM2, soma dos indices pares que serão multiplicados por 2
            // somaFaltante, para quando n não for divisivel por 2

            fa = f.calculate(a);
            // caso não seja possível calcular fa, atribui 0 (zero) para fa
            if (double.IsNaN(fa) || double.IsInfinity(fa))
                fa = 0;

            fb = f.calculate(b);
            // caso não seja possível calcular fb, atribui 0 (zero) para fb
            if (double.IsNaN(fb) || double.IsInfinity(fb))
                fb = 0;

            h = (b - a) / n;
            somaM4 = 0; somaM2 = 0; somaFaltante = 0;

            if (n % 2 == 1) {
                somaFaltante = Trapezios(f, b - h, b, 1);
                n--;
            }
            
            // indices impares
            for (i = 1; i <= n/2; i++) {
                fx = f.calculate(a + (2*i-1) * h);

                // caso não seja possível calcular fx, atribui 0 (zero) para fx
                if (double.IsNaN(fx) || double.IsInfinity(fx))
                    fx = 0;

                somaM4 += fx;
            }

            // indices pares
            for (i = 1; i <= n/2-1; i++) {
                fx = f.calculate(a + (2 * i) * h);

                // caso não seja possível calcular fx, atribui 0 (zero) para fx
                if (double.IsNaN(fx) || double.IsInfinity(fx))
                    fx = 0;

                somaM2 += fx;
            }

            integral = h * (fa + fb + 4 * somaM4 + 2 * somaM2) / 3 + somaFaltante;

            return integral;
        }

        double Simpson38(Function f, double a, double b, int n) {
            int i;
            double h, fa, fb, fx, somaM3, somaM2, somaFaltante, integral;
            // somaM4, soma dos indices multiplos de 3 que serão multiplicados por 3
            // somaM2, soma dos indices não multiplos de 3 que serão multiplicados por 2
            // somaFaltante, para quando n não for divisível por 3

            fa = f.calculate(a);

            // caso não seja possível calcular fa, atribui 0 (zero) para fa
            if (double.IsNaN(fa) || double.IsInfinity(fa))
                fa = 0;

            fb = f.calculate(b);

            // caso não seja possível calcular fb, atribui 0 (zero) para fb
            if (double.IsNaN(fb) || double.IsInfinity(fb))
                fb = 0;

            h = (b - a) / n;
            somaM3 = 0; somaM2 = 0; somaFaltante = 0;

            // caso o resto de n por 3 seja 1
            // calcula o trapezio na ultima faixa
            if (n % 3 == 1) {
                somaFaltante = Trapezios(f, b - h, b, 1);
                n--;
            }
            else if (n % 3 == 2) {
                somaFaltante = Simpson13(f, b - 2 * h, b, 2);
                n -= 2;
            }

            // indices não multiplos de 3
            for (i = 1; i <= n / 3; i++) {
                fx = f.calculate(a + (3 * i - 2) * h);

                // caso não seja possível calcular fx, atribui 0 (zero) para fx
                if (double.IsNaN(fx) || double.IsInfinity(fx))
                    fx = 0;

                somaM3 += fx;

                fx = f.calculate(a + (3 * i - 1) * h);

                // caso não seja possível calcular fx, atribui 0 (zero) para fx
                if (double.IsNaN(fx) || double.IsInfinity(fx))
                    fx = 0;

                somaM3 += fx;
            }

            // indices multiplos de 3
            for (i = 1; i <= n / 3 - 1; i++) {
                fx = f.calculate(a + (3 * i) * h);

                // caso não seja possível calcular fx, atribui 0 (zero) para fx
                if (double.IsNaN(fx) || double.IsInfinity(fx))
                    fx = 0;

                somaM2 += fx;
            }

            integral = 3 * h * (fa + fb + 3 * somaM3 + 2 * somaM2) / 8 + somaFaltante;

            return integral;
        }

        int NumerodePontosSelecionado() {
            if (radioButtonNumPontos2.Checked)
                return 2;
            else if (radioButtonNumPontos4.Checked)
                return 4;
            else if (radioButtonNumPontos8.Checked)
                return 8;
            else if (radioButtonNumPontos16.Checked)
                return 16;
            else if (radioButtonNumPontos32.Checked)
                return 32;
            else if (radioButtonNumPontos64.Checked)
                return 64;
            else
                return 100;
        }

        double RegraGauss(Function f, double a, double b, int n) {
            int i;
            double x, fx, soma, integral;
            double[] w, t;

            w = new double[n];
            t = new double[n];
            if (n == 2) {
                Array.Copy(DadosGauss.wConst2, w, n);
                Array.Copy(DadosGauss.tConst2, t, n);
            }
            else if (n == 4) {
                Array.Copy(DadosGauss.wConst4, w, n);
                Array.Copy(DadosGauss.tConst4, t, n);
            }
            else if (n == 8) {
                Array.Copy(DadosGauss.wConst8, w, n);
                Array.Copy(DadosGauss.tConst8, t, n);
            }
            else if (n == 16) {
                Array.Copy(DadosGauss.wConst16, w, n);
                Array.Copy(DadosGauss.tConst16, t, n);
            }
            else if (n == 32) {
                Array.Copy(DadosGauss.wConst32, w, n);
                Array.Copy(DadosGauss.tConst32, t, n);
            }
            else if (n == 64) {
                Array.Copy(DadosGauss.wConst64, w, n);
                Array.Copy(DadosGauss.tConst64, t, n);
            }
            else {
                Array.Copy(DadosGauss.wConst100, w, n);
                Array.Copy(DadosGauss.tConst100, t, n);
            }
            
            soma = 0;
            for (i = 0; i < n; i++) {
                x = (a * (1 - t[i]) + b * (1 + t[i])) / 2;

                fx = f.calculate(x);

                // caso não seja possível calcular fx, atribui 0 (zero) para fx
                if (double.IsNaN(fx) || double.IsInfinity(fx))
                    fx = 0;

                soma += w[i] * fx;
            }

            integral = (b - a) * soma / 2;

            return integral;
        }

        private void buttonCalcula_Click(object sender, EventArgs e) {
            string expressao;
            int n;
            double a, b, solucao;
            Function f;

            expressao = textBoxFuncao.Text.Replace(',', '.');
            if (String.IsNullOrWhiteSpace(expressao)) {
                MessageBox.Show("Função não informada.", "Integrais Numéricas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFuncao.Focus();
                return;
            }

            f = new Function("f(x) = " + expressao);

            if (f.checkSyntax() == false) {
                MessageBox.Show("Verifique a sintaxe da função informada.", "Integrais Numéricas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFuncao.Focus();
                return;
            }

            try {
                a = double.Parse(textBoxValorA.Text.Replace('.', ','));
            }
            catch (Exception) {
                MessageBox.Show("Digite um valor válido para a.", "Integrais Numéricas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxValorA.Focus();
                return;
            }

            try {
                b = double.Parse(textBoxValorB.Text.Replace('.', ','));
            } catch (Exception) {
                MessageBox.Show("Digite um valor válido para b.", "Integrais Numéricas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxValorB.Focus();
                return;
            }

            if (b <= a) {
                MessageBox.Show("Valor de a deve ser menor que valor de b.", "Integrais Numéricas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxValorA.Focus();
                return;
            }

            // como é um numericUpDown, não deve acontecer erro
            // mas por garantia foi feito um try-catch
            try {
                n = int.Parse(NumeroPontos.Value.ToString());
            } catch (Exception erro) {
                MessageBox.Show("Erro interno ao ler número de pontos.\n\nErro: " + erro.ToString(), "Integrais Numéricas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NumeroPontos.Focus();
                return;
            }

            solucao = RetanguloEsquerda(f, a, b, n);
            dataGridViewSolucao.Rows[0].Cells[1].Value = solucao;
            solucao = RetanguloDireita(f, a, b, n);
            dataGridViewSolucao.Rows[1].Cells[1].Value = solucao; 
            solucao = Trapezios(f, a, b, n);
            dataGridViewSolucao.Rows[2].Cells[1].Value = solucao;
            solucao = Simpson13(f, a, b, n);
            dataGridViewSolucao.Rows[3].Cells[1].Value = solucao;
            solucao = Simpson38(f, a, b, n);
            dataGridViewSolucao.Rows[4].Cells[1].Value = solucao;
            solucao = RegraGauss(f, a, b, NumerodePontosSelecionado());
            dataGridViewSolucao.Rows[5].Cells[1].Value = solucao;

            DesenhaGrafico(f, a, b, n);
        }

        private void buttonLimpa_Click(object sender, EventArgs e) {
            textBoxFuncao.Clear();
            textBoxValorA.Clear();
            textBoxValorB.Clear();
            NumeroPontos.Value = 20;
            radioButtonNumPontos8.Checked = true;
            CarregaDataGridViewSolucao();
            DesenhaGrafico();
        }
    }
}
