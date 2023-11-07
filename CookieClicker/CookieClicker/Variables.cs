using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    public static class Variables
    {
        // cookies
        private static int cookies = 0;
        private static int CPS = 0;
        

        // buildings
        private static int clickers = 0;
        private static int omas = 0;
        private static int boerderijen = 0;
        private static int mijnen = 0;
        private static int fabrieken = 0;
        private static int banken = 0;
        private static int tempels = 0;


        // can buy
        public static bool buy_click { get; set; }
        public static bool buy_oma { get; set; }
        public static bool buy_boerderij { get; set; }
        public static bool buy_mijn { get; set; }
        public static bool buy_fabriek { get; set; }
        public static bool buy_bank { get; set; }
        public static bool buy_tempel { get; set; }


        // builing - cookie
        public static int cookie
        {
            get { return cookies; }
            set { cookies = value; }
        }

        public static int cps
        {
            get { return CPS; }
            set { CPS = value; }
        }

        public static int clicker
        {
            get { return clickers; }
            set { clickers = value; }
        }

        public static int oma
        {
            get { return omas; }
            set { omas = value; }
        }

        public static int boerderij
        {
            get { return boerderijen; }
            set { boerderijen = value; }
        }

        public static int mijn
        {
            get { return mijnen; }
            set { mijnen = value; }
        }

        public static int fabriek
        {
            get { return fabrieken; }
            set { fabrieken = value; }
        }

        public static int bank
        {
            get { return banken; }
            set { banken = value; }
        }

        public static int tempel
        {
            get { return tempels; }
            set { tempels = value; }
        }



        // key press
        private static bool SpacebarPressed = false;

        public static bool SpacePress
        {
            get { return SpacebarPressed; }
            set { SpacebarPressed = value; }
        }

        private static bool ZPressed = false;

        public static bool ZPress
        {
            get { return ZPressed; }
            set { ZPressed = value; }
        }

        private static bool XPressed = false;

        public static bool XPress
        {
            get { return XPressed; }
            set { XPressed = value; }
        }

        private static bool CPressed = false;

        public static bool CPress
        {
            get { return CPressed; }
            set { CPressed = value; }
        }

        private static bool VPressed = false;

        public static bool VPress
        {
            get { return VPressed; }
            set { VPressed = value; }
        }

        private static bool BPressed = false;

        public static bool BPress
        {
            get { return BPressed; }
            set { BPressed = value; }
        }

        private static bool NPressed = false;

        public static bool NPress
        {
            get { return NPressed; }
            set { NPressed = value; }
        }

        private static bool MPressed = false;

        public static bool MPress
        {
            get { return MPressed; }
            set { MPressed = value; }
        }
    }
}
