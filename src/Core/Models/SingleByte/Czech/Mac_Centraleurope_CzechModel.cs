﻿/* ***** BEGIN LICENSE BLOCK *****
 * Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Mozilla Communicator client code.
 *
 * The Initial Developer of the Original Code is
 * Netscape Communications Corporation.
 * Portions created by the Initial Developer are Copyright (C) 1998
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 *
 * ***** END LICENSE BLOCK ***** */

/*
* The following part was imported from https://gitlab.freedesktop.org/uchardet/uchardet
* The implementation of this feature was originally done on https://gitlab.freedesktop.org/uchardet/uchardet/blob/master/src/LangModels/LangCzechModel.cpp
* and adjusted to language specific support.
*/

namespace UtfUnknown.Core.Models.SingleByte.Czech
{
    public class Mac_Centraleurope_CzechModel : CzechModel
    {
        // Generated by BuildLangModel.py
        // On: 2016-09-21 03:28:11.733089

        // Character Mapping Table:
        // ILL: illegal character.
        // CTR: control character specific to the charset.
        // RET: carriage/return.
        // SYM: symbol (punctuation) that does not belong to word.
        // NUM: 0 - 9.

        // Other characters are ordered by probabilities
        // (0 is the most common character in the language).

        // Orders are generic to a language. So the codepoint with order X in
        // CHARSET1 maps to the same character as the codepoint with the same
        // order X in CHARSET2 for the same language.
        // As such, it is possible to get missing order. For instance the
        // ligature of 'o' and 'e' exists in ISO-8859-15 but not in ISO-8859-1
        // even though they are both used for French. Same for the euro sign.

        private static byte[] CHAR_TO_ORDER_MAP = {
          CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,RET,CTR,CTR,RET,CTR,CTR, /* 0X */
          CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR, /* 1X */
          SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM, /* 2X */
          NUM,NUM,NUM,NUM,NUM,NUM,NUM,NUM,NUM,NUM,SYM,SYM,SYM,SYM,SYM,SYM, /* 3X */
          SYM,  3, 22, 14, 15,  1, 30, 32, 17,  4, 21, 12, 10, 16,  2,  0, /* 4X */
            8, 40,  9,  6,  5, 13,  7, 36, 34, 20, 19,SYM,SYM,SYM,SYM,SYM, /* 5X */
          SYM,  3, 22, 14, 15,  1, 30, 32, 17,  4, 21, 12, 10, 16,  2,  0, /* 6X */
            8, 40,  9,  6,  5, 13,  7, 36, 34, 20, 19,SYM,SYM,SYM,SYM,CTR, /* 7X */
           42, 88, 89, 24, 90, 41, 43, 18, 91, 25, 42, 25, 92, 93, 24, 94, /* 8X */
           95, 39, 11, 39, 44, 44, 96, 37, 97, 98, 41, 99, 33, 23, 23, 43, /* 9X */
          SYM,SYM,100,SYM,SYM,SYM,SYM,101,SYM,SYM,SYM,102,SYM,SYM,103,104, /* AX */
          105,106,SYM,SYM,107,108,SYM,SYM,109,110,111, 45, 45,112,113,114, /* BX */
          115,116,SYM,SYM,117, 35,SYM,SYM,SYM,SYM,SYM, 35,118,119,120,121, /* CX */
          SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,122,123,124, 27,SYM,SYM, 27,125, /* DX */
          126, 29,SYM,SYM, 29, 46, 46, 18, 38, 38, 11, 26, 26,127, 37,128, /* EX */
          129, 31, 33, 31,130,131,132,133, 28, 28,134,135,136,137,138,SYM, /* FX */
        };
        /*X0  X1  X2  X3  X4  X5  X6  X7  X8  X9  XA  XB  XC  XD  XE  XF */

        public Mac_Centraleurope_CzechModel() : base(CHAR_TO_ORDER_MAP, Charset.X_MAC_CE)
        {
        }
    }
}
