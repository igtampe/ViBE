﻿Imports VIBE__But_on_Visual_Studio_.ServerCommand

''' <summary>
''' Checkbook 2000 Extension Commands
''' </summary>
Public Class CheckbookCommands

    ''' <summary>
    ''' Read All Checks from the specified user
    ''' </summary>
    ''' <param name="ID"> ID of the user u want to read</param>
    Public Shared Function ReadChecks(ID As String) As String
        'CHCKBKREAD57174
        Return RawCommand("CHCKBKREAD" + ID)
    End Function

    ''' <summary>
    ''' Removes a Check
    ''' </summary>
    ''' <param name="ID">ID of the user</param>
    ''' <param name="Index">Check you want to remove</param>
    Public Shared Function RemoCheck(ID As String, Index As Integer) As String
        'CHKBKREMO5717410
        Return RawCommand("CHCKBKREMO" & ID & Index)
    End Function

    ''' <summary>
    ''' Adds a Check
    ''' </summary>
    ''' <param name="CHCKMSG"></param>    
    Public Shared Function AddCheck(Destination As String, Type As Integer, Time As String, Name As String, Bank As String, Amount As Long, Subtype As Integer, Comment As String) As String
        ''CHKBKADD(uh nose)
        Return RawCommand("CHCKBKADD" & Destination & Type & "`" & Time & "`" & Name & "`" & Bank & "`" & Amount & "`::" & Subtype & "::" & Comment)
    End Function

End Class