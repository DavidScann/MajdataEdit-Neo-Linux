using MajSimai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajdataEdit_Neo.Types;

internal class MutSimaiCommand(string prefix, string value)
{
    public string Prefix { get; set; } = prefix;
    public string Value { get; set; } = value;

    public static implicit operator SimaiCommand(MutSimaiCommand custom)
    {
        return new SimaiCommand(custom.Prefix, custom.Value);
    }
}
