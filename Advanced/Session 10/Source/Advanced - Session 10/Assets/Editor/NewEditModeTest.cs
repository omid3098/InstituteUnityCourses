using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class NewEditModeTest
{

    [Test]
    public void NewEditModeTestSimplePasses()
    {
        // Use the Assert class to test conditions.
        var q = 10;
        Assert.AreEqual(q, 9);
    }
}
