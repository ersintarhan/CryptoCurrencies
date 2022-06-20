using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CryptoCurrencies
{
    public class CryptoCurrency : IEquatable<CryptoCurrency>, IEquatable<string>
    {
        internal CryptoCurrency(string symbol, string name, bool mainNet, bool testNet, bool segwit, int type, string defaultPath, string pathFormat)
        {
            this.IsValid = true;
            this.Symbol = symbol;
            this.Name = name;
            this.MainNet = mainNet;
            this.TestNet = testNet;
            this.Segwit = segwit;
            this.Type = type;
            this.DefaultPath = defaultPath;
            this.PathFormat = pathFormat;
        }

        internal CryptoCurrency()
        {
            this.IsValid = false;
            this.Symbol = string.Empty;
            this.Name = string.Empty;
            this.MainNet = false;
            this.TestNet = false;
            this.Segwit = false;
            this.Type = 0;
            this.DefaultPath = string.Empty;
            this.PathFormat = string.Empty;
        }

        public bool IsValid { get; }
        public string Symbol { get; }
        public string Name { get; }
        public bool MainNet { get; }
        public bool TestNet { get; }
        public bool Segwit { get; }
        public int Type { get; }
        public string DefaultPath { get; }
        public string PathFormat { get; }

        public bool Equals(CryptoCurrency? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return this.Symbol == other.Symbol;
        }

        public bool Equals(string? other)
        {
            if (string.IsNullOrEmpty(other))
            {
                return false;
            }

            return this.Symbol == other;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((CryptoCurrency)obj);
        }

        public override int GetHashCode()
        {
            return this.Symbol.GetHashCode();
        }

        public static bool operator ==(CryptoCurrency? left, CryptoCurrency? right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CryptoCurrency? left, CryptoCurrency? right)
        {
            return !Equals(left, right);
        }

        public static bool operator ==(CryptoCurrency? left, string? right)
        {
            return left is { } && left.Symbol.Equals(right);
        }

        public static bool operator !=(CryptoCurrency? left, string? right)
        {
            if (left is null)
            {
                return false;
            }

            return !left.Symbol.Equals(right);
        }

        public static implicit operator CryptoCurrency(string symbol)
        {
            return symbol.GetCryptoCurrency();
        }

        public static implicit operator string(CryptoCurrency symbol)
        {
            return symbol.Symbol;
        }


        public static IEnumerable<CryptoCurrency> GetAllCryptoCurrencies()
        {
            return CryptoCurrencyInternal.GetAll();
        }

        public static IEnumerable<CryptoCurrency> GetMainNetCurrencies()
        {
            return CryptoCurrencyInternal.GetMainNets();
        }

        public static IEnumerable<CryptoCurrency> GetTestNetCurrencies()
        {
            return CryptoCurrencyInternal.GetTestNets();
        }

        public string Dump() => $"{nameof(this.IsValid)}: {this.IsValid}, {nameof(this.Symbol)}: {this.Symbol}, {nameof(this.Name)}: {this.Name}, {nameof(this.MainNet)}: {this.MainNet}, {nameof(this.TestNet)}: {this.TestNet}, {nameof(this.Segwit)}: {this.Segwit}, {nameof(this.Type)}: {this.Type}, {nameof(this.DefaultPath)}: {this.DefaultPath}, {nameof(this.PathFormat)}: {this.PathFormat}";

        public string ToJson()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("{");
            stringBuilder.AppendFormat("\"{0}\":", nameof(IsValid));
            stringBuilder.AppendFormat("{0},", IsValid.ToString().ToLowerInvariant());
            stringBuilder.AppendFormat("\"{0}\":", nameof(Symbol));
            stringBuilder.AppendFormat("\"{0}\",", Symbol);
            stringBuilder.AppendFormat("\"{0}\":", nameof(Name));
            stringBuilder.AppendFormat("\"{0}\",", Name);
            stringBuilder.AppendFormat("\"{0}\":", nameof(MainNet));
            stringBuilder.AppendFormat("{0},", MainNet.ToString().ToLowerInvariant());
            stringBuilder.AppendFormat("\"{0}\":", nameof(TestNet));
            stringBuilder.AppendFormat("{0},", TestNet.ToString().ToLowerInvariant());
            stringBuilder.AppendFormat("\"{0}\":", nameof(Segwit));
            stringBuilder.AppendFormat("{0},", Segwit.ToString().ToLowerInvariant());
            stringBuilder.AppendFormat("\"{0}\":", nameof(Type));
            stringBuilder.AppendFormat("{0},", Type.ToString().ToLowerInvariant());
            stringBuilder.AppendFormat("\"{0}\":", nameof(DefaultPath));
            stringBuilder.AppendFormat("\"{0}\",", DefaultPath);
            stringBuilder.AppendFormat("\"{0}\":", nameof(PathFormat));
            stringBuilder.AppendFormat("\"{0}\"", PathFormat);
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }
    }
}