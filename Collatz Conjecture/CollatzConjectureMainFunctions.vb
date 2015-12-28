Public Class CollatzConjectureMainFunctions
    Public Shared Rootnode As New Node

    Public Shared Sub FillRootnode(StartN As Integer, AmountOfNs As Integer)
        If StartN = 1 Then
            Dim NewRootNode As New Node
            NewRootNode.NodeValue = 1
            Rootnode = NewRootNode

        End If

        'Add all the steps from the stepsequences of the numbers StartN to AmountOfNs to the RootNode
        For I = StartN To StartN + AmountOfNs
            Dim PreviousStep As Integer = 0
            Dim PreviousNode As Node

            'Add all the steps to the rootnode

            For Each SequenceStep As Integer In ReverseStepsList(GenerateSequence(I))
                If PreviousStep = 0 Then
                    PreviousStep = SequenceStep
                    PreviousNode = Rootnode

                Else
                    Dim topnode = PreviousNode ' FindNode(PreviousStep, Rootnode)

                    'See if this step/relation already exists, if not add it.
                    Dim SubNodefound = False
                    For Each Node As Node In topnode.ListOutwardNodes
                        If Node.NodeValue = SequenceStep Then
                            SubNodefound = True
                            PreviousNode = Node
                            Exit For
                        End If
                    Next

                    If SubNodefound = False Then
                        Dim newSubnode As New Node
                        newSubnode.NodeValue = SequenceStep
                        topnode.ListOutwardNodes.Add(newSubnode)
                        PreviousNode = newSubnode
                    End If
                    PreviousStep = SequenceStep

                End If
            Next
        Next
    End Sub

    Public Shared Function ReverseStepsList(list As List(Of Integer)) As List(Of Integer)
        Dim Reversedlist As New List(Of Integer)
        For i = list.Count - 1 To 0 Step -1
            Reversedlist.Add(list(i))
        Next
        Return Reversedlist
    End Function

    Public Shared Function FindNode(IntValue As Integer, RootNode As Node) As Node
        If RootNode.NodeValue = IntValue Then
            Return RootNode
        End If

        For Each SubNode As Node In RootNode.ListOutwardNodes
            Dim FoundSubNode As Node = FindNode(IntValue, SubNode)
            If IsNothing(FoundSubNode) = False Then
                Return FoundSubNode
            End If

        Next
    End Function

    Public Shared Function GenerateSequence(N As Integer) As List(Of Integer)
        Dim Steps As New List(Of Integer)
        While N <> 1
            Steps.Add(N)
            If N Mod 2 = 0 Then
                N = N / 2
            Else
                N = 3 * N + 1
            End If

        End While
        Steps.Add(N)
        Return Steps
    End Function

End Class

Public Class Node
    Public NodeValue As Integer
    Public ListOutwardNodes As New List(Of Node)

End Class


