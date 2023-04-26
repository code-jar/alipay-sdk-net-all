/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 1.0
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

using AlipaySDKNet.OpenAPI.Client;
using AlipaySDKNet.OpenAPI.Api;
using AlipaySDKNet.OpenAPI.Model;
using AlipaySDKNet.OpenAPI.Util;
using AlipaySDKNet.OpenAPI.Util.Model;

// uncomment below to import models
//using AlipaySDKNet.OpenAPI.Model;
//using AlipaySDKNet.OpenAPI.Util;
//using AlipaySDKNet.OpenAPI.Util.Model;
//using Newtonsoft.Json;

namespace AlipaySDKNet.OpenAPI.Test.Api
{
    /// <summary>
    ///  Class for testing AlipayOpenFileApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AlipayOpenFileApiTests : IDisposable
    {
        // private AlipayOpenFileApi instance;

        public AlipayOpenFileApiTests()
        {
            // instance = new AlipayOpenFileApi();
            AlipayConfig alipayConfig = new AlipayConfig();
            // alipayConfig.AppId = "";
            // alipayConfig.PrivateKey = "";
            // alipayConfig.AlipayPublicKey = "";
            // // alipayConfig.EncryptKey = "";
            alipayConfig.AppId = "2021003126677278";
            alipayConfig.PrivateKey = "";
            alipayConfig.AlipayPublicKey = "";
            // alipayConfig.EncryptKey = "";
            AlipayConfigUtil alipayConfigUtil = new AlipayConfigUtil(alipayConfig);
            // instance.Client.SetAlipayConfigUtil(alipayConfigUtil);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AlipayOpenFileApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AlipayOpenFileApi
            //Assert.IsType<AlipayOpenFileApi>(instance);
        }

        /// <summary>
        /// Test Upload
        /// </summary>
        [Fact]
        public void UploadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            // string returnUrl = "111";
            // string notifyUrl = "222";
            // AlipayOpenFileUploadModel data = new AlipayOpenFileUploadModel();
            // data.BizCode = "content_creation";
            // System.IO.Stream fileContent =
            //     new FileStream(
            //         "AlipaySDKNet.OpenAPI.Test/Cert/pic.jpg",
            //         FileMode.Open, FileAccess.Read);
            // var response = instance.Upload(returnUrl, notifyUrl, data, fileContent);
            // Assert.IsType<AlipayOpenFileUploadResponseModel>(response);
        }
    }
}
