/*
 * 国土地理院測量計算API
 *
 * 国土地理院が提供する測量計算のためのREST API
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using GsiApi.Client;
using GsiApi.Api;
// uncomment below to import models
//using GsiApi.Model;

namespace GsiApi.Test.Api
{
    /// <summary>
    ///  Class for testing PatchjgdApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PatchjgdApiTests : IDisposable
    {
        private PatchjgdApi instance;

        public PatchjgdApiTests()
        {
            instance = new PatchjgdApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PatchjgdApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PatchjgdApi
            //Assert.IsType<PatchjgdApi>(instance);
        }

        /// <summary>
        /// Test PatchjgdHPatchjgdPhpGet
        /// </summary>
        [Fact]
        public void PatchjgdHPatchjgdPhpGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string outputType = null;
            //string chiiki = null;
            //int sokuchi = null;
            //int place = null;
            //double latitude = null;
            //double longitude = null;
            //float? altitude1 = null;
            //int? zone = null;
            //double? publicX = null;
            //double? publicY = null;
            //float? altitude2 = null;
            //var response = instance.PatchjgdHPatchjgdPhpGet(outputType, chiiki, sokuchi, place, latitude, longitude, altitude1, zone, publicX, publicY, altitude2);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test PatchjgdPatchjgdPhpGet
        /// </summary>
        [Fact]
        public void PatchjgdPatchjgdPhpGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string outputType = null;
            //string chiiki = null;
            //int sokuchi = null;
            //int place = null;
            //double latitude = null;
            //double longitude = null;
            //int? zone = null;
            //double? publicX = null;
            //double? publicY = null;
            //var response = instance.PatchjgdPatchjgdPhpGet(outputType, chiiki, sokuchi, place, latitude, longitude, zone, publicX, publicY);
            //Assert.IsType<Object>(response);
        }
    }
}