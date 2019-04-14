using System;

namespace BoardGameTeka.Model
{
    [Serializable]
    public class BoardGameTekaBaseException : Exception
    {
    }

    #region Board game

    [Serializable]
    public class BoardGameDoesntExistsException : BoardGameTekaBaseException
    {
    }

    [Serializable]
    public class BoardGameInvalidNameException : BoardGameTekaBaseException
    {
    }

    [Serializable]
    public class BoardGameInvalidAvailableCopiesException : BoardGameTekaBaseException
    {
    }

    [Serializable]
    public class BoardGameMinPlayerGreaterOrEqualThanMaxPlayerException : BoardGameTekaBaseException
    {
    }

    [Serializable]
    public class BoardGameWithThatNameAlreadyExistsException : BoardGameTekaBaseException
    {
    }

    #endregion

    #region Member

    [Serializable]
    public class MemberDoesntExistsException : BoardGameTekaBaseException
    {
    }

    [Serializable]
    public class MemberInvalidNameException : BoardGameTekaBaseException
    {
    }

    [Serializable]
    public class MemberInvalidPhoneNumberException : BoardGameTekaBaseException
    {
    }

    [Serializable]
    public class MemberWithThatPhoneNumberExistsException : BoardGameTekaBaseException
    {
    }

    [Serializable]
    public class MemberWithThatNameExistsException : BoardGameTekaBaseException
    {
    }


    #endregion

    #region Rental

    [Serializable]
    public class RentalDoesntExistsException : BoardGameTekaBaseException
    {
    }

    [Serializable]
    public class RentalDateReturnedExistsWhileAddingNewRentalException : BoardGameTekaBaseException
    {
    }

    [Serializable]
    public class RentalMemberAlreadyHasARentalException : BoardGameTekaBaseException
    {
    }

    #endregion

    #region User/Employee

    [Serializable]
    public class UserDoesntExistsException : BoardGameTekaBaseException
    {
    }

    [Serializable]
    public class EmployeeDoesntExistsException : BoardGameTekaBaseException
    {
    }

    [Serializable]
    public class EmployeeInvalidUsernameException : BoardGameTekaBaseException
    {
    }

    [Serializable]
    public class EmployeeInvalidPasswordException : BoardGameTekaBaseException
    {
    }

    [Serializable]
    public class EmployeeRoleIsNotEmployeeException : BoardGameTekaBaseException
    {
    }

    [Serializable]
    public class EmployeeWithThatUsernameAlreadyExistsException : BoardGameTekaBaseException
    {
    }

    #endregion

}
