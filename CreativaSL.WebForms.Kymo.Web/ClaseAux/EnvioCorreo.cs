﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Negocio;
using System.Data;
using System.Net;
using System.Globalization;

namespace CreativaSL.WebForms.Kymo.Web.ClaseAux
{
    public class EnvioCorreo
    {
        //static string _dominio = Comun.Dominio;
        public static bool EnviarCorreo(string De, string Contraseña, string Para, string Asunto, string Mensaje, bool banArchivo, string Archivo, bool Html, string Host, int Port, bool Ssl)
        {
            try
            {
                //GMAIL
                //Habilitar las siguientes opciones en correo de gmail
                //https://www.google.com/settings/security/lesssecureapps
                //https://accounts.google.com/DisplayUnlockCaptcha
                //HOTMAIL
                //Enviara las primeras veces despues nos llegara un correo para reconocer el inicio de sesion 
                //ya que depende del servidor donde esta alojado y se tiene que reconocer el inicio de sesion   
                //Para = "lackke.141727@gmail.com";
                System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
                mailMessage.From = new System.Net.Mail.MailAddress(De);
                mailMessage.To.Add(Para);
                mailMessage.Subject = Asunto;
                if (banArchivo)
                    mailMessage.Attachments.Add(new System.Net.Mail.Attachment(Archivo));
                mailMessage.Body = Mensaje;
                mailMessage.IsBodyHtml = Html;
                System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient(Host);
                smtpClient.Port = Port;
                smtpClient.EnableSsl = Ssl;
                smtpClient.Credentials = new NetworkCredential(De, Contraseña);
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static string GenerarHtmlContacto(string Nombre, string Correo, string Telefono, string Direccion, string Mensaje)
        {
            string creativa = "http://creativasoftline.com";
            string html = @" <!DOCTYPE html>
	        <html>
	        <head>
		        <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" />
		        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
		        <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
		        <meta name=""format-detection"" content=""telephone=no"" />
		        <link href=""https://fonts.googleapis.com/css?family=Orbitron"" rel=""stylesheet""> 
		        <title>Kymo</title>
		        <style type=""text/css"">
			        html { background-color:#E1E1E1; margin:0; padding:0; }
			        body, #bodyTable, #bodyCell, #bodyCell{height:100% !important; margin:0; padding:0; width:100% !important;font-family:Helvetica, Arial, ""Lucida Grande"", sans-serif;}
			        table{border-collapse:collapse;}
			        table[id=bodyTable] {width:100%!important;margin:auto;max-width:500px!important;color:#b6b24c;font-weight:normal;}
			        img, a img{border:0; outline:none; text-decoration:none;height:auto; line-height:100%;}
			        a {text-decoration:none !important;border-bottom: 1px solid;}
			        h1, h2, h3, h4, h5, h6{color:#5F5F5F; font-weight:normal; font-family:Helvetica; font-size:20px; line-height:125%; text-align:Left; letter-spacing:normal;margin-top:0;margin-right:0;margin-bottom:10px;margin-left:0;padding-top:0;padding-bottom:0;padding-left:0;padding-right:0;}
			        .ReadMsgBody{width:100%;} .ExternalClass{width:100%;} /* Force Hotmail/Outlook.com to display emails at full width. */
			        .ExternalClass, .ExternalClass p, .ExternalClass span, .ExternalClass font, .ExternalClass td, .ExternalClass div{line-height:100%;} /* Force Hotmail/Outlook.com to display line heights normally. */
			        table, td{mso-table-lspace:0pt; mso-table-rspace:0pt;} /* Remove spacing between tables in Outlook 2007 and up. */
			        #outlook a{padding:0;} /* Force Outlook 2007 and up to provide a ""view in browser"" message. */
			        img{-ms-interpolation-mode: bicubic;display:block;outline:none; text-decoration:none;} /* Force IE to smoothly render resized images. */
			        body, table, td, p, a, li, blockquote{-ms-text-size-adjust:100%; -webkit-text-size-adjust:100%; font-weight:normal!important;} /* Prevent Windows- and Webkit-based mobile platforms from changing declared text sizes. */
			        .ExternalClass td[class=""ecxflexibleContainerBox""] h3 {padding-top: 10px !important;} /* Force hotmail to push 2-grid sub headers down */

			        h1{display:block;font-size:26px;font-style:normal;font-weight:normal;line-height:100%;}
			        h2{display:block;font-size:20px;font-style:normal;font-weight:normal;line-height:120%;}
			        h3{display:block;font-size:17px;font-style:normal;font-weight:normal;line-height:110%;}
			        h4{display:block;font-size:18px;font-style:italic;font-weight:normal;line-height:100%;}
			        .flexibleImage{height:auto;}
			        .linkRemoveBorder{border-bottom:0 !important;}
			        table[class=flexibleContainerCellDivider] {padding-bottom:0 !important;padding-top:0 !important;}

			        body, #bodyTable{background-color:#E1E1E1;}
			        .lt{
			        	color:#f6ca0e;
			        }
			        #emailHeader{background-color:#b6b24c;}
			        #emailBody{background-color:#FFFFFF;}
			        #emailFooter{background-color:#E1E1E1;}
			        .nestedContainer{background-color:#F8F8F8; border:1px solid #CCCCCC;}
			        .emailButton{background-color:#205478; border-collapse:separate;}
			        .buttonContent{color:#FFFFFF; font-family:Helvetica; font-size:18px; font-weight:bold; line-height:100%; padding:15px; text-align:center;}
			        .buttonContent a{color:#FFFFFF; display:block; text-decoration:none!important; border:0!important;}
			        .emailCalendar{background-color:#FFFFFF; border:1px solid #CCCCCC;}
			        .emailCalendarMonth{background-color:#205478; color:#FFFFFF; font-family:Helvetica, Arial, sans-serif; font-size:16px; font-weight:bold; padding-top:10px; padding-bottom:10px; text-align:center;}
			        .emailCalendarDay{color:#205478; font-family:Helvetica, Arial, sans-serif; font-size:60px; font-weight:bold; line-height:100%; padding-top:20px; padding-bottom:20px; text-align:center;}
			        .imageContentText {margin-top: 10px;line-height:0;}
			        .imageContentText a {line-height:0;}
			        #invisibleIntroduction {display:none !important;} /* Removing the introduction text from the view */
			        span[class=ios-color-hack] a {color:#275100!important;text-decoration:none!important;}
			        span[class=ios-color-hack2] a {color:#205478!important;text-decoration:none!important;}
			        span[class=ios-color-hack3] a {color:#8B8B8B!important;text-decoration:none!important;}
			        .a[href^=""tel""], a[href^=""sms""] {text-decoration:none!important;color:#606060!important;pointer-events:none!important;cursor:default!important;}
			        .mobile_link a[href^=""tel""], .mobile_link a[href^=""sms""] {text-decoration:none!important;color:#606060!important;pointer-events:auto!important;cursor:default!important;}

			        @media only screen and (max-width: 480px){
				        body{width:100% !important; min-width:100% !important;}
				        /*td[class=""textContent""], td[class=""flexibleContainerCell""] { width: 100%; padding-left: 10px !important; padding-right: 10px !important; }*/
				        table[id=""emailHeader""],
				        table[id=""emailBody""],
				        table[id=""emailFooter""],
				        table[class=""flexibleContainer""],
				        td[class=""flexibleContainerCell""] {width:100% !important;}
				        td[class=""flexibleContainerBox""], td[class=""flexibleContainerBox""] table {display: block;width: 100%;text-align: left;}
				        td[class=""imageContent""] img {height:auto !important; width:100% !important; max-width:100% !important; }
				        img[class=""flexibleImage""]{height:auto !important; width:100% !important;max-width:100% !important;}
				        img[class=""flexibleImageSmall""]{height:auto !important; width:auto !important;}
				        table[class=""emailButton""]{width:100% !important;}
				        td[class=""buttonContent""]{padding:0 !important;}
				        td[class=""buttonContent""] a{padding:15px !important;}
			        }
			        @media only screen and (-webkit-device-pixel-ratio:.75){
			        }
			        @media only screen and (-webkit-device-pixel-ratio:1){
			        }
			        @media only screen and (-webkit-device-pixel-ratio:1.5){
			        }
			        @media only screen and (min-device-width : 320px) and (max-device-width:568px) {
			        }
		        </style>
		        <!--[if mso 12]><style type=""text/css"">.flexibleContainer{display:block !important; width:100% !important;}</style><![endif]-->
		        <!--[if mso 14]><style type=""text/css"">.flexibleContainer{display:block !important; width:100% !important;}</style><![endif]-->
	        </head>
	        <body bgcolor=""#E1E1E1"" leftmargin=""0"" marginwidth=""0"" topmargin=""0"" marginheight=""0"" offset=""0"">
		        <center style=""background-color:#E1E1E1;"">
			        <table border=""0"" cellpadding=""0"" cellspacing=""0"" height=""100%"" width=""100%"" id=""bodyTable"" style=""table-layout: fixed;max-width:100% !important;width: 100% !important;min-width: 100% !important;"">
				        <tr>
					        <td align=""center"" valign=""top"" id=""bodyCell"">
						        <table bgcolor=""#FFFFFF""  border=""0"" cellpadding=""0"" cellspacing=""0"" width=""500"" id=""emailBody"">
							        <tr>
								        <td align=""center"" valign=""top"">
									        <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""color:#FFFFFF;"" bgcolor=""#b2ca4d"">
										        <tr>
											        <td align=""center"" valign=""top"">
												        <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""500"" class=""flexibleContainer"">
													        <tr>
														        <td align=""center"" valign=""top"" width=""500"" class=""flexibleContainerCell"">
															        <table border=""0"" cellpadding=""30"" cellspacing=""0"" width=""100%"">
																        <tr>
																	        <td align=""center"" valign=""top"" class=""textContent"">
																		        <img src=""http://www.creativasoftline.com/imagenes/mail_Kymo-02.png"" alt="""">					  
																				<!-- <h1 style=""color:#000;line-height:100%;font-family:'Orbitron',Helvetica,Arial,sans-serif;font-size:35px;font-weight:normal;margin-bottom:5px;text-align:center;"">UNO <span class=""lt"">+</span></h1>
																		        <h2 style=""text-align:center;font-weight:normal;font-family:Helvetica,Arial,sans-serif;font-size:23px;margin-bottom:10px;color:#000;line-height:135%;""><span class=""lt"">FUN</span>CTIONAL WORK<span class=""lt"">-</span>OUT</h2>	 -->

																	        </td>
																        </tr>
															        </table>
														        </td>
													        </tr>
												        </table>
											        </td>
										        </tr>
									        </table>
								        </td>
							        </tr>
							         <tr mc:hideable>
								        <td align=""center"" valign=""top"">
									        <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
										        <tr>
											        <td align=""center"" valign=""top"">
													 <table border=""0"" cellpadding=""30"" cellspacing=""0"" width=""500"" class=""flexibleContainer"">
													        <tr>
														        <td valign=""top"" width=""500"" class=""flexibleContainerCell"">
															        <table align=""left"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
																        <tr>
																        
																	        <td align=""center"" valign=""top"" class=""flexibleContainerBox"">
																		        <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""420"" style=""max-width: 100%;"">
																		        	<tr>
																				        <td align=""center"" class=""textContent"" colspan=""2"">
																				        
																					         <img src=""http://www.creativasoftline.com/imagenes/mail_Kymo-03.png"" alt="""">
																					       
																				        </td>
																				       

																			        </tr>
																			        <tr>
																				        <td align=""left"" class=""textContent"">
																				       <br>
																					        <h3 style=""color:#9a9a9a;line-height:125%;font-family:Helvetica,Arial,sans-serif;font-size:18px;font-weight:bold;margin-top:0;margin-bottom:3px;text-align:center;"">Nombre:</h3>
																					       
																					        
																				        </td>
																				        <td style=""width: 50%;"">
																				        	 <div style=""position:absolute;text-align:left;font-family:Helvetica,Arial,sans-serif;font-size:16px;margin-bottom:0;color:#b0c94d;line-height:135%;"">"+ Nombre + @"</div>
																				        </td>

																			        </tr>
																			        <tr>
																				        <td align=""center"" class=""textContent"">
																				        <br>
																					        <h3 style=""color:#9a9a9a;line-height:125%;font-family:Helvetica,Arial,sans-serif;font-size:18px;font-weight:bold;margin-top:0;margin-bottom:3px;text-align:center;"">Correo:</h3>
																					        
																					        
																				        </td>
																				        <td style=""width: 50%;"">
																				        	 <div style=""position:absolute;text-align:left;font-family:Helvetica,Arial,sans-serif;font-size:16px;margin-bottom:0;color:#b0c94d;line-height:135%;"">" + Correo + @"</div>
																				        </td>

																			        </tr>
																			        <tr>
																				        <td align=""center"" class=""textContent"">
																				        <br>
																					        <h3 style=""color:#9a9a9a;line-height:125%;font-family:Helvetica,Arial,sans-serif;font-size:18px;font-weight:bold;margin-top:0;margin-bottom:3px;text-align:center;"">Dirección:</h3>
																					        
																				        </td>
																				        <td style=""width: 50%;"">
																				        	 <div style=""position:absolute;text-align:left;font-family:Helvetica,Arial,sans-serif;font-size:16px;margin-bottom:0;color:#b0c94d;line-height:135%;"">" + Direccion + @"</div>
																				        </td>

																			        </tr>
																			        <tr>
																				        <td align=""center"" class=""textContent"">
																				        <br>
																					        <h3 style=""color:#9a9a9a;line-height:125%;font-family:Helvetica,Arial,sans-serif;font-size:18px;font-weight:bold;margin-top:0;margin-bottom:3px;text-align:center;"">Telefono:</h3>
																					    
																					        
																				        </td>
																				        <td style=""width: 50%;"">
																				        	 <div style=""position:absolute;text-align:left;font-family:Helvetica,Arial,sans-serif;font-size:16px;margin-bottom:0;color:#b0c94d;line-height:135%;"">" + Telefono + @"</div>
																				        </td>

																			        </tr>
																			        <tr>
																				        <td align=""center"" class=""textContent"" colspan=""2"">
																				        <br>
																					        <h3 style=""color:#9a9a9a;line-height:125%;font-family:Helvetica,Arial,sans-serif;font-size:18px;font-weight:bold;margin-top:0;margin-bottom:3px;text-align:center;"">Mensaje</h3>
																					        
																					        
																				        </td>
																				       

																			        </tr>
																			        <tr>
																				        <td align=""center"" class=""textContent"" colspan=""2"">
																				        <br>
																					        <h3 style=""color:#b0c94d;line-height:125%;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:normal;margin-top:0;margin-bottom:3px;text-align:justify;"">" + Mensaje + @"</h3>
																					        
																					        
																				        </td>
																				       

																			        </tr>
																			        
																			        
																		        </table>

																	        </td>

																	        																        </tr>
															        </table>
															        <br><br>
														        </td>
													        </tr>
												        </table>
														
											        </td>
										        </tr>
									        </table>
								        </td>
							        </tr>
							        <tr>
								        
							        </tr>
						        </table>
						        <table bgcolor=""#E1E1E1"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""500"" id=""emailFooter"">
							        <tr>
								        <td align=""center"" valign=""top"">
									        <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
										        <tr>
											        <td align=""center"" valign=""top"">
												        <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""500"" class=""flexibleContainer"">
													        <tr>
														        <td align=""center"" valign=""top"" width=""500"" class=""flexibleContainerCell"">
															        <table border=""0"" cellpadding=""30"" cellspacing=""0"" width=""100%"">
																        <tr>
																	        <td valign=""top"" bgcolor=""#E1E1E1"">
																		        <div style=""font-family:Helvetica,Arial,sans-serif;font-size:13px;color:#828282;text-align:center;line-height:120%;"">
																			        <div>Copyright &#169; " + DateTime.Now.Year + @"  <a href=" + creativa + @" target=""_blank"" style=""text-decoration:none;color:#828282;""><span style=""color:#828282;"">CSL</span></a>. All&nbsp;rights&nbsp;reserved.</div>
																			        <div>Creativa Softline <a href=" + creativa + @" target=""""_blank"""" style=""text-decoration:none;color:#828282;""><span style=""color:#828282;"">comunicarse</span></a>.</div>
																		        </div>
																	        </td>
																        </tr>
															        </table>
														        </td>
													        </tr>
												        </table>
											        </td>
										        </tr>
									        </table>
								        </td>
							        </tr>
						        </table>
					        </td>
				        </tr>
			        </table>
		        </center>
	        </body>
        </html>";
            return html;
        }

    }
}
