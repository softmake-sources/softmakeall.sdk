﻿namespace SoftmakeAll.SDK.Fluent.Authentication
{
  public interface ICredentials
  {
    #region Properties
    internal System.Guid ContextIdentifier { get; set; }
    internal System.String ClientID { get; set; }
    internal System.String ClientSecret { get; set; }
    internal System.Char AuthType { get; set; }
    internal System.String Authorization { get; set; }
    #endregion

    #region Methods
    internal void Store();
    internal void Delete();
    #endregion
  }
}