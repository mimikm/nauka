
/*
 !!! JUST INSTALL PLUGIN IN PLUGINS FOLDER, IT WILL WORK NORMALLY !!!

 Welcome wanderer! 
 If you are reading this, that means that you tried to open one of my protected plugins. 
 If you want to get the decrypted version of that plugin, message me and tell me why you need it.

 Contact information:
 Email: official.rustworkshop@gmail.com
 Website: https://rustworkshop.space/
 Discord: Orange#0900
*/

using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using UnityEngine;

namespace Oxide.Plugins
{
    [Info("Turrets Switch", "Orange", "1.0.2")]
    [Description("https://rustworkshop.space/resources/turrets-switch.165/")]
    public class TurretsSwitch : RustPlugin
    {        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0063\u006F\u006E\u0073\u0074 \u0073\u0074\u0072\u0069\u006E\u0067 \u0070\u0072\u0065f\u0061\u0062\u0053\u0077\u0069\u0074\u0063\u0068 = "\u0061\u0073\u0073\u0065\u0074\u0073/\u0070\u0072\u0065f\u0061\u0062\u0073/\u0064\u0065\u0070\u006C\u006F\u0079\u0061\u0062\u006C\u0065/\u0070\u006C\u0061\u0079\u0065\u0072\u0069\u006F\u0065\u006E\u0074\u0073/\u0073\u0069\u006D\u0070\u006C\u0065\u0073\u0077\u0069\u0074\u0063\u0068/\u0073\u0077\u0069\u0074\u0063\u0068.\u0070\u0072\u0065f\u0061\u0062";        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0073\u0074\u0061\u0074\u0069\u0063 \u0056\u0065\u0063\u0074\u006F\u00723 \u0073\u0077\u0069\u0074\u0063\u0068\u0050\u006F\u0073\u0069\u0074\u0069\u006F\u006E\u0041\u0054 = \u006E\u0065\u0077 \u0056\u0065\u0063\u0074\u006F\u00723(0, -0.7f, 0.3f);        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0073\u0074\u0061\u0074\u0069\u0063 \u0056\u0065\u0063\u0074\u006F\u00723 \u0073\u0077\u0069\u0074\u0063\u0068\u0050\u006F\u0073\u0069\u0074\u0069\u006F\u006E\u0053\u0041\u004D = \u006E\u0065\u0077 \u0056\u0065\u0063\u0074\u006F\u00723(0, -0.5f, 1);        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0073\u0074\u0061\u0074\u0069\u0063 \u0051\u0075\u0061\u0074\u0065\u0072\u006E\u0069\u006F\u006E \u0073\u0077\u0069\u0074\u0063\u0068\u0052\u006F\u0074\u0061\u0074\u0069\u006F\u006E\u0041\u0054 = \u006E\u0065\u0077 \u0051\u0075\u0061\u0074\u0065\u0072\u006E\u0069\u006F\u006E();        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0073\u0074\u0061\u0074\u0069\u0063 \u0051\u0075\u0061\u0074\u0065\u0072\u006E\u0069\u006F\u006E \u0073\u0077\u0069\u0074\u0063\u0068\u0052\u006F\u0074\u0061\u0074\u0069\u006F\u006E\u0053\u0041\u004D = \u006E\u0065\u0077 \u0051\u0075\u0061\u0074\u0065\u0072\u006E\u0069\u006F\u006E();        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0063\u006F\u006E\u0073\u0074 \u0073\u0074\u0072\u0069\u006E\u0067 \u0070\u0065\u0072\u006D\u0041\u0054 = "\u0074\u0075\u0072\u0072\u0065\u0074\u0073\u0073\u0077\u0069\u0074\u0063\u0068.\u0061\u0075\u0074\u006F\u0074\u0075\u0072\u0072\u0065\u0074";        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0063\u006F\u006E\u0073\u0074 \u0073\u0074\u0072\u0069\u006E\u0067 \u0070\u0065\u0072\u006D\u0053\u0041\u004D = "\u0074\u0075\u0072\u0072\u0065\u0074\u0073\u0073\u0077\u0069\u0074\u0063\u0068.\u0073\u0061\u006D";        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0063\u006F\u006E\u0073\u0074 f\u006C\u006F\u0061\u0074 \u0070\u0065\u0072\u006D\u0073\u0043\u0068\u0065\u0063\u006B\u0054\u0069\u006D\u0065 = 600f;        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0063\u006F\u006E\u0073\u0074 \u0075\u006C\u006F\u006E\u0067 \u0073\u006B\u0069\u006E\u004D\u0061\u0072\u006B = 223451;            \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0076\u006F\u0069\u0064 \u0049\u006E\u0069\u0074()        {            \u0070\u0065\u0072\u006D\u0069\u0073\u0073\u0069\u006F\u006E.\u0052\u0065\u0067\u0069\u0073\u0074\u0065\u0072\u0050\u0065\u0072\u006D\u0069\u0073\u0073\u0069\u006F\u006E(\u0070\u0065\u0072\u006D\u0041\u0054, \u0074\u0068\u0069\u0073);            \u0070\u0065\u0072\u006D\u0069\u0073\u0073\u0069\u006F\u006E.\u0052\u0065\u0067\u0069\u0073\u0074\u0065\u0072\u0050\u0065\u0072\u006D\u0069\u0073\u0073\u0069\u006F\u006E(\u0070\u0065\u0072\u006D\u0053\u0041\u004D, \u0074\u0068\u0069\u0073);            \u0055\u006E\u0073\u0075\u0062\u0073\u0063\u0072\u0069\u0062\u0065(\u006E\u0061\u006D\u0065\u006Ff(\u004F\u006E\u0045\u006E\u0074\u0069\u0074\u0079\u0053\u0070\u0061\u0077\u006E\u0065\u0064));        }        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0076\u006F\u0069\u0064 \u004F\u006E\u0053\u0065\u0072\u0076\u0065\u0072\u0049\u006E\u0069\u0074\u0069\u0061\u006C\u0069\u007A\u0065\u0064()        {            \u0053\u0075\u0062\u0073\u0063\u0072\u0069\u0062\u0065(\u006E\u0061\u006D\u0065\u006Ff(\u004F\u006E\u0045\u006E\u0074\u0069\u0074\u0079\u0053\u0070\u0061\u0077\u006E\u0065\u0064));            \u0043\u0068\u0065\u0063\u006B\u0054\u0075\u0072\u0072\u0065\u0074\u0073();            \u0074\u0069\u006D\u0065\u0072.\u0045\u0076\u0065\u0072\u0079(\u0070\u0065\u0072\u006D\u0073\u0043\u0068\u0065\u0063\u006B\u0054\u0069\u006D\u0065, \u0043\u0068\u0065\u0063\u006B\u0054\u0075\u0072\u0072\u0065\u0074\u0073);        }        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u006F\u0062\u006A\u0065\u0063\u0074 \u004F\u006E\u0054\u0075\u0072\u0072\u0065\u0074\u0053\u0068\u0075\u0074\u0064\u006F\u0077\u006E(\u0043\u006F\u006E\u0074\u0061\u0069\u006E\u0065\u0072\u0049\u004F\u0045\u006E\u0074\u0069\u0074\u0079 \u0074\u0075\u0072\u0072\u0065\u0074)        {            \u0072\u0065\u0074\u0075\u0072\u006E \u0043\u0068\u0065\u0063\u006B\u0053\u0068\u0075\u0074\u0064\u006F\u0077\u006E(\u0074\u0075\u0072\u0072\u0065\u0074);        }        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0076\u006F\u0069\u0064 \u004F\u006E\u0045\u006E\u0074\u0069\u0074\u0079\u0053\u0070\u0061\u0077\u006E\u0065\u0064(\u0043\u006F\u006E\u0074\u0061\u0069\u006E\u0065\u0072\u0049\u004F\u0045\u006E\u0074\u0069\u0074\u0079 \u0065\u006E\u0074\u0069\u0074\u0079)        {            \u004E\u0065\u0078\u0074\u0054\u0069\u0063\u006B(()=> {\u0043\u0068\u0065\u0063\u006B\u0054\u0075\u0072\u0072\u0065\u0074(\u0065\u006E\u0074\u0069\u0074\u0079);});        }                \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0076\u006F\u0069\u0064 \u004F\u006E\u0053\u0077\u0069\u0074\u0063\u0068\u0054\u006F\u0067\u0067\u006C\u0065(\u0045\u006C\u0065\u0063\u0074\u0072\u0069\u0063\u0053\u0077\u0069\u0074\u0063\u0068 \u0065\u006E\u0074\u0069\u0074\u0079, \u0042\u0061\u0073\u0065\u0050\u006C\u0061\u0079\u0065\u0072 \u0070\u006C\u0061\u0079\u0065\u0072)        {            \u0043\u0068\u0065\u0063\u006B\u0053\u0077\u0069\u0074\u0063\u0068(\u0065\u006E\u0074\u0069\u0074\u0079, \u0070\u006C\u0061\u0079\u0065\u0072);        }        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0076\u006F\u0069\u0064 \u0043\u0068\u0065\u0063\u006B\u0054\u0075\u0072\u0072\u0065\u0074\u0073()        {            \u0076\u0061\u0072 \u006C\u0069\u0073\u0074 = \u006E\u0065\u0077 \u004C\u0069\u0073\u0074<\u0043\u006F\u006E\u0074\u0061\u0069\u006E\u0065\u0072\u0049\u004F\u0045\u006E\u0074\u0069\u0074\u0079>();            \u0069f (\u0063\u006F\u006Ef\u0069\u0067.\u0077\u006F\u0072\u006B\u0041\u0054 == \u0074\u0072\u0075\u0065)            {                \u006C\u0069\u0073\u0074.\u0041\u0064\u0064\u0052\u0061\u006E\u0067\u0065(\u0055\u006E\u0069\u0074\u0079\u0045\u006E\u0067\u0069\u006E\u0065.\u004F\u0062\u006A\u0065\u0063\u0074.\u0046\u0069\u006E\u0064\u004F\u0062\u006A\u0065\u0063\u0074\u0073\u004Ff\u0054\u0079\u0070\u0065<\u0041\u0075\u0074\u006F\u0054\u0075\u0072\u0072\u0065\u0074>());            }            \u0069f (\u0063\u006F\u006Ef\u0069\u0067.\u0077\u006F\u0072\u006B\u0053\u0041\u004D == \u0074\u0072\u0075\u0065)            {                \u006C\u0069\u0073\u0074.\u0041\u0064\u0064\u0052\u0061\u006E\u0067\u0065(\u0055\u006E\u0069\u0074\u0079\u0045\u006E\u0067\u0069\u006E\u0065.\u004F\u0062\u006A\u0065\u0063\u0074.\u0046\u0069\u006E\u0064\u004F\u0062\u006A\u0065\u0063\u0074\u0073\u004Ff\u0054\u0079\u0070\u0065<\u0053\u0061\u006D\u0053\u0069\u0074\u0065>());            }            f\u006F\u0072\u0065\u0061\u0063\u0068 (\u0076\u0061\u0072 \u0065\u006E\u0074\u0069\u0074\u0079 \u0069\u006E \u006C\u0069\u0073\u0074)            {                \u0041\u0064\u0064\u0053\u0077\u0069\u0074\u0063\u0068(\u0065\u006E\u0074\u0069\u0074\u0079);            }        }        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0076\u006F\u0069\u0064 \u0043\u0068\u0065\u0063\u006B\u0054\u0075\u0072\u0072\u0065\u0074(\u0043\u006F\u006E\u0074\u0061\u0069\u006E\u0065\u0072\u0049\u004F\u0045\u006E\u0074\u0069\u0074\u0079 \u0065\u006E\u0074\u0069\u0074\u0079)        {            \u0069f (\u0065\u006E\u0074\u0069\u0074\u0079.\u0049\u0073\u0056\u0061\u006C\u0069\u0064() == f\u0061\u006C\u0073\u0065)            {                \u0072\u0065\u0074\u0075\u0072\u006E;            }                    \u0069f (\u0065\u006E\u0074\u0069\u0074\u0079 \u0069\u0073 \u0041\u0075\u0074\u006F\u0054\u0075\u0072\u0072\u0065\u0074 && \u0063\u006F\u006Ef\u0069\u0067.\u0077\u006F\u0072\u006B\u0041\u0054 || \u0065\u006E\u0074\u0069\u0074\u0079 \u0069\u0073 \u0053\u0061\u006D\u0053\u0069\u0074\u0065 && \u0063\u006F\u006Ef\u0069\u0067.\u0077\u006F\u0072\u006B\u0053\u0041\u004D)            {                \u0041\u0064\u0064\u0053\u0077\u0069\u0074\u0063\u0068(\u0065\u006E\u0074\u0069\u0074\u0079);            }        }                \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0076\u006F\u0069\u0064 \u0041\u0064\u0064\u0053\u0077\u0069\u0074\u0063\u0068(\u0042\u0061\u0073\u0065\u0045\u006E\u0074\u0069\u0074\u0079 \u0070\u0061\u0072\u0065\u006E\u0074)        {            \u0069f (\u0070\u0061\u0072\u0065\u006E\u0074.\u004F\u0077\u006E\u0065\u0072\u0049\u0044.\u0049\u0073\u0053\u0074\u0065\u0061\u006D\u0049\u0064() == f\u0061\u006C\u0073\u0065)            {                \u0072\u0065\u0074\u0075\u0072\u006E;            }            \u0069f (\u0070\u0061\u0072\u0065\u006E\u0074 \u0069\u0073 \u004E\u0050\u0043\u0041\u0075\u0074\u006F\u0054\u0075\u0072\u0072\u0065\u0074)            {                \u0072\u0065\u0074\u0075\u0072\u006E;            }            \u0076\u0061\u0072 \u0074\u0075\u0072\u0072\u0065\u0074 = \u0070\u0061\u0072\u0065\u006E\u0074 \u0069\u0073 \u0041\u0075\u0074\u006F\u0054\u0075\u0072\u0072\u0065\u0074;            \u0076\u0061\u0072 \u0070\u006C\u0061\u0079\u0065\u0072\u0049\u0044 = \u0070\u0061\u0072\u0065\u006E\u0074.\u004F\u0077\u006E\u0065\u0072\u0049\u0044.\u0054\u006F\u0053\u0074\u0072\u0069\u006E\u0067();            \u0076\u0061\u0072 \u0070\u0065\u0072\u006D\u0054\u006F\u0043\u0068\u0065\u0063\u006B = \u0074\u0075\u0072\u0072\u0065\u0074 ? \u0070\u0065\u0072\u006D\u0041\u0054 : \u0070\u0065\u0072\u006D\u0053\u0041\u004D;            \u0069f (\u0070\u0065\u0072\u006D\u0069\u0073\u0073\u0069\u006F\u006E.\u0055\u0073\u0065\u0072\u0048\u0061\u0073\u0050\u0065\u0072\u006D\u0069\u0073\u0073\u0069\u006F\u006E(\u0070\u006C\u0061\u0079\u0065\u0072\u0049\u0044, \u0070\u0065\u0072\u006D\u0054\u006F\u0043\u0068\u0065\u0063\u006B) == f\u0061\u006C\u0073\u0065)            {                \u0072\u0065\u0074\u0075\u0072\u006E;            }                        \u0076\u0061\u0072 \u0065\u006E\u0074\u0069\u0074\u0079 = \u0070\u0061\u0072\u0065\u006E\u0074.\u0047\u0065\u0074\u0043\u006F\u006D\u0070\u006F\u006E\u0065\u006E\u0074\u0049\u006E\u0043\u0068\u0069\u006C\u0064\u0072\u0065\u006E<\u0045\u006C\u0065\u0063\u0074\u0072\u0069\u0063\u0053\u0077\u0069\u0074\u0063\u0068>();            \u0069f (\u0065\u006E\u0074\u0069\u0074\u0079 == \u006E\u0075\u006C\u006C)            {                \u0076\u0061\u0072 \u0070\u006F\u0073 = \u006E\u0065\u0077 \u0056\u0065\u0063\u0074\u006F\u00723();                \u0076\u0061\u0072 \u0072\u006F\u0074 = \u006E\u0065\u0077 \u0051\u0075\u0061\u0074\u0065\u0072\u006E\u0069\u006F\u006E();                \u0069f (\u0074\u0075\u0072\u0072\u0065\u0074)                {                    \u0070\u006F\u0073 = \u0073\u0077\u0069\u0074\u0063\u0068\u0050\u006F\u0073\u0069\u0074\u0069\u006F\u006E\u0041\u0054;                    \u0072\u006F\u0074 = \u0073\u0077\u0069\u0074\u0063\u0068\u0052\u006F\u0074\u0061\u0074\u0069\u006F\u006E\u0041\u0054;                }                \u0065\u006C\u0073\u0065                {                    \u0070\u006F\u0073 = \u0073\u0077\u0069\u0074\u0063\u0068\u0050\u006F\u0073\u0069\u0074\u0069\u006F\u006E\u0053\u0041\u004D;                    \u0072\u006F\u0074 = \u0073\u0077\u0069\u0074\u0063\u0068\u0052\u006F\u0074\u0061\u0074\u0069\u006F\u006E\u0053\u0041\u004D;                }                            \u0065\u006E\u0074\u0069\u0074\u0079 = \u0047\u0061\u006D\u0065\u004D\u0061\u006E\u0061\u0067\u0065\u0072.\u0073\u0065\u0072\u0076\u0065\u0072.\u0043\u0072\u0065\u0061\u0074\u0065\u0045\u006E\u0074\u0069\u0074\u0079(\u0070\u0072\u0065f\u0061\u0062\u0053\u0077\u0069\u0074\u0063\u0068, \u0070\u006F\u0073, \u0072\u006F\u0074)?.\u0047\u0065\u0074\u0043\u006F\u006D\u0070\u006F\u006E\u0065\u006E\u0074<\u0045\u006C\u0065\u0063\u0074\u0072\u0069\u0063\u0053\u0077\u0069\u0074\u0063\u0068>();                \u0069f (\u0065\u006E\u0074\u0069\u0074\u0079 == \u006E\u0075\u006C\u006C)                {                    \u0072\u0065\u0074\u0075\u0072\u006E;                }                            \u0065\u006E\u0074\u0069\u0074\u0079.\u0073\u006B\u0069\u006E\u0049\u0044 = \u0073\u006B\u0069\u006E\u004D\u0061\u0072\u006B;                \u0065\u006E\u0074\u0069\u0074\u0079.\u0053\u0070\u0061\u0077\u006E();                \u0065\u006E\u0074\u0069\u0074\u0079.\u0053\u0065\u0074\u0050\u0061\u0072\u0065\u006E\u0074(\u0070\u0061\u0072\u0065\u006E\u0074);            }            \u0069f (\u0065\u006E\u0074\u0069\u0074\u0079 != \u006E\u0075\u006C\u006C && \u0065\u006E\u0074\u0069\u0074\u0079.\u0073\u006B\u0069\u006E\u0049\u0044 != \u0073\u006B\u0069\u006E\u004D\u0061\u0072\u006B)            {                \u0072\u0065\u0074\u0075\u0072\u006E;            }            \u0065\u006E\u0074\u0069\u0074\u0079.\u0070\u0069\u0063\u006B\u0075\u0070.\u0065\u006E\u0061\u0062\u006C\u0065\u0064 = f\u0061\u006C\u0073\u0065;            \u0065\u006E\u0074\u0069\u0074\u0079.\u0049\u006E\u0069\u0074\u0069\u0061\u006C\u0069\u007A\u0065\u0048\u0065\u0061\u006C\u0074\u0068(100 * 1000, 100 * 1000);            \u0055\u006E\u0069\u0074\u0079\u0045\u006E\u0067\u0069\u006E\u0065.\u004F\u0062\u006A\u0065\u0063\u0074.\u0044\u0065\u0073\u0074\u0072\u006F\u0079(\u0065\u006E\u0074\u0069\u0074\u0079.\u0047\u0065\u0074\u0043\u006F\u006D\u0070\u006F\u006E\u0065\u006E\u0074<\u0044\u0065\u0073\u0074\u0072\u006F\u0079\u004F\u006E\u0047\u0072\u006F\u0075\u006E\u0064\u004D\u0069\u0073\u0073\u0069\u006E\u0067>());            \u0055\u006E\u0069\u0074\u0079\u0045\u006E\u0067\u0069\u006E\u0065.\u004F\u0062\u006A\u0065\u0063\u0074.\u0044\u0065\u0073\u0074\u0072\u006F\u0079(\u0065\u006E\u0074\u0069\u0074\u0079.\u0047\u0065\u0074\u0043\u006F\u006D\u0070\u006F\u006E\u0065\u006E\u0074<\u0047\u0072\u006F\u0075\u006E\u0064\u0057\u0061\u0074\u0063\u0068>());        }                \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0073\u0074\u0061\u0074\u0069\u0063 \u006F\u0062\u006A\u0065\u0063\u0074 \u0043\u0068\u0065\u0063\u006B\u0053\u0068\u0075\u0074\u0064\u006F\u0077\u006E(\u0043\u006F\u006E\u0074\u0061\u0069\u006E\u0065\u0072\u0049\u004F\u0045\u006E\u0074\u0069\u0074\u0079 \u0065\u006E\u0074\u0069\u0074\u0079)        {            \u0076\u0061\u0072 \u006C\u0065\u0076\u0065\u0072 = \u0065\u006E\u0074\u0069\u0074\u0079.\u0047\u0065\u0074\u0043\u006F\u006D\u0070\u006F\u006E\u0065\u006E\u0074\u0049\u006E\u0043\u0068\u0069\u006C\u0064\u0072\u0065\u006E<\u0045\u006C\u0065\u0063\u0074\u0072\u0069\u0063\u0053\u0077\u0069\u0074\u0063\u0068>();            \u0069f (\u006C\u0065\u0076\u0065\u0072 == \u006E\u0075\u006C\u006C || \u006C\u0065\u0076\u0065\u0072.\u0073\u006B\u0069\u006E\u0049\u0044 != \u0073\u006B\u0069\u006E\u004D\u0061\u0072\u006B)            {                \u0072\u0065\u0074\u0075\u0072\u006E \u006E\u0075\u006C\u006C;            }            \u0069f (\u006C\u0065\u0076\u0065\u0072.\u0049\u0073\u004F\u006E() == \u0074\u0072\u0075\u0065)            {                \u0072\u0065\u0074\u0075\u0072\u006E \u0074\u0072\u0075\u0065;            }            \u0072\u0065\u0074\u0075\u0072\u006E \u006E\u0075\u006C\u006C;        }                \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0073\u0074\u0061\u0074\u0069\u0063 \u0076\u006F\u0069\u0064 \u0043\u0068\u0065\u0063\u006B\u0053\u0077\u0069\u0074\u0063\u0068(\u0045\u006C\u0065\u0063\u0074\u0072\u0069\u0063\u0053\u0077\u0069\u0074\u0063\u0068 \u006C\u0065\u0076\u0065\u0072, \u0042\u0061\u0073\u0065\u0050\u006C\u0061\u0079\u0065\u0072 \u0070\u006C\u0061\u0079\u0065\u0072)        {            \u0076\u0061\u0072 \u0063\u006F\u006E\u0074\u0061\u0069\u006E\u0065\u0072 = \u006C\u0065\u0076\u0065\u0072.\u0047\u0065\u0074\u0043\u006F\u006D\u0070\u006F\u006E\u0065\u006E\u0074\u0049\u006E\u0050\u0061\u0072\u0065\u006E\u0074<\u0043\u006F\u006E\u0074\u0061\u0069\u006E\u0065\u0072\u0049\u004F\u0045\u006E\u0074\u0069\u0074\u0079>();            \u0069f (\u0063\u006F\u006E\u0074\u0061\u0069\u006E\u0065\u0072 == \u006E\u0075\u006C\u006C || \u006C\u0065\u0076\u0065\u0072.\u0073\u006B\u0069\u006E\u0049\u0044 != \u0073\u006B\u0069\u006E\u004D\u0061\u0072\u006B)            {                \u0072\u0065\u0074\u0075\u0072\u006E;            }            \u0076\u0061\u0072 \u0063\u0061\u006E\u0063\u0065\u006C\u0065\u0064 = f\u0061\u006C\u0073\u0065;                        \u0076\u0061\u0072 \u0074\u0075\u0072\u0072\u0065\u0074 = \u0063\u006F\u006E\u0074\u0061\u0069\u006E\u0065\u0072.\u0047\u0065\u0074\u0043\u006F\u006D\u0070\u006F\u006E\u0065\u006E\u0074<\u0041\u0075\u0074\u006F\u0054\u0075\u0072\u0072\u0065\u0074>();            \u0069f (\u0074\u0075\u0072\u0072\u0065\u0074 != \u006E\u0075\u006C\u006C && \u0074\u0075\u0072\u0072\u0065\u0074.\u0061\u0075\u0074\u0068\u006F\u0072\u0069\u007A\u0065\u0064\u0050\u006C\u0061\u0079\u0065\u0072\u0073.\u0041\u006E\u0079(\u0078 => \u0078.\u0075\u0073\u0065\u0072\u0069\u0064 == \u0070\u006C\u0061\u0079\u0065\u0072.\u0075\u0073\u0065\u0072\u0049\u0044) == f\u0061\u006C\u0073\u0065)            {                \u0063\u0061\u006E\u0063\u0065\u006C\u0065\u0064 = \u0074\u0072\u0075\u0065;            }            \u0076\u0061\u0072 \u0073\u0061\u006D = \u0063\u006F\u006E\u0074\u0061\u0069\u006E\u0065\u0072.\u0047\u0065\u0074\u0043\u006F\u006D\u0070\u006F\u006E\u0065\u006E\u0074<\u0053\u0061\u006D\u0053\u0069\u0074\u0065>();            \u0069f (\u0073\u0061\u006D != \u006E\u0075\u006C\u006C && \u0070\u006C\u0061\u0079\u0065\u0072.\u0043\u0061\u006E\u0042\u0075\u0069\u006C\u0064() == f\u0061\u006C\u0073\u0065)            {                \u0063\u0061\u006E\u0063\u0065\u006C\u0065\u0064 = \u0074\u0072\u0075\u0065;            }            \u0069f (\u0063\u0061\u006E\u0063\u0065\u006C\u0065\u0064 == \u0074\u0072\u0075\u0065)            {                \u0070\u006C\u0061\u0079\u0065\u0072.\u0043\u0068\u0061\u0074\u004D\u0065\u0073\u0073\u0061\u0067\u0065("\u004E\u006F \u0050\u0065\u0072\u006D\u0069\u0073\u0073\u0069\u006F\u006E");                \u006C\u0065\u0076\u0065\u0072.\u0053\u0065\u0074\u0053\u0077\u0069\u0074\u0063\u0068(!\u006C\u0065\u0076\u0065\u0072.\u0049\u0073\u004F\u006E());            }            \u0065\u006C\u0073\u0065            {                \u0074\u0075\u0072\u0072\u0065\u0074?.\u0053\u0065\u0074\u0049\u0073\u004F\u006E\u006C\u0069\u006E\u0065(!\u0074\u0075\u0072\u0072\u0065\u0074.\u0049\u0073\u004F\u006E());                \u0073\u0061\u006D?.\u0053\u0065\u0074\u0046\u006C\u0061\u0067(\u0042\u0061\u0073\u0065\u0045\u006E\u0074\u0069\u0074\u0079.\u0046\u006C\u0061\u0067\u0073.\u0052\u0065\u0073\u0065\u0072\u0076\u0065\u00648, !\u0073\u0061\u006D.\u0048\u0061\u0073\u0046\u006C\u0061\u0067(\u0042\u0061\u0073\u0065\u0045\u006E\u0074\u0069\u0074\u0079.\u0046\u006C\u0061\u0067\u0073.\u0052\u0065\u0073\u0065\u0072\u0076\u0065\u00648));            }        }                \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0073\u0074\u0061\u0074\u0069\u0063 \u0043\u006F\u006Ef\u0069\u0067\u0044\u0061\u0074\u0061 \u0063\u006F\u006Ef\u0069\u0067 = \u006E\u0065\u0077 \u0043\u006F\u006Ef\u0069\u0067\u0044\u0061\u0074\u0061();        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0063\u006C\u0061\u0073\u0073 \u0043\u006F\u006Ef\u0069\u0067\u0044\u0061\u0074\u0061        {            [\u004A\u0073\u006F\u006E\u0050\u0072\u006F\u0070\u0065\u0072\u0074\u0079(\u0050\u0072\u006F\u0070\u0065\u0072\u0074\u0079\u004E\u0061\u006D\u0065 = "\u0041\u0064\u0064 \u006F\u006E \u0041\u0075\u0074\u006F\u0054\u0075\u0072\u0072\u0065\u0074")]            \u0070\u0075\u0062\u006C\u0069\u0063 \u0062\u006F\u006F\u006C \u0077\u006F\u0072\u006B\u0041\u0054 = \u0074\u0072\u0075\u0065;            [\u004A\u0073\u006F\u006E\u0050\u0072\u006F\u0070\u0065\u0072\u0074\u0079(\u0050\u0072\u006F\u0070\u0065\u0072\u0074\u0079\u004E\u0061\u006D\u0065 = "\u0041\u0064\u0064 \u006F\u006E \u0053\u0061\u006D\u0053\u0069\u0074\u0065")]            \u0070\u0075\u0062\u006C\u0069\u0063 \u0062\u006F\u006F\u006C \u0077\u006F\u0072\u006B\u0053\u0041\u004D = \u0074\u0072\u0075\u0065;        }        \u0070\u0072\u006F\u0074\u0065\u0063\u0074\u0065\u0064 \u006F\u0076\u0065\u0072\u0072\u0069\u0064\u0065 \u0076\u006F\u0069\u0064 \u004C\u006F\u0061\u0064\u0043\u006F\u006Ef\u0069\u0067()        {            \u0062\u0061\u0073\u0065.\u004C\u006F\u0061\u0064\u0043\u006F\u006Ef\u0069\u0067();            \u0074\u0072\u0079            {                \u0063\u006F\u006Ef\u0069\u0067 = \u0043\u006F\u006Ef\u0069\u0067.\u0052\u0065\u0061\u0064\u004F\u0062\u006A\u0065\u0063\u0074<\u0043\u006F\u006Ef\u0069\u0067\u0044\u0061\u0074\u0061>();                \u0069f (\u0063\u006F\u006Ef\u0069\u0067 == \u006E\u0075\u006C\u006C)                {                    \u004C\u006F\u0061\u0064\u0044\u0065f\u0061\u0075\u006C\u0074\u0043\u006F\u006Ef\u0069\u0067();                }            }            \u0063\u0061\u0074\u0063\u0068            {                f\u006F\u0072 (\u0076\u0061\u0072 \u0069 = 0; \u0069 < 3; \u0069++)                {                    \u0050\u0072\u0069\u006E\u0074\u0045\u0072\u0072\u006F\u0072("\u0043\u006F\u006Ef\u0069\u0067\u0075\u0072\u0061\u0074\u0069\u006F\u006E f\u0069\u006C\u0065 \u0069\u0073 \u0063\u006F\u0072\u0072\u0075\u0070\u0074! \u0043\u0068\u0065\u0063\u006B \u0079\u006F\u0075\u0072 \u0063\u006F\u006Ef\u0069\u0067 f\u0069\u006C\u0065 \u0061\u0074 \u0068\u0074\u0074\u0070\u0073://\u006A\u0073\u006F\u006E\u006C\u0069\u006E\u0074.\u0063\u006F\u006D/");                }                                \u004C\u006F\u0061\u0064\u0044\u0065f\u0061\u0075\u006C\u0074\u0043\u006F\u006Ef\u0069\u0067();                \u0072\u0065\u0074\u0075\u0072\u006E;            }            \u0056\u0061\u006C\u0069\u0064\u0061\u0074\u0065\u0043\u006F\u006Ef\u0069\u0067();            \u0053\u0061\u0076\u0065\u0043\u006F\u006Ef\u0069\u0067();        }        \u0070\u0072\u0069\u0076\u0061\u0074\u0065 \u0073\u0074\u0061\u0074\u0069\u0063 \u0076\u006F\u0069\u0064 \u0056\u0061\u006C\u0069\u0064\u0061\u0074\u0065\u0043\u006F\u006Ef\u0069\u0067()        {                    }        \u0070\u0072\u006F\u0074\u0065\u0063\u0074\u0065\u0064 \u006F\u0076\u0065\u0072\u0072\u0069\u0064\u0065 \u0076\u006F\u0069\u0064 \u004C\u006F\u0061\u0064\u0044\u0065f\u0061\u0075\u006C\u0074\u0043\u006F\u006Ef\u0069\u0067()        {            \u0063\u006F\u006Ef\u0069\u0067 = \u006E\u0065\u0077 \u0043\u006F\u006Ef\u0069\u0067\u0044\u0061\u0074\u0061();        }        \u0070\u0072\u006F\u0074\u0065\u0063\u0074\u0065\u0064 \u006F\u0076\u0065\u0072\u0072\u0069\u0064\u0065 \u0076\u006F\u0069\u0064 \u0053\u0061\u0076\u0065\u0043\u006F\u006Ef\u0069\u0067()        {            \u0043\u006F\u006Ef\u0069\u0067.\u0057\u0072\u0069\u0074\u0065\u004F\u0062\u006A\u0065\u0063\u0074(\u0063\u006F\u006Ef\u0069\u0067);        }    }}