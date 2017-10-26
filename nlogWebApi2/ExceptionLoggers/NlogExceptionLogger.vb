Imports System.Net.Http
Imports System.Web.Http.ExceptionHandling
Imports NLog

Public Class NlogExceptionLogger
    Inherits ExceptionLogger

    Private Shared ReadOnly Property logger As Logger
        Get
            Return LogManager.GetCurrentClassLogger()
        End Get
    End Property

    Public Overrides Sub Log(context As ExceptionLoggerContext)
        MyBase.Log(context)
        logger.Log(LogLevel.Error, context.Exception, getRequest(context.Request))
    End Sub

    Private Function getRequest(request As HttpRequestMessage) As String
        Dim result As New StringBuilder(String.Empty)

        ' TODO NullRef check request.Method, and append to result.

        ' TODO NullRef check request.RequestUri, and append to result.

        ' TODO --- Following need to be considered for sensitive info/credentials.

        ' TODO NullRef check body and append to result.

        ' TODO NullRef check headers and append to result.

        Return result.ToString()
    End Function

End Class
