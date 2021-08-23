using green_mage.command;

namespace green_mage.input {
    public interface GreenMageActionPlayerInput {
        /// <summary>
        /// ƒnƒ“ƒhƒ‰
        /// </summary>
        /// <returns></returns>
        public green_mage.command.GreenMageActionCommand InputHandler();
    }

    delegate green_mage.command.GreenMageActionCommand CreateCommand();
    class CommandFunc {
        //! —Dæ“x
        public int priority = 0;
        public CreateCommand func = null;

        public CommandFunc(int priority, CreateCommand func) {
            this.priority = priority;
            this.func = func;
        }
    }
}