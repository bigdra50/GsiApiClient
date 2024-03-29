﻿using System;

namespace GsiApiClient.Runtime
{
    /// <summary>
    /// 楕円体
    /// </summary>
    public enum Ellipsoid
    {
        Grs80,
        Bessel,
    }

    public enum OutputType
    {
        Json,
        Xml,
    }

    internal readonly struct RequestGeoidParams
    {
        private readonly OutputType _outputType;
        private readonly double _latitude;
        private readonly double _longitude;

        public RequestGeoidParams(
            OutputType outputType,
            double latitude,
            double longitude)
        {
            _outputType = outputType;
            _latitude = latitude;
            _longitude = longitude;
        }

        public string ToQuery()
        {
            var outputType = _outputType switch
            {
                OutputType.Json => "json",
                OutputType.Xml => "xml",
                _ => throw new ArgumentOutOfRangeException()
            };
            return $"?outputType={outputType}&latitude={_latitude}&longitude={_longitude}";
        }
    }

    internal readonly struct RequestDistanceParams
    {
        private readonly OutputType _outputType;
        private readonly Ellipsoid _ellipsoid;
        private readonly double _latitude1;
        private readonly double _longitude1;
        private readonly double _latitude2;
        private readonly double _longitude2;

        public RequestDistanceParams(
            OutputType outputType,
            Ellipsoid ellipsoid,
            double fromLat, double fromLgt,
            double toLat, double toLgt)
        {
            _outputType = outputType;
            _ellipsoid = ellipsoid;
            _latitude1 = fromLat;
            _longitude1 = fromLgt;
            _latitude2 = toLat;
            _longitude2 = toLgt;
        }

        public string ToQuery()
        {
            var outputType = _outputType switch
            {
                OutputType.Json => "json",
                OutputType.Xml => "xml",
                _ => throw new ArgumentOutOfRangeException()
            };
            var ellipsoid = _ellipsoid switch
            {
                Ellipsoid.Grs80 => "GRS80",
                Ellipsoid.Bessel => "bessel",
                _ => throw new ArgumentOutOfRangeException()
            };
            return
                $"?outputType={outputType}&ellipsoid={ellipsoid}&latitude1={_latitude1}&longitude1={_longitude1}&latitude2={_latitude2}&longitude2={_longitude2}";
        }
    }

    internal readonly struct RequestAddressParams
    {
        private readonly double _latitude;
        private readonly double _longitude;

        public RequestAddressParams(double latitude, double longitude)
        {
            _latitude = latitude;
            _longitude = longitude;
        }

        public string ToQuery() => $"?lat={_latitude}&lon={_longitude}";
    }

    internal readonly struct RequestElevationParams
    {
        private readonly double _latitude;
        private readonly double _longitude;
        private readonly OutputType _outputType;

        public RequestElevationParams(OutputType outputType,double latitude, double longitude)
        {
            _outputType = outputType;
            _latitude = latitude;
            _longitude = longitude;
        }

        public string ToQuery()
        {
            var outputType = _outputType switch
            {
                OutputType.Json => "JSON",
                OutputType.Xml => "XML",
                _ => throw new ArgumentOutOfRangeException()
            };
            return $"?outtype={outputType}&lat={_latitude}&lon={_longitude}";
        }
    }
}