namespace de.aweleczka.to.dev.dailychallenge195.lib
{
    public static class C195
    {

        /// <summary>
        /// Strip any trailing zeros from an integer
        /// </summary>
        /// <param name="input"></param>
        /// <returns>The input </returns>
        public static int StripTrailingZeros(this int input)
        {
            if(input != 0 && input % 10 == 0)
            {
                return (input / 10).StripTrailingZeros();
            }

            return input;
        }

    }
}
