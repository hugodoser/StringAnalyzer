namespace Analyzer
{
    public enum Error
    {
        NoError,
        FunctionExpected,
        ProcedureExpected,
        ProcedureOrFunctionExpected,
        VarExpected,
        SpaceExpected,
        TypeExpected,
        DescriptionError,
        IdentifierLengthError,
        IdentifierFirstSymbolError,
        IdentifierIsReservedWordError,
        IdentifierError,
        UnknownError,
        OutOfRange,
        OpenBracketExpected,
        CloseBracketExpected,
        OpenBracketOrColonExpected,
        CloseBracketOrSemicolonExpected,
        ListOfIdentifiersError,
        ColonExpected,
        RealExpected,
        IntegerExpected,
        CharExpected,
        ByteExpected,
        DoubleExpected,
        StringExpected,
        BooleanExpected,
        IdentifierDuplicationError,
        OpenBracketOrSemicolonExpected,
        SemicolonExpected
    }

    public class Errors
    {
        private readonly int _errorPosition;
        private readonly Error _error;
        private string _string;

        public Errors(int errorPosition, Error error, string value)
        {
            this._errorPosition = errorPosition;
            this._error = error;
            this._string = value;
        }

        public int ErrorPosition
        {
            get => _errorPosition;
        }

        public string ErrorMessage
        {
            get
            {
                switch (_error)
                {
                    case Error.NoError: return "Ошибок нет";
                    case Error.FunctionExpected: return "Ожидалось слово FUNCTION";
                    case Error.ProcedureExpected: return "Ожидалось слово PROCEDURE";
                    case Error.ProcedureOrFunctionExpected: return "Ожидалось слово PROCEDURE или FUNCTION";
                    case Error.VarExpected: return "Ожидалось слово VAR";
                    case Error.SpaceExpected: return "Ожидался пробел";
                    case Error.TypeExpected: return "Ожидался тип";
                    case Error.IdentifierFirstSymbolError: return "Идентификатор начинается с недопустимого символа";
                    case Error.IdentifierIsReservedWordError: return "Идентификатор совпадает с зарезервированным словом";
                    case Error.IdentifierLengthError: return "Превышена длина идентификатора";
                    case Error.IdentifierError: return "Ошибка в записи идентификатора";
                    case Error.UnknownError: return "Неизвестная ошибка";
                    case Error.OutOfRange: return "Выход за границы анализируемой строки";
                    case Error.OpenBracketExpected: return "Ожидалась открывающаяся скобка";
                    case Error.CloseBracketExpected: return "Ожидалась закрывающаяся скобка";
                    case Error.OpenBracketOrColonExpected: return "Ожидалась открывающаяся скобка или двоеточие";
                    case Error.OpenBracketOrSemicolonExpected: return "Ожидалась открывающаяся скобка или точка с запятой";
                    case Error.CloseBracketOrSemicolonExpected: return "Ожидалась закрывающаяся скобка или точка с запятой";
                    case Error.SemicolonExpected: return "Ожидалась точка с запятой";
                    case Error.ListOfIdentifiersError: return "Ошибка в списке идентификаторов";
                    case Error.IdentifierDuplicationError: return "Встречено дублирование идентификаторов";
                    case Error.ColonExpected: return "Ожидалось двоеточие";
                    case Error.RealExpected: return "Ожидался тип REAL";
                    case Error.IntegerExpected: return "Ожидался тип INTEGER";
                    case Error.CharExpected: return "Ожидался тип CHAR";
                    case Error.ByteExpected: return "Ожидался тип BYTE";
                    case Error.DoubleExpected: return "Ожидался тип DOUBLE";
                    case Error.StringExpected: return "Ожидался тип STRING";
                    case Error.BooleanExpected: return "Ожидался тип BOOLEAN";
                    default: return "Неизвестная ошибка";
                }
            }
        }
    }
}