# QRExf1l

QRExf1l is a C# assembly that converts files into QRs in order to help exfiltration tasks during our Red Team assessments.

>This tool is made for educational purpose!  A bad usage of this tool is not allowed...

## Description &  Purpose

Once obtain access to target machine inside an internal network **via RDP** and found some juicy information. 

QRExf1l will help us to exfiltrate this juicy data through the RDP channel without creating unnecessary noise.

<p align="center">
<img src="https://media.giphy.com/media/V84rVyTxbRsBFtkFpR/giphy.gif">
</p>

Record the RDP session and launch QRExf1l to obtain in localhost all QRCodes. After that decode all QRCodes to obtain the initial data.