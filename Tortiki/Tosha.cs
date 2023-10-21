

namespace Tortik
{
    public class Tortiki
    {
        public string Form;
        public string Razmer;
        public string Vkyc;
        public string Korzh;
        public string Glaz;
        public string Dekor;

    }
    public class Vib
    {

        static Tortiki tort = new Tortiki();


        public static Tortiki Form(int chis)
        {
            switch (chis)
            {
                case 3:

                    tort.Form = "Круг - 500, ";
                    return tort;

                case 4:

                    tort.Form = "Квадрат - 500, ";
                    return tort;
                case 5:

                    tort.Form = "Прямоугольник - 500, ";
                    return tort;
                case 6:

                    tort.Form = "Сердце - 600, ";
                    return tort;
            }
            return tort;

        }
        public static Tortiki Razmer(int chis)
        {
            switch (chis)
            {
                case 3:
                    tort.Razmer = "Маленький (Деаметр - 10см, 8 порций) - 1000, ";
                    return tort;
                case 4:
                    tort.Razmer = "Средний (Деаметр - 15см, 12 порций) - 1200, ";
                    return tort;
                case 5:
                    tort.Razmer = "Большой (Деаметр - 28см, 24 порций) - 2000, ";
                    return tort;

            }
            return tort;
        }
        public static Tortiki Vkyc(int chis)
        {
            switch (chis)
            {
                case 3:
                    tort.Vkyc = "Ванильный - 100, ";
                    return tort;
                case 4:
                    tort.Vkyc = "Фисташка вишня - 150, ";
                    return tort;
                case 5:
                    tort.Vkyc = "Карамельный - 150, ";
                    return tort;
                case 6:
                    tort.Vkyc = "Ягодный - 200, ";
                    return tort;
                case 7:
                    tort.Vkyc = "Кокосовый - 250, ";
                    return tort;

            }
            return tort;
        }
        public static Tortiki Korzh(int chis)
        {
            switch (chis)
            {
                case 3:
                    tort.Korzh = "1 корж - 200, ";
                    return tort;
                case 4:
                    tort.Korzh = "2 коржа - 400, ";
                    return tort;
                case 5:
                    tort.Korzh = "3 коржа - 600, ";
                    return tort;
                case 6:
                    tort.Korzh = "4 коржа - 800, ";
                    return tort;
            }
            return tort;
        }
        public static Tortiki Glaz(int chis)
        {
            switch (chis)
            {
                case 3:
                    tort.Glaz = "Шоколад - 100, ";
                    return tort;
                case 4:
                    tort.Glaz = "Крем - 100, ";
                    return tort;
                case 5:
                    tort.Glaz = "Фундук - 150, ";
                    return tort;
                case 6:
                    tort.Glaz = "ОРЕО - 150, ";
                    return tort;
                case 7:
                    tort.Glaz = "Рафаэло - 200, ";
                    return tort;

            }
            return tort;
        }
        public static Tortiki Dekor(int chis)
        {
            switch (chis)
            {
                case 3:
                    tort.Dekor = "Ягодная - 150, ";
                    return tort;
                case 4:
                    tort.Dekor = "Белый шоколад - 150, ";
                    return tort;
                case 5:
                    tort.Dekor = "Молочная - 150, ";
                    return tort;
                case 6:
                    tort.Dekor = "Манго маракуя - 200, ";
                    return tort;
            }
            return tort;

        }
        public static Tortiki Nullik()
        {
            tort.Form = null;
            tort.Razmer = null;
            tort.Vkyc = null;
            tort.Korzh = null;
            tort.Glaz = null;
            tort.Dekor = null;


            return tort;
        }
    }
}



