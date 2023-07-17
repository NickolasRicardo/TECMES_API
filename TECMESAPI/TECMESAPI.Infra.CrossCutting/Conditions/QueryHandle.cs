namespace TECMESAPI.CrossCutting.Conditions
{
    public static class QueryHandle
    {
        public static string SortingHandling(string sort)
        {
            string expressionSorted = string.Empty;

            string[] array = sort.Split(',');

            foreach (var item in array)
            {
                var value = item.Trim();

                if (value.StartsWith('-'))
                    expressionSorted += string.Concat(value.AsSpan(1), " DESC,");
                else
                {
                    if (value.StartsWith('+'))
                        expressionSorted += string.Concat(value.AsSpan(1), " ASC,");
                    else
                        expressionSorted += string.Concat(value, " ASC,");
                }
            }

            expressionSorted = expressionSorted.TrimEnd(',');

            return expressionSorted;
        }

        public static bool SortingValidate(string sort)
        {
            if(string.IsNullOrEmpty(sort))
                return false;

            if (sort.Count() == 1)
                return false;

            return true;
        }


    }
}
