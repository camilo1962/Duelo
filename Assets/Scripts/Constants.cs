using System.Collections.Generic;

namespace Constants
{
    public class DATA
    {
        public const string CURRENT_LEVEL = "CURRENT_LEVEL";
        public const string SETTINGS_SOUND = "SETTINGS_SOUND";
        public static readonly List<string> START_MESSAGES = new()
        {
            " No parece difícil. No toques nada.",
            " Necesitarás un estado mental circular.",
            " Esto será fácil, sólo manténte a la izquierda.",
            " No seas capullo, no rendirse nunca.",
            " Algunas cosas por las que vale la pena luchar.",
            " Algunas cosas por las que vale la pena luchar.",

            " Esto estará lleno de giros inesperados.",
            " Anda con cuidado y controla. ",
            " Confía en tus instintos y ve relajado",
            " El cambio es normal.",
            " No te cagues.",
            " Abrázalo."
        };


    }

    public class AnimationNames
    {
        public const string MAINMENU_MENUPANEL_LEFT = "AN_MainMenu_MenuPanel_Left";
        public const string MAINMENU_MENUPANEL_RIGHT = "AN_MainMenu_MenuPanel_Right";
        public const string MAINMENU_LEVELPANEL_LEFT = "AN_MainMenu_LevelPanel_Left";
        public const string MAINMENU_LEVELPANEL_RIGHT = "AN_MainMenu_LevelPanel_Right";
        public const string GAME_TEXT_DEFAULT = "AN_Game_Text_Default";
    }


    public class Tags
    {
        public const string RESPAWN = "Respawn";
        public const string FINISH = "Finish";
    }
}