Public Interface IConnection
    ReadOnly Property IsDBConnected() As Boolean
    Function OpenConnection()
    Sub CloseConnection()
End Interface
