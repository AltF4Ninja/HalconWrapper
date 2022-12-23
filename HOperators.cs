using HalconDotNet;
namespace HalconWrapper
{
	public static class Operators
	{
		public static void ClearTextureInspectionResult (HTuple textureInspectionResultID)
		{
			HOperatorSet.ClearTextureInspectionResult(textureInspectionResultID);
		}
		public static (HTuple rowWindow, HTuple columnWindow) ConvertCoordinatesImageToWindow (HTuple windowHandle, HTuple rowImage, HTuple columnImage)
		{
			HOperatorSet.ConvertCoordinatesImageToWindow(windowHandle, rowImage, columnImage, out HTuple rowWindow, out HTuple columnWindow);
			return (rowWindow,columnWindow);
		}
		public static (HTuple rowImage, HTuple columnImage) ConvertCoordinatesWindowToImage (HTuple windowHandle, HTuple rowWindow, HTuple columnWindow)
		{
			HOperatorSet.ConvertCoordinatesWindowToImage(windowHandle, rowWindow, columnWindow, out HTuple rowImage, out HTuple columnImage);
			return (rowImage,columnImage);
		}
		public static HTuple CreateTextureInspectionModel (HTuple modelType)
		{
			HOperatorSet.CreateTextureInspectionModel(modelType, out HTuple textureInspectionModel);
			return textureInspectionModel;
		}
		public static HTuple DeserializeDualQuat (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeDualQuat(serializedItemHandle, out HTuple dualQuaternion);
			return dualQuaternion;
		}
		public static HTuple DeserializeOcrClassCnn (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeOcrClassCnn(serializedItemHandle, out HTuple OCRHandle);
			return OCRHandle;
		}
		public static HTuple DeserializeTextureInspectionModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeTextureInspectionModel(serializedItemHandle, out HTuple textureInspectionModel);
			return textureInspectionModel;
		}
		public static void DispText (HTuple windowHandle, HTuple stringVal, HTuple coordSystem, HTuple row, HTuple column, HTuple color, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.DispText(windowHandle, stringVal, coordSystem, row, column, color, genParamName, genParamValue);
		}
		public static (HTuple classVal, HTuple confidence) DoOcrMultiClassCnn (HObject character, HObject image, HTuple OCRHandle)
		{
			HOperatorSet.DoOcrMultiClassCnn(character, image, OCRHandle, out HTuple classVal, out HTuple confidence);
			return (classVal,confidence);
		}
		public static (HTuple classVal, HTuple confidence) DoOcrSingleClassCnn (HObject character, HObject image, HTuple OCRHandle, HTuple num)
		{
			HOperatorSet.DoOcrSingleClassCnn(character, image, OCRHandle, num, out HTuple classVal, out HTuple confidence);
			return (classVal,confidence);
		}
		public static (HTuple classVal, HTuple confidence, HTuple word, HTuple score) DoOcrWordCnn (HObject character, HObject image, HTuple OCRHandle, HTuple expression, HTuple numAlternatives, HTuple numCorrections)
		{
			HOperatorSet.DoOcrWordCnn(character, image, OCRHandle, expression, numAlternatives, numCorrections, out HTuple classVal, out HTuple confidence, out HTuple word, out HTuple score);
			return (classVal,confidence,word,score);
		}
		public static HTuple DualQuatCompose (HTuple dualQuaternionLeft, HTuple dualQuaternionRight)
		{
			HOperatorSet.DualQuatCompose(dualQuaternionLeft, dualQuaternionRight, out HTuple dualQuaternionComposed);
			return dualQuaternionComposed;
		}
		public static HTuple DualQuatConjugate (HTuple dualQuaternion)
		{
			HOperatorSet.DualQuatConjugate(dualQuaternion, out HTuple dualQuaternionConjugate);
			return dualQuaternionConjugate;
		}
		public static HTuple DualQuatInterpolate (HTuple dualQuaternionStart, HTuple dualQuaternionEnd, HTuple interpPos)
		{
			HOperatorSet.DualQuatInterpolate(dualQuaternionStart, dualQuaternionEnd, interpPos, out HTuple dualQuaternionInterpolated);
			return dualQuaternionInterpolated;
		}
		public static HTuple DualQuatNormalize (HTuple dualQuaternion)
		{
			HOperatorSet.DualQuatNormalize(dualQuaternion, out HTuple dualQuaternionNormalized);
			return dualQuaternionNormalized;
		}
		public static HTuple DualQuatToHomMat3d (HTuple dualQuaternion)
		{
			HOperatorSet.DualQuatToHomMat3d(dualQuaternion, out HTuple homMat3D);
			return homMat3D;
		}
		public static HTuple DualQuatToPose (HTuple dualQuaternion)
		{
			HOperatorSet.DualQuatToPose(dualQuaternion, out HTuple pose);
			return pose;
		}
		public static (HTuple axisDirectionX, HTuple axisDirectionY, HTuple axisDirectionZ, HTuple axisMomentOrPointX, HTuple axisMomentOrPointY, HTuple axisMomentOrPointZ, HTuple rotation, HTuple translation) DualQuatToScrew (HTuple dualQuaternion, HTuple screwFormat)
		{
			HOperatorSet.DualQuatToScrew(dualQuaternion, screwFormat, out HTuple axisDirectionX, out HTuple axisDirectionY, out HTuple axisDirectionZ, out HTuple axisMomentOrPointX, out HTuple axisMomentOrPointY, out HTuple axisMomentOrPointZ, out HTuple rotation, out HTuple translation);
			return (axisDirectionX,axisDirectionY,axisDirectionZ,axisMomentOrPointX,axisMomentOrPointY,axisMomentOrPointZ,rotation,translation);
		}
		public static (HTuple transLineDirectionX, HTuple transLineDirectionY, HTuple transLineDirectionZ, HTuple transLineMomentOrPointX, HTuple transLineMomentOrPointY, HTuple transLineMomentOrPointZ) DualQuatTransLine3d (HTuple dualQuaternion, HTuple lineFormat, HTuple lineDirectionX, HTuple lineDirectionY, HTuple lineDirectionZ, HTuple lineMomentOrPointX, HTuple lineMomentOrPointY, HTuple lineMomentOrPointZ)
		{
			HOperatorSet.DualQuatTransLine3d(dualQuaternion, lineFormat, lineDirectionX, lineDirectionY, lineDirectionZ, lineMomentOrPointX, lineMomentOrPointY, lineMomentOrPointZ, out HTuple transLineDirectionX, out HTuple transLineDirectionY, out HTuple transLineDirectionZ, out HTuple transLineMomentOrPointX, out HTuple transLineMomentOrPointY, out HTuple transLineMomentOrPointZ);
			return (transLineDirectionX,transLineDirectionY,transLineDirectionZ,transLineMomentOrPointX,transLineMomentOrPointY,transLineMomentOrPointZ);
		}
		public static HTuple EdgesObjectModel3d (HTuple objectModel3D, HTuple minAmplitude, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.EdgesObjectModel3d(objectModel3D, minAmplitude, genParamName, genParamValue, out HTuple objectModel3DEdges);
			return objectModel3DEdges;
		}
		public static (HTuple row, HTuple column, HTuple angle, HTuple score, HTuple model) FindNccModels (HObject image, HTuple modelIDs, HTuple angleStart, HTuple angleExtent, HTuple minScore, HTuple numMatches, HTuple maxOverlap, HTuple subPixel, HTuple numLevels)
		{
			HOperatorSet.FindNccModels(image, modelIDs, angleStart, angleExtent, minScore, numMatches, maxOverlap, subPixel, numLevels, out HTuple row, out HTuple column, out HTuple angle, out HTuple score, out HTuple model);
			return (row,column,angle,score,model);
		}
		public static (HTuple pose, HTuple score, HTuple surfaceMatchingResultID) FindSurfaceModelImage (HObject image, HTuple surfaceModelID, HTuple objectModel3D, HTuple relSamplingDistance, HTuple keyPointFraction, HTuple minScore, HTuple returnResultHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.FindSurfaceModelImage(image, surfaceModelID, objectModel3D, relSamplingDistance, keyPointFraction, minScore, returnResultHandle, genParamName, genParamValue, out HTuple pose, out HTuple score, out HTuple surfaceMatchingResultID);
			return (pose,score,surfaceMatchingResultID);
		}
		public static void FlushBuffer (HTuple windowHandle)
		{
			HOperatorSet.FlushBuffer(windowHandle);
		}
		public static HObject GetNccModelRegion (HTuple modelID)
		{
			HOperatorSet.GetNccModelRegion(out HObject modelRegion, modelID);
			return modelRegion;
		}
		public static HTuple GetParamsOcrClassCnn (HTuple OCRHandle, HTuple genParamName)
		{
			HOperatorSet.GetParamsOcrClassCnn(OCRHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static (HTuple red, HTuple green, HTuple blue, HTuple alpha) GetRgba (HTuple windowHandle)
		{
			HOperatorSet.GetRgba(windowHandle, out HTuple red, out HTuple green, out HTuple blue, out HTuple alpha);
			return (red,green,blue,alpha);
		}
		public static HTuple GetStereoModelObjectModel3d (HTuple stereoModelID, HTuple genParamName)
		{
			HOperatorSet.GetStereoModelObjectModel3d(stereoModelID, genParamName, out HTuple objectModel3D);
			return objectModel3D;
		}
		public static HObject GetTextureInspectionModelImage (HTuple textureInspectionModel)
		{
			HOperatorSet.GetTextureInspectionModelImage(out HObject imageOut, textureInspectionModel);
			return imageOut;
		}
		public static HTuple GetTextureInspectionModelParam (HTuple textureInspectionModel, HTuple genParamName)
		{
			HOperatorSet.GetTextureInspectionModelParam(textureInspectionModel, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static HObject GetTextureInspectionResultObject (HTuple textureInspectionResultID, HTuple resultName)
		{
			HOperatorSet.GetTextureInspectionResultObject(out HObject objectVal, textureInspectionResultID, resultName);
			return objectVal;
		}
		public static HObject GuidedFilter (HObject image, HObject imageGuide, HTuple radius, HTuple amplitude)
		{
			HOperatorSet.GuidedFilter(image, imageGuide, out HObject imageGuided, radius, amplitude);
			return imageGuided;
		}
		public static HObject InterleaveChannels (HObject multichannelImage, HTuple pixelFormat, HTuple rowBytes, HTuple alpha)
		{
			HOperatorSet.InterleaveChannels(multichannelImage, out HObject interleavedImage, pixelFormat, rowBytes, alpha);
			return interleavedImage;
		}
		public static HTuple PoseToDualQuat (HTuple pose)
		{
			HOperatorSet.PoseToDualQuat(pose, out HTuple dualQuaternion);
			return dualQuaternion;
		}
		public static HTuple QueryParamsOcrClassCnn (HTuple OCRHandle)
		{
			HOperatorSet.QueryParamsOcrClassCnn(OCRHandle, out HTuple genParamName);
			return genParamName;
		}
		public static HTuple ReadOcrClassCnn (HTuple fileName)
		{
			HOperatorSet.ReadOcrClassCnn(fileName, out HTuple OCRHandle);
			return OCRHandle;
		}
		public static HTuple ReadTextureInspectionModel (HTuple fileName)
		{
			HOperatorSet.ReadTextureInspectionModel(fileName, out HTuple textureInspectionModel);
			return textureInspectionModel;
		}
		public static (HTuple pose, HTuple score, HTuple surfaceMatchingResultID) RefineSurfaceModelPoseImage (HObject image, HTuple surfaceModelID, HTuple objectModel3D, HTuple initialPose, HTuple minScore, HTuple returnResultHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.RefineSurfaceModelPoseImage(image, surfaceModelID, objectModel3D, initialPose, minScore, returnResultHandle, genParamName, genParamValue, out HTuple pose, out HTuple score, out HTuple surfaceMatchingResultID);
			return (pose,score,surfaceMatchingResultID);
		}
		public static HTuple RemoveTextureInspectionModelImage (HTuple textureInspectionModel, HTuple indices)
		{
			HOperatorSet.RemoveTextureInspectionModelImage(textureInspectionModel, indices, out HTuple remainingIndices);
			return remainingIndices;
		}
		public static HTuple ScrewToDualQuat (HTuple screwFormat, HTuple axisDirectionX, HTuple axisDirectionY, HTuple axisDirectionZ, HTuple axisMomentOrPointX, HTuple axisMomentOrPointY, HTuple axisMomentOrPointZ, HTuple rotation, HTuple translation)
		{
			HOperatorSet.ScrewToDualQuat(screwFormat, axisDirectionX, axisDirectionY, axisDirectionZ, axisMomentOrPointX, axisMomentOrPointY, axisMomentOrPointZ, rotation, translation, out HTuple dualQuaternion);
			return dualQuaternion;
		}
		public static (HObject MSERDark, HObject MSERLight) SegmentImageMser (HObject image, HTuple polarity, HTuple minArea, HTuple maxArea, HTuple delta, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SegmentImageMser(image, out HObject MSERDark, out HObject MSERLight, polarity, minArea, maxArea, delta, genParamName, genParamValue);
			return (MSERDark,MSERLight);
		}
		public static HTuple SendMouseDoubleClickEvent (HTuple windowHandle, HTuple row, HTuple column, HTuple button)
		{
			HOperatorSet.SendMouseDoubleClickEvent(windowHandle, row, column, button, out HTuple processed);
			return processed;
		}
		public static HTuple SendMouseDownEvent (HTuple windowHandle, HTuple row, HTuple column, HTuple button)
		{
			HOperatorSet.SendMouseDownEvent(windowHandle, row, column, button, out HTuple processed);
			return processed;
		}
		public static HTuple SendMouseDragEvent (HTuple windowHandle, HTuple row, HTuple column, HTuple button)
		{
			HOperatorSet.SendMouseDragEvent(windowHandle, row, column, button, out HTuple processed);
			return processed;
		}
		public static HTuple SendMouseUpEvent (HTuple windowHandle, HTuple row, HTuple column, HTuple button)
		{
			HOperatorSet.SendMouseUpEvent(windowHandle, row, column, button, out HTuple processed);
			return processed;
		}
		public static HTuple SerializeDualQuat (HTuple dualQuaternion)
		{
			HOperatorSet.SerializeDualQuat(dualQuaternion, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple SerializeOcrClassCnn (HTuple OCRHandle)
		{
			HOperatorSet.SerializeOcrClassCnn(OCRHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple SerializeTextureInspectionModel (HTuple textureInspectionModel)
		{
			HOperatorSet.SerializeTextureInspectionModel(textureInspectionModel, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static void SetContentUpdateCallback (HTuple windowHandle, HTuple callbackFunction, HTuple callbackContext)
		{
			HOperatorSet.SetContentUpdateCallback(windowHandle, callbackFunction, callbackContext);
		}
		public static void SetRgba (HTuple windowHandle, HTuple red, HTuple green, HTuple blue, HTuple alpha)
		{
			HOperatorSet.SetRgba(windowHandle, red, green, blue, alpha);
		}
		public static void SetSurfaceModelParam (HTuple surfaceModelID, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetSurfaceModelParam(surfaceModelID, genParamName, genParamValue);
		}
		public static void SetTextureInspectionModelParam (HTuple textureInspectionModel, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetTextureInspectionModelParam(textureInspectionModel, genParamName, genParamValue);
		}
		public static void TrainTextureInspectionModel (HTuple textureInspectionModel)
		{
			HOperatorSet.TrainTextureInspectionModel(textureInspectionModel);
		}
		public static void WriteTextureInspectionModel (HTuple textureInspectionModel, HTuple fileName)
		{
			HOperatorSet.WriteTextureInspectionModel(textureInspectionModel, fileName);
		}
		public static (HObject normalField, HObject gradient, HObject albedo) UncalibratedPhotometricStereo (HObject images, HTuple resultType)
		{
			HOperatorSet.UncalibratedPhotometricStereo(images, out HObject normalField, out HObject gradient, out HObject albedo, resultType);
			return (normalField,gradient,albedo);
		}
		public static HTuple ApplyDlClassifier (HObject images, HTuple DLClassifierHandle)
		{
			HOperatorSet.ApplyDlClassifier(images, DLClassifierHandle, out HTuple DLClassifierResultHandle);
			return DLClassifierResultHandle;
		}
		public static void ClearDlClassifier (HTuple DLClassifierHandle)
		{
			HOperatorSet.ClearDlClassifier(DLClassifierHandle);
		}
		public static void ClearDlClassifierResult (HTuple DLClassifierResultHandle)
		{
			HOperatorSet.ClearDlClassifierResult(DLClassifierResultHandle);
		}
		public static void ClearDlClassifierTrainResult (HTuple DLClassifierTrainResultHandle)
		{
			HOperatorSet.ClearDlClassifierTrainResult(DLClassifierTrainResultHandle);
		}
		public static void ClearStructuredLightModel (HTuple structuredLightModel)
		{
			HOperatorSet.ClearStructuredLightModel(structuredLightModel);
		}
		public static HTuple CreateStructuredLightModel (HTuple modelType)
		{
			HOperatorSet.CreateStructuredLightModel(modelType, out HTuple structuredLightModel);
			return structuredLightModel;
		}
		public static void DecodeStructuredLightPattern (HObject cameraImages, HTuple structuredLightModel)
		{
			HOperatorSet.DecodeStructuredLightPattern(cameraImages, structuredLightModel);
		}
		public static HTuple DeserializeDlClassifier (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeDlClassifier(serializedItemHandle, out HTuple DLClassifierHandle);
			return DLClassifierHandle;
		}
		public static HTuple DeserializeStructuredLightModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeStructuredLightModel(serializedItemHandle, out HTuple structuredLightModel);
			return structuredLightModel;
		}
		public static (HTuple distanceMin, HTuple row1, HTuple column1, HTuple row2, HTuple column2) DistanceCcMinPoints (HObject contour1, HObject contour2, HTuple mode)
		{
			HOperatorSet.DistanceCcMinPoints(contour1, contour2, mode, out HTuple distanceMin, out HTuple row1, out HTuple column1, out HTuple row2, out HTuple column2);
			return (distanceMin,row1,column1,row2,column2);
		}
		public static HTuple FuseObjectModel3d (HTuple objectModel3D, HTuple boundingBox, HTuple resolution, HTuple surfaceTolerance, HTuple minThickness, HTuple smoothing, HTuple normalDirection, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.FuseObjectModel3d(objectModel3D, boundingBox, resolution, surfaceTolerance, minThickness, smoothing, normalDirection, genParamName, genParamValue, out HTuple objectModel3DFusion);
			return objectModel3DFusion;
		}
		public static HObject GenStructuredLightPattern (HTuple structuredLightModel)
		{
			HOperatorSet.GenStructuredLightPattern(out HObject patternImages, structuredLightModel);
			return patternImages;
		}
		public static HTuple GetDlClassifierParam (HTuple DLClassifierHandle, HTuple genParamName)
		{
			HOperatorSet.GetDlClassifierParam(DLClassifierHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static HTuple GetDlClassifierResult (HTuple DLClassifierResultHandle, HTuple index, HTuple genResultName)
		{
			HOperatorSet.GetDlClassifierResult(DLClassifierResultHandle, index, genResultName, out HTuple genResultValue);
			return genResultValue;
		}
		public static HTuple GetDlClassifierTrainResult (HTuple DLClassifierTrainResultHandle, HTuple genParamName)
		{
			HOperatorSet.GetDlClassifierTrainResult(DLClassifierTrainResultHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static HTuple GetStructuredLightModelParam (HTuple structuredLightModel, HTuple genParamName)
		{
			HOperatorSet.GetStructuredLightModelParam(structuredLightModel, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static HObject GetStructuredLightObject (HTuple structuredLightModel, HTuple objectName)
		{
			HOperatorSet.GetStructuredLightObject(out HObject objectVal, structuredLightModel, objectName);
			return objectVal;
		}
		public static (HTuple height, HTuple width, HTuple ratio) HeightWidthRatio (HObject regions)
		{
			HOperatorSet.HeightWidthRatio(regions, out HTuple height, out HTuple width, out HTuple ratio);
			return (height,width,ratio);
		}
		public static (HTuple height, HTuple width, HTuple ratio) HeightWidthRatioXld (HObject XLD)
		{
			HOperatorSet.HeightWidthRatioXld(XLD, out HTuple height, out HTuple width, out HTuple ratio);
			return (height,width,ratio);
		}
		public static HObject InsertObj (HObject objects, HObject objectsInsert, HTuple index)
		{
			HOperatorSet.InsertObj(objects, objectsInsert, out HObject objectsExtended, index);
			return objectsExtended;
		}
		public static HTuple ReadDlClassifier (HTuple fileName)
		{
			HOperatorSet.ReadDlClassifier(fileName, out HTuple DLClassifierHandle);
			return DLClassifierHandle;
		}
		public static HTuple ReadStructuredLightModel (HTuple fileName)
		{
			HOperatorSet.ReadStructuredLightModel(fileName, out HTuple structuredLightModel);
			return structuredLightModel;
		}
		public static HObject RemoveObj (HObject objects, HTuple index)
		{
			HOperatorSet.RemoveObj(objects, out HObject objectsReduced, index);
			return objectsReduced;
		}
		public static HObject ReplaceObj (HObject objects, HObject objectsReplace, HTuple index)
		{
			HOperatorSet.ReplaceObj(objects, objectsReplace, out HObject replaced, index);
			return replaced;
		}
		public static HTuple SerializeDlClassifier (HTuple DLClassifierHandle)
		{
			HOperatorSet.SerializeDlClassifier(DLClassifierHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple SerializeStructuredLightModel (HTuple structuredLightModel)
		{
			HOperatorSet.SerializeStructuredLightModel(structuredLightModel, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static void SetDlClassifierParam (HTuple DLClassifierHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetDlClassifierParam(DLClassifierHandle, genParamName, genParamValue);
		}
		public static void SetOperatorTimeout (HTuple operatorName, HTuple timeout, HTuple mode)
		{
			HOperatorSet.SetOperatorTimeout(operatorName, timeout, mode);
		}
		public static void SetStructuredLightModelParam (HTuple structuredLightModel, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetStructuredLightModelParam(structuredLightModel, genParamName, genParamValue);
		}
		public static HTuple TrainDlClassifierBatch (HObject batchImages, HTuple DLClassifierHandle, HTuple batchLabels)
		{
			HOperatorSet.TrainDlClassifierBatch(batchImages, DLClassifierHandle, batchLabels, out HTuple DLClassifierTrainResultHandle);
			return DLClassifierTrainResultHandle;
		}
		public static void WriteDlClassifier (HTuple DLClassifierHandle, HTuple fileName)
		{
			HOperatorSet.WriteDlClassifier(DLClassifierHandle, fileName);
		}
		public static void WriteStructuredLightModel (HTuple structuredLightModel, HTuple fileName)
		{
			HOperatorSet.WriteStructuredLightModel(structuredLightModel, fileName);
		}
		public static void ClearHandle (HTuple handle)
		{
			HOperatorSet.ClearHandle(handle);
		}
		public static HTuple DeserializeHandle (HTuple serializedItem)
		{
			HOperatorSet.DeserializeHandle(serializedItem, out HTuple handle);
			return handle;
		}
		public static HTuple HandleToInteger (HTuple handle)
		{
			HOperatorSet.HandleToInteger(handle, out HTuple castedHandle);
			return castedHandle;
		}
		public static HTuple IntegerToHandle (HTuple integerHandle)
		{
			HOperatorSet.IntegerToHandle(integerHandle, out HTuple handle);
			return handle;
		}
		public static HTuple SerializeHandle (HTuple handle)
		{
			HOperatorSet.SerializeHandle(handle, out HTuple serializedItem);
			return serializedItem;
		}
		public static HTuple TupleIsHandle (HTuple t)
		{
			HOperatorSet.TupleIsHandle(t, out HTuple isHandle);
			return isHandle;
		}
		public static HTuple TupleIsHandleElem (HTuple t)
		{
			HOperatorSet.TupleIsHandleElem(t, out HTuple isHandle);
			return isHandle;
		}
		public static HTuple TupleIsSerializable (HTuple tuple)
		{
			HOperatorSet.TupleIsSerializable(tuple, out HTuple isSerializable);
			return isSerializable;
		}
		public static HTuple TupleIsSerializableElem (HTuple tuple)
		{
			HOperatorSet.TupleIsSerializableElem(tuple, out HTuple isSerializableElem);
			return isSerializableElem;
		}
		public static HTuple TupleIsValidHandle (HTuple handle)
		{
			HOperatorSet.TupleIsValidHandle(handle, out HTuple isValid);
			return isValid;
		}
		public static HTuple TupleSemType (HTuple t)
		{
			HOperatorSet.TupleSemType(t, out HTuple semType);
			return semType;
		}
		public static HTuple TupleSemTypeElem (HTuple t)
		{
			HOperatorSet.TupleSemTypeElem(t, out HTuple semTypes);
			return semTypes;
		}
		public static HTuple ApplyDlModel (HTuple DLModelHandle, HTuple DLSampleBatch, HTuple outputs)
		{
			HOperatorSet.ApplyDlModel(DLModelHandle, DLSampleBatch, outputs, out HTuple DLResultBatch);
			return DLResultBatch;
		}
		public static void ClearDlModel (HTuple DLModelHandle)
		{
			HOperatorSet.ClearDlModel(DLModelHandle);
		}
		public static HTuple CopyDict (HTuple dictHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CopyDict(dictHandle, genParamName, genParamValue, out HTuple copiedDictHandle);
			return copiedDictHandle;
		}
		public static HTuple CreateDict ()
		{
			HOperatorSet.CreateDict(out HTuple dictHandle);
			return dictHandle;
		}
		public static HTuple CreateDlModelDetection (HTuple backbone, HTuple numClasses, HTuple DLModelDetectionParam)
		{
			HOperatorSet.CreateDlModelDetection(backbone, numClasses, DLModelDetectionParam, out HTuple DLModelHandle);
			return DLModelHandle;
		}
		public static HTuple DeserializeDlModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeDlModel(serializedItemHandle, out HTuple DLModelHandle);
			return DLModelHandle;
		}
		public static HTuple GetCurrentHthreadId ()
		{
			HOperatorSet.GetCurrentHthreadId(out HTuple HThreadID);
			return HThreadID;
		}
		public static HObject GetDictObject (HTuple dictHandle, HTuple key)
		{
			HOperatorSet.GetDictObject(out HObject objectVal, dictHandle, key);
			return objectVal;
		}
		public static HTuple GetDictParam (HTuple dictHandle, HTuple genParamName, HTuple key)
		{
			HOperatorSet.GetDictParam(dictHandle, genParamName, key, out HTuple genParamValue);
			return genParamValue;
		}
		public static HTuple GetDictTuple (HTuple dictHandle, HTuple key)
		{
			HOperatorSet.GetDictTuple(dictHandle, key, out HTuple tuple);
			return tuple;
		}
		public static HTuple GetDlModelParam (HTuple DLModelHandle, HTuple genParamName)
		{
			HOperatorSet.GetDlModelParam(DLModelHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static HObject GetHandleObject (HTuple handle, HTuple key)
		{
			HOperatorSet.GetHandleObject(out HObject objectVal, handle, key);
			return objectVal;
		}
		public static HTuple GetHandleParam (HTuple handle, HTuple genParamName, HTuple key)
		{
			HOperatorSet.GetHandleParam(handle, genParamName, key, out HTuple genParamValue);
			return genParamValue;
		}
		public static HTuple GetHandleTuple (HTuple handle, HTuple key)
		{
			HOperatorSet.GetHandleTuple(handle, key, out HTuple tuple);
			return tuple;
		}
		public static HTuple GetSystemInfo (HTuple query)
		{
			HOperatorSet.GetSystemInfo(query, out HTuple information);
			return information;
		}
		public static void InterruptOperator (HTuple HThreadID, HTuple mode)
		{
			HOperatorSet.InterruptOperator(HThreadID, mode);
		}
		public static HTuple ReadDict (HTuple fileName, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.ReadDict(fileName, genParamName, genParamValue, out HTuple dictHandle);
			return dictHandle;
		}
		public static HTuple ReadDlModel (HTuple fileName)
		{
			HOperatorSet.ReadDlModel(fileName, out HTuple DLModelHandle);
			return DLModelHandle;
		}
		public static HTuple ReadMessage (HTuple fileName, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.ReadMessage(fileName, genParamName, genParamValue, out HTuple messageHandle);
			return messageHandle;
		}
		public static void RemoveDictKey (HTuple dictHandle, HTuple key)
		{
			HOperatorSet.RemoveDictKey(dictHandle, key);
		}
		public static void SendKeyPressEvent (HTuple windowHandle, HTuple charVal, HTuple code)
		{
			HOperatorSet.SendKeyPressEvent(windowHandle, charVal, code);
		}
		public static void SendKeyReleaseEvent (HTuple windowHandle, HTuple charVal, HTuple code)
		{
			HOperatorSet.SendKeyReleaseEvent(windowHandle, charVal, code);
		}
		public static HTuple SerializeDlModel (HTuple DLModelHandle)
		{
			HOperatorSet.SerializeDlModel(DLModelHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static void SetDictObject (HObject objectVal, HTuple dictHandle, HTuple key)
		{
			HOperatorSet.SetDictObject(objectVal, dictHandle, key);
		}
		public static void SetDictTuple (HTuple dictHandle, HTuple key, HTuple tuple)
		{
			HOperatorSet.SetDictTuple(dictHandle, key, tuple);
		}
		public static void SetDlModelParam (HTuple DLModelHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetDlModelParam(DLModelHandle, genParamName, genParamValue);
		}
		public static HTuple TrainDlModelBatch (HTuple DLModelHandle, HTuple DLSampleBatch)
		{
			HOperatorSet.TrainDlModelBatch(DLModelHandle, DLSampleBatch, out HTuple DLTrainResult);
			return DLTrainResult;
		}
		public static void WriteDict (HTuple dictHandle, HTuple fileName, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.WriteDict(dictHandle, fileName, genParamName, genParamValue);
		}
		public static void WriteDlModel (HTuple DLModelHandle, HTuple fileName)
		{
			HOperatorSet.WriteDlModel(DLModelHandle, fileName);
		}
		public static void WriteMessage (HTuple messageHandle, HTuple fileName, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.WriteMessage(messageHandle, fileName, genParamName, genParamValue);
		}
		public static HTuple ConvertPoseType (HTuple poseIn, HTuple orderOfTransform, HTuple orderOfRotation, HTuple viewOfTransform)
		{
			HOperatorSet.ConvertPoseType(poseIn, orderOfTransform, orderOfRotation, viewOfTransform, out HTuple poseOut);
			return poseOut;
		}
		public static HTuple CreatePose (HTuple transX, HTuple transY, HTuple transZ, HTuple rotX, HTuple rotY, HTuple rotZ, HTuple orderOfTransform, HTuple orderOfRotation, HTuple viewOfTransform)
		{
			HOperatorSet.CreatePose(transX, transY, transZ, rotX, rotY, rotZ, orderOfTransform, orderOfRotation, viewOfTransform, out HTuple pose);
			return pose;
		}
		public static HObject ChangeRadialDistortionContoursXld (HObject contours, HTuple camParamIn, HTuple camParamOut)
		{
			HOperatorSet.ChangeRadialDistortionContoursXld(contours, out HObject contoursRectified, camParamIn, camParamOut);
			return contoursRectified;
		}
		public static (HTuple rowChanged, HTuple colChanged) ChangeRadialDistortionPoints (HTuple row, HTuple col, HTuple camParamIn, HTuple camParamOut)
		{
			HOperatorSet.ChangeRadialDistortionPoints(row, col, camParamIn, camParamOut, out HTuple rowChanged, out HTuple colChanged);
			return (rowChanged,colChanged);
		}
		public static HObject ChangeRadialDistortionImage (HObject image, HObject region, HTuple camParamIn, HTuple camParamOut)
		{
			HOperatorSet.ChangeRadialDistortionImage(image, region, out HObject imageRectified, camParamIn, camParamOut);
			return imageRectified;
		}
		public static HTuple ChangeRadialDistortionCamPar (HTuple mode, HTuple camParamIn, HTuple distortionCoeffs)
		{
			HOperatorSet.ChangeRadialDistortionCamPar(mode, camParamIn, distortionCoeffs, out HTuple camParamOut);
			return camParamOut;
		}
		public static void GenCaltab (HTuple XNum, HTuple YNum, HTuple markDist, HTuple diameterRatio, HTuple calPlateDescr, HTuple calPlatePSFile)
		{
			HOperatorSet.GenCaltab(XNum, YNum, markDist, diameterRatio, calPlateDescr, calPlatePSFile);
		}
		public static void CreateCaltab (HTuple numRows, HTuple marksPerRow, HTuple diameter, HTuple finderRow, HTuple finderColumn, HTuple polarity, HTuple calPlateDescr, HTuple calPlatePSFile)
		{
			HOperatorSet.CreateCaltab(numRows, marksPerRow, diameter, finderRow, finderColumn, polarity, calPlateDescr, calPlatePSFile);
		}
		public static (HTuple x, HTuple y, HTuple z) CaltabPoints (HTuple calPlateDescr)
		{
			HOperatorSet.CaltabPoints(calPlateDescr, out HTuple x, out HTuple y, out HTuple z);
			return (x,y,z);
		}
		public static (HTuple PX, HTuple PY, HTuple PZ, HTuple QX, HTuple QY, HTuple QZ) GetLineOfSight (HTuple row, HTuple column, HTuple cameraParam)
		{
			HOperatorSet.GetLineOfSight(row, column, cameraParam, out HTuple PX, out HTuple PY, out HTuple PZ, out HTuple QX, out HTuple QY, out HTuple QZ);
			return (PX,PY,PZ,QX,QY,QZ);
		}
		public static (HTuple qx, HTuple qy, HTuple qw) ProjectHomPointHomMat3d (HTuple homMat3D, HTuple px, HTuple py, HTuple pz, HTuple pw)
		{
			HOperatorSet.ProjectHomPointHomMat3d(homMat3D, px, py, pz, pw, out HTuple qx, out HTuple qy, out HTuple qw);
			return (qx,qy,qw);
		}
		public static (HTuple qx, HTuple qy) ProjectPointHomMat3d (HTuple homMat3D, HTuple px, HTuple py, HTuple pz)
		{
			HOperatorSet.ProjectPointHomMat3d(homMat3D, px, py, pz, out HTuple qx, out HTuple qy);
			return (qx,qy);
		}
		public static (HTuple row, HTuple column) Project3dPoint (HTuple x, HTuple y, HTuple z, HTuple cameraParam)
		{
			HOperatorSet.Project3dPoint(x, y, z, cameraParam, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static HTuple CamParPoseToHomMat3d (HTuple cameraParam, HTuple pose)
		{
			HOperatorSet.CamParPoseToHomMat3d(cameraParam, pose, out HTuple homMat3D);
			return homMat3D;
		}
		public static HTuple HomMat3dToPose (HTuple homMat3D)
		{
			HOperatorSet.HomMat3dToPose(homMat3D, out HTuple pose);
			return pose;
		}
		public static HTuple PoseToHomMat3d (HTuple pose)
		{
			HOperatorSet.PoseToHomMat3d(pose, out HTuple homMat3D);
			return homMat3D;
		}
		public static HTuple DeserializeCamPar (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeCamPar(serializedItemHandle, out HTuple cameraParam);
			return cameraParam;
		}
		public static HTuple SerializeCamPar (HTuple cameraParam)
		{
			HOperatorSet.SerializeCamPar(cameraParam, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple DeserializePose (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializePose(serializedItemHandle, out HTuple pose);
			return pose;
		}
		public static HTuple SerializePose (HTuple pose)
		{
			HOperatorSet.SerializePose(pose, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadPose (HTuple poseFile)
		{
			HOperatorSet.ReadPose(poseFile, out HTuple pose);
			return pose;
		}
		public static void WritePose (HTuple pose, HTuple poseFile)
		{
			HOperatorSet.WritePose(pose, poseFile);
		}
		public static HTuple ReadCamPar (HTuple camParFile)
		{
			HOperatorSet.ReadCamPar(camParFile, out HTuple cameraParam);
			return cameraParam;
		}
		public static void WriteCamPar (HTuple cameraParam, HTuple camParFile)
		{
			HOperatorSet.WriteCamPar(cameraParam, camParFile);
		}
		public static HObject SimCaltab (HTuple calPlateDescr, HTuple cameraParam, HTuple calPlatePose, HTuple grayBackground, HTuple grayPlate, HTuple grayMarks, HTuple scaleFac)
		{
			HOperatorSet.SimCaltab(out HObject simImage, calPlateDescr, cameraParam, calPlatePose, grayBackground, grayPlate, grayMarks, scaleFac);
			return simImage;
		}
		public static void DispCaltab (HTuple windowHandle, HTuple calPlateDescr, HTuple cameraParam, HTuple calPlatePose, HTuple scaleFac)
		{
			HOperatorSet.DispCaltab(windowHandle, calPlateDescr, cameraParam, calPlatePose, scaleFac);
		}
		public static (HTuple cameraParam, HTuple NFinalPose, HTuple errors) CameraCalibration (HTuple NX, HTuple NY, HTuple NZ, HTuple NRow, HTuple NCol, HTuple startCamParam, HTuple NStartPose, HTuple estimateParams)
		{
			HOperatorSet.CameraCalibration(NX, NY, NZ, NRow, NCol, startCamParam, NStartPose, estimateParams, out HTuple cameraParam, out HTuple NFinalPose, out HTuple errors);
			return (cameraParam,NFinalPose,errors);
		}
		public static (HTuple RCoord, HTuple CCoord, HTuple startPose) FindMarksAndPose (HObject image, HObject calPlateRegion, HTuple calPlateDescr, HTuple startCamParam, HTuple startThresh, HTuple deltaThresh, HTuple minThresh, HTuple alpha, HTuple minContLength, HTuple maxDiamMarks)
		{
			HOperatorSet.FindMarksAndPose(image, calPlateRegion, calPlateDescr, startCamParam, startThresh, deltaThresh, minThresh, alpha, minContLength, maxDiamMarks, out HTuple RCoord, out HTuple CCoord, out HTuple startPose);
			return (RCoord,CCoord,startPose);
		}
		public static HObject FindCaltab (HObject image, HTuple calPlateDescr, HTuple sizeGauss, HTuple markThresh, HTuple minDiamMarks)
		{
			HOperatorSet.FindCaltab(image, out HObject calPlate, calPlateDescr, sizeGauss, markThresh, minDiamMarks);
			return calPlate;
		}
		public static void ClearAllCameraSetupModels ()
		{
			HOperatorSet.ClearAllCameraSetupModels();
		}
		public static void ClearCameraSetupModel (HTuple cameraSetupModelID)
		{
			HOperatorSet.ClearCameraSetupModel(cameraSetupModelID);
		}
		public static HTuple SerializeCameraSetupModel (HTuple cameraSetupModelID)
		{
			HOperatorSet.SerializeCameraSetupModel(cameraSetupModelID, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple DeserializeCameraSetupModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeCameraSetupModel(serializedItemHandle, out HTuple cameraSetupModelID);
			return cameraSetupModelID;
		}
		public static void WriteCameraSetupModel (HTuple cameraSetupModelID, HTuple fileName)
		{
			HOperatorSet.WriteCameraSetupModel(cameraSetupModelID, fileName);
		}
		public static HTuple ReadCameraSetupModel (HTuple fileName)
		{
			HOperatorSet.ReadCameraSetupModel(fileName, out HTuple cameraSetupModelID);
			return cameraSetupModelID;
		}
		public static HTuple GetCameraSetupParam (HTuple cameraSetupModelID, HTuple cameraIdx, HTuple genParamName)
		{
			HOperatorSet.GetCameraSetupParam(cameraSetupModelID, cameraIdx, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetCameraSetupParam (HTuple cameraSetupModelID, HTuple cameraIdx, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetCameraSetupParam(cameraSetupModelID, cameraIdx, genParamName, genParamValue);
		}
		public static void SetCameraSetupCamParam (HTuple cameraSetupModelID, HTuple cameraIdx, HTuple cameraType, HTuple cameraParam, HTuple cameraPose)
		{
			HOperatorSet.SetCameraSetupCamParam(cameraSetupModelID, cameraIdx, cameraType, cameraParam, cameraPose);
		}
		public static HTuple CreateCameraSetupModel (HTuple numCameras)
		{
			HOperatorSet.CreateCameraSetupModel(numCameras, out HTuple cameraSetupModelID);
			return cameraSetupModelID;
		}
		public static void ClearAllCalibData ()
		{
			HOperatorSet.ClearAllCalibData();
		}
		public static void ClearCalibData (HTuple calibDataID)
		{
			HOperatorSet.ClearCalibData(calibDataID);
		}
		public static HTuple DeserializeCalibData (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeCalibData(serializedItemHandle, out HTuple calibDataID);
			return calibDataID;
		}
		public static HTuple SerializeCalibData (HTuple calibDataID)
		{
			HOperatorSet.SerializeCalibData(calibDataID, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadCalibData (HTuple fileName)
		{
			HOperatorSet.ReadCalibData(fileName, out HTuple calibDataID);
			return calibDataID;
		}
		public static void WriteCalibData (HTuple calibDataID, HTuple fileName)
		{
			HOperatorSet.WriteCalibData(calibDataID, fileName);
		}
		public static HTuple CalibrateHandEye (HTuple calibDataID)
		{
			HOperatorSet.CalibrateHandEye(calibDataID, out HTuple errors);
			return errors;
		}
		public static HTuple CalibrateCameras (HTuple calibDataID)
		{
			HOperatorSet.CalibrateCameras(calibDataID, out HTuple error);
			return error;
		}
		public static void RemoveCalibData (HTuple calibDataID, HTuple itemType, HTuple itemIdx)
		{
			HOperatorSet.RemoveCalibData(calibDataID, itemType, itemIdx);
		}
		public static void SetCalibData (HTuple calibDataID, HTuple itemType, HTuple itemIdx, HTuple dataName, HTuple dataValue)
		{
			HOperatorSet.SetCalibData(calibDataID, itemType, itemIdx, dataName, dataValue);
		}
		public static void FindCalibObject (HObject image, HTuple calibDataID, HTuple cameraIdx, HTuple calibObjIdx, HTuple calibObjPoseIdx, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.FindCalibObject(image, calibDataID, cameraIdx, calibObjIdx, calibObjPoseIdx, genParamName, genParamValue);
		}
		public static void RemoveCalibDataObserv (HTuple calibDataID, HTuple cameraIdx, HTuple calibObjIdx, HTuple calibObjPoseIdx)
		{
			HOperatorSet.RemoveCalibDataObserv(calibDataID, cameraIdx, calibObjIdx, calibObjPoseIdx);
		}
		public static HObject GetCalibDataObservContours (HTuple calibDataID, HTuple contourName, HTuple cameraIdx, HTuple calibObjIdx, HTuple calibObjPoseIdx)
		{
			HOperatorSet.GetCalibDataObservContours(out HObject contours, calibDataID, contourName, cameraIdx, calibObjIdx, calibObjPoseIdx);
			return contours;
		}
		public static HTuple GetCalibDataObservPose (HTuple calibDataID, HTuple cameraIdx, HTuple calibObjIdx, HTuple calibObjPoseIdx)
		{
			HOperatorSet.GetCalibDataObservPose(calibDataID, cameraIdx, calibObjIdx, calibObjPoseIdx, out HTuple objInCameraPose);
			return objInCameraPose;
		}
		public static void SetCalibDataObservPose (HTuple calibDataID, HTuple cameraIdx, HTuple calibObjIdx, HTuple calibObjPoseIdx, HTuple objInCameraPose)
		{
			HOperatorSet.SetCalibDataObservPose(calibDataID, cameraIdx, calibObjIdx, calibObjPoseIdx, objInCameraPose);
		}
		public static (HTuple row, HTuple column, HTuple index, HTuple pose) GetCalibDataObservPoints (HTuple calibDataID, HTuple cameraIdx, HTuple calibObjIdx, HTuple calibObjPoseIdx)
		{
			HOperatorSet.GetCalibDataObservPoints(calibDataID, cameraIdx, calibObjIdx, calibObjPoseIdx, out HTuple row, out HTuple column, out HTuple index, out HTuple pose);
			return (row,column,index,pose);
		}
		public static void SetCalibDataObservPoints (HTuple calibDataID, HTuple cameraIdx, HTuple calibObjIdx, HTuple calibObjPoseIdx, HTuple row, HTuple column, HTuple index, HTuple pose)
		{
			HOperatorSet.SetCalibDataObservPoints(calibDataID, cameraIdx, calibObjIdx, calibObjPoseIdx, row, column, index, pose);
		}
		public static (HTuple index1, HTuple index2) QueryCalibDataObservIndices (HTuple calibDataID, HTuple itemType, HTuple itemIdx)
		{
			HOperatorSet.QueryCalibDataObservIndices(calibDataID, itemType, itemIdx, out HTuple index1, out HTuple index2);
			return (index1,index2);
		}
		public static HTuple GetCalibData (HTuple calibDataID, HTuple itemType, HTuple itemIdx, HTuple dataName)
		{
			HOperatorSet.GetCalibData(calibDataID, itemType, itemIdx, dataName, out HTuple dataValue);
			return dataValue;
		}
		public static void SetCalibDataCalibObject (HTuple calibDataID, HTuple calibObjIdx, HTuple calibObjDescr)
		{
			HOperatorSet.SetCalibDataCalibObject(calibDataID, calibObjIdx, calibObjDescr);
		}
		public static void SetCalibDataCamParam (HTuple calibDataID, HTuple cameraIdx, HTuple cameraType, HTuple cameraParam)
		{
			HOperatorSet.SetCalibDataCamParam(calibDataID, cameraIdx, cameraType, cameraParam);
		}
		public static HTuple CreateCalibData (HTuple calibSetup, HTuple numCameras, HTuple numCalibObjects)
		{
			HOperatorSet.CreateCalibData(calibSetup, numCameras, numCalibObjects, out HTuple calibDataID);
			return calibDataID;
		}
		public static HTuple GetBeadInspectionParam (HTuple beadInspectionModel, HTuple genParamName)
		{
			HOperatorSet.GetBeadInspectionParam(beadInspectionModel, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetBeadInspectionParam (HTuple beadInspectionModel, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetBeadInspectionParam(beadInspectionModel, genParamName, genParamValue);
		}
		public static (HObject leftContour, HObject rightContour, HObject errorSegment, HTuple errorType) ApplyBeadInspectionModel (HObject image, HTuple beadInspectionModel)
		{
			HOperatorSet.ApplyBeadInspectionModel(image, out HObject leftContour, out HObject rightContour, out HObject errorSegment, beadInspectionModel, out HTuple errorType);
			return (leftContour,rightContour,errorSegment,errorType);
		}
		public static void ClearBeadInspectionModel (HTuple beadInspectionModel)
		{
			HOperatorSet.ClearBeadInspectionModel(beadInspectionModel);
		}
		public static HTuple CreateBeadInspectionModel (HObject beadContour, HTuple targetThickness, HTuple thicknessTolerance, HTuple positionTolerance, HTuple polarity, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateBeadInspectionModel(beadContour, targetThickness, thicknessTolerance, positionTolerance, polarity, genParamName, genParamValue, out HTuple beadInspectionModel);
			return beadInspectionModel;
		}
		public static HTuple DeserializeBarCodeModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeBarCodeModel(serializedItemHandle, out HTuple barCodeHandle);
			return barCodeHandle;
		}
		public static HTuple SerializeBarCodeModel (HTuple barCodeHandle)
		{
			HOperatorSet.SerializeBarCodeModel(barCodeHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadBarCodeModel (HTuple fileName)
		{
			HOperatorSet.ReadBarCodeModel(fileName, out HTuple barCodeHandle);
			return barCodeHandle;
		}
		public static void WriteBarCodeModel (HTuple barCodeHandle, HTuple fileName)
		{
			HOperatorSet.WriteBarCodeModel(barCodeHandle, fileName);
		}
		public static HObject GetBarCodeObject (HTuple barCodeHandle, HTuple candidateHandle, HTuple objectName)
		{
			HOperatorSet.GetBarCodeObject(out HObject barCodeObjects, barCodeHandle, candidateHandle, objectName);
			return barCodeObjects;
		}
		public static HTuple GetBarCodeResult (HTuple barCodeHandle, HTuple candidateHandle, HTuple resultName)
		{
			HOperatorSet.GetBarCodeResult(barCodeHandle, candidateHandle, resultName, out HTuple barCodeResults);
			return barCodeResults;
		}
		public static HTuple DecodeBarCodeRectangle2 (HObject image, HTuple barCodeHandle, HTuple codeType, HTuple row, HTuple column, HTuple phi, HTuple length1, HTuple length2)
		{
			HOperatorSet.DecodeBarCodeRectangle2(image, barCodeHandle, codeType, row, column, phi, length1, length2, out HTuple decodedDataStrings);
			return decodedDataStrings;
		}
		public static (HObject symbolRegions, HTuple decodedDataStrings) FindBarCode (HObject image, HTuple barCodeHandle, HTuple codeType)
		{
			HOperatorSet.FindBarCode(image, out HObject symbolRegions, barCodeHandle, codeType, out HTuple decodedDataStrings);
			return (symbolRegions,decodedDataStrings);
		}
		public static HTuple QueryBarCodeParams (HTuple barCodeHandle, HTuple properties)
		{
			HOperatorSet.QueryBarCodeParams(barCodeHandle, properties, out HTuple genParamName);
			return genParamName;
		}
		public static HTuple GetBarCodeParamSpecific (HTuple barCodeHandle, HTuple codeTypes, HTuple genParamName)
		{
			HOperatorSet.GetBarCodeParamSpecific(barCodeHandle, codeTypes, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static HTuple GetBarCodeParam (HTuple barCodeHandle, HTuple genParamName)
		{
			HOperatorSet.GetBarCodeParam(barCodeHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetBarCodeParamSpecific (HTuple barCodeHandle, HTuple codeTypes, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetBarCodeParamSpecific(barCodeHandle, codeTypes, genParamName, genParamValue);
		}
		public static void SetBarCodeParam (HTuple barCodeHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetBarCodeParam(barCodeHandle, genParamName, genParamValue);
		}
		public static void ClearAllBarCodeModels ()
		{
			HOperatorSet.ClearAllBarCodeModels();
		}
		public static void ClearBarCodeModel (HTuple barCodeHandle)
		{
			HOperatorSet.ClearBarCodeModel(barCodeHandle);
		}
		public static HTuple CreateBarCodeModel (HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateBarCodeModel(genParamName, genParamValue, out HTuple barCodeHandle);
			return barCodeHandle;
		}
		public static void CloseBgEsti (HTuple bgEstiHandle)
		{
			HOperatorSet.CloseBgEsti(bgEstiHandle);
		}
		public static HObject GiveBgEsti (HTuple bgEstiHandle)
		{
			HOperatorSet.GiveBgEsti(out HObject backgroundImage, bgEstiHandle);
			return backgroundImage;
		}
		public static void UpdateBgEsti (HObject presentImage, HObject upDateRegion, HTuple bgEstiHandle)
		{
			HOperatorSet.UpdateBgEsti(presentImage, upDateRegion, bgEstiHandle);
		}
		public static HObject RunBgEsti (HObject presentImage, HTuple bgEstiHandle)
		{
			HOperatorSet.RunBgEsti(presentImage, out HObject foregroundRegion, bgEstiHandle);
			return foregroundRegion;
		}
		public static (HTuple syspar1, HTuple syspar2, HTuple gainMode, HTuple gain1, HTuple gain2, HTuple adaptMode, HTuple minDiff, HTuple statNum, HTuple confidenceC, HTuple timeC) GetBgEstiParams (HTuple bgEstiHandle)
		{
			HOperatorSet.GetBgEstiParams(bgEstiHandle, out HTuple syspar1, out HTuple syspar2, out HTuple gainMode, out HTuple gain1, out HTuple gain2, out HTuple adaptMode, out HTuple minDiff, out HTuple statNum, out HTuple confidenceC, out HTuple timeC);
			return (syspar1,syspar2,gainMode,gain1,gain2,adaptMode,minDiff,statNum,confidenceC,timeC);
		}
		public static void SetBgEstiParams (HTuple bgEstiHandle, HTuple syspar1, HTuple syspar2, HTuple gainMode, HTuple gain1, HTuple gain2, HTuple adaptMode, HTuple minDiff, HTuple statNum, HTuple confidenceC, HTuple timeC)
		{
			HOperatorSet.SetBgEstiParams(bgEstiHandle, syspar1, syspar2, gainMode, gain1, gain2, adaptMode, minDiff, statNum, confidenceC, timeC);
		}
		public static HTuple CreateBgEsti (HObject initializeImage, HTuple syspar1, HTuple syspar2, HTuple gainMode, HTuple gain1, HTuple gain2, HTuple adaptMode, HTuple minDiff, HTuple statNum, HTuple confidenceC, HTuple timeC)
		{
			HOperatorSet.CreateBgEsti(initializeImage, syspar1, syspar2, gainMode, gain1, gain2, adaptMode, minDiff, statNum, confidenceC, timeC, out HTuple bgEstiHandle);
			return bgEstiHandle;
		}
		public static void CloseAllBgEsti ()
		{
			HOperatorSet.CloseAllBgEsti();
		}
		public static HTuple ControlIoChannel (HTuple IOChannelHandle, HTuple paramAction, HTuple paramArgument)
		{
			HOperatorSet.ControlIoChannel(IOChannelHandle, paramAction, paramArgument, out HTuple genParamValue);
			return genParamValue;
		}
		public static HTuple WriteIoChannel (HTuple IOChannelHandle, HTuple value)
		{
			HOperatorSet.WriteIoChannel(IOChannelHandle, value, out HTuple status);
			return status;
		}
		public static (HTuple value, HTuple status) ReadIoChannel (HTuple IOChannelHandle)
		{
			HOperatorSet.ReadIoChannel(IOChannelHandle, out HTuple value, out HTuple status);
			return (value,status);
		}
		public static void SetIoChannelParam (HTuple IOChannelHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetIoChannelParam(IOChannelHandle, genParamName, genParamValue);
		}
		public static HTuple GetIoChannelParam (HTuple IOChannelHandle, HTuple genParamName)
		{
			HOperatorSet.GetIoChannelParam(IOChannelHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void CloseIoChannel (HTuple IOChannelHandle)
		{
			HOperatorSet.CloseIoChannel(IOChannelHandle);
		}
		public static HTuple OpenIoChannel (HTuple IODeviceHandle, HTuple IOChannelName, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.OpenIoChannel(IODeviceHandle, IOChannelName, genParamName, genParamValue, out HTuple IOChannelHandle);
			return IOChannelHandle;
		}
		public static HTuple QueryIoDevice (HTuple IODeviceHandle, HTuple IOChannelName, HTuple query)
		{
			HOperatorSet.QueryIoDevice(IODeviceHandle, IOChannelName, query, out HTuple result);
			return result;
		}
		public static HTuple ControlIoDevice (HTuple IODeviceHandle, HTuple action, HTuple argument)
		{
			HOperatorSet.ControlIoDevice(IODeviceHandle, action, argument, out HTuple result);
			return result;
		}
		public static void SetIoDeviceParam (HTuple IODeviceHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetIoDeviceParam(IODeviceHandle, genParamName, genParamValue);
		}
		public static HTuple GetIoDeviceParam (HTuple IODeviceHandle, HTuple genParamName)
		{
			HOperatorSet.GetIoDeviceParam(IODeviceHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void CloseIoDevice (HTuple IODeviceHandle)
		{
			HOperatorSet.CloseIoDevice(IODeviceHandle);
		}
		public static HTuple OpenIoDevice (HTuple IOInterfaceName, HTuple IODeviceName, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.OpenIoDevice(IOInterfaceName, IODeviceName, genParamName, genParamValue, out HTuple IODeviceHandle);
			return IODeviceHandle;
		}
		public static HTuple ControlIoInterface (HTuple IOInterfaceName, HTuple action, HTuple argument)
		{
			HOperatorSet.ControlIoInterface(IOInterfaceName, action, argument, out HTuple result);
			return result;
		}
		public static HTuple QueryIoInterface (HTuple IOInterfaceName, HTuple query)
		{
			HOperatorSet.QueryIoInterface(IOInterfaceName, query, out HTuple result);
			return result;
		}
		public static HTuple GetFramegrabberParam (HTuple acqHandle, HTuple param)
		{
			HOperatorSet.GetFramegrabberParam(acqHandle, param, out HTuple value);
			return value;
		}
		public static void SetFramegrabberParam (HTuple acqHandle, HTuple param, HTuple value)
		{
			HOperatorSet.SetFramegrabberParam(acqHandle, param, value);
		}
		public static (HTuple callbackFunction, HTuple userContext) GetFramegrabberCallback (HTuple acqHandle, HTuple callbackType)
		{
			HOperatorSet.GetFramegrabberCallback(acqHandle, callbackType, out HTuple callbackFunction, out HTuple userContext);
			return (callbackFunction,userContext);
		}
		public static void SetFramegrabberCallback (HTuple acqHandle, HTuple callbackType, HTuple callbackFunction, HTuple userContext)
		{
			HOperatorSet.SetFramegrabberCallback(acqHandle, callbackType, callbackFunction, userContext);
		}
		public static (HObject image, HObject region, HObject contours, HTuple data) GrabDataAsync (HTuple acqHandle, HTuple maxDelay)
		{
			HOperatorSet.GrabDataAsync(out HObject image, out HObject region, out HObject contours, acqHandle, maxDelay, out HTuple data);
			return (image,region,contours,data);
		}
		public static (HObject image, HObject region, HObject contours, HTuple data) GrabData (HTuple acqHandle)
		{
			HOperatorSet.GrabData(out HObject image, out HObject region, out HObject contours, acqHandle, out HTuple data);
			return (image,region,contours,data);
		}
		public static HObject GrabImageAsync (HTuple acqHandle, HTuple maxDelay)
		{
			HOperatorSet.GrabImageAsync(out HObject image, acqHandle, maxDelay);
			return image;
		}
		public static void GrabImageStart (HTuple acqHandle, HTuple maxDelay)
		{
			HOperatorSet.GrabImageStart(acqHandle, maxDelay);
		}
		public static HObject GrabImage (HTuple acqHandle)
		{
			HOperatorSet.GrabImage(out HObject image, acqHandle);
			return image;
		}
		public static (HTuple information, HTuple valueList) InfoFramegrabber (HTuple name, HTuple query)
		{
			HOperatorSet.InfoFramegrabber(name, query, out HTuple information, out HTuple valueList);
			return (information,valueList);
		}
		public static void CloseAllFramegrabbers ()
		{
			HOperatorSet.CloseAllFramegrabbers();
		}
		public static void CloseFramegrabber (HTuple acqHandle)
		{
			HOperatorSet.CloseFramegrabber(acqHandle);
		}
		public static HTuple OpenFramegrabber (HTuple name, HTuple horizontalResolution, HTuple verticalResolution, HTuple imageWidth, HTuple imageHeight, HTuple startRow, HTuple startColumn, HTuple field, HTuple bitsPerChannel, HTuple colorSpace, HTuple generic, HTuple externalTrigger, HTuple cameraType, HTuple device, HTuple port, HTuple lineIn)
		{
			HOperatorSet.OpenFramegrabber(name, horizontalResolution, verticalResolution, imageWidth, imageHeight, startRow, startColumn, field, bitsPerChannel, colorSpace, generic, externalTrigger, cameraType, device, port, lineIn, out HTuple acqHandle);
			return acqHandle;
		}
		public static (HTuple imageRed, HTuple imageGreen, HTuple imageBlue) GetFramegrabberLut (HTuple acqHandle)
		{
			HOperatorSet.GetFramegrabberLut(acqHandle, out HTuple imageRed, out HTuple imageGreen, out HTuple imageBlue);
			return (imageRed,imageGreen,imageBlue);
		}
		public static void SetFramegrabberLut (HTuple acqHandle, HTuple imageRed, HTuple imageGreen, HTuple imageBlue)
		{
			HOperatorSet.SetFramegrabberLut(acqHandle, imageRed, imageGreen, imageBlue);
		}
		public static HTuple AddScene3dLabel (HTuple scene3D, HTuple text, HTuple referencePoint, HTuple position, HTuple relatesTo)
		{
			HOperatorSet.AddScene3dLabel(scene3D, text, referencePoint, position, relatesTo, out HTuple labelIndex);
			return labelIndex;
		}
		public static void RemoveScene3dLabel (HTuple scene3D, HTuple labelIndex)
		{
			HOperatorSet.RemoveScene3dLabel(scene3D, labelIndex);
		}
		public static void SetScene3dLabelParam (HTuple scene3D, HTuple labelIndex, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetScene3dLabelParam(scene3D, labelIndex, genParamName, genParamValue);
		}
		public static HTuple AddTextureInspectionModelImage (HObject image, HTuple textureInspectionModel)
		{
			HOperatorSet.AddTextureInspectionModelImage(image, textureInspectionModel, out HTuple indices);
			return indices;
		}
		public static (HObject noveltyRegion, HTuple textureInspectionResultID) ApplyTextureInspectionModel (HObject image, HTuple textureInspectionModel)
		{
			HOperatorSet.ApplyTextureInspectionModel(image, out HObject noveltyRegion, textureInspectionModel, out HTuple textureInspectionResultID);
			return (noveltyRegion,textureInspectionResultID);
		}
		public static HObject BilateralFilter (HObject image, HObject imageJoint, HTuple sigmaSpatial, HTuple sigmaRange, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.BilateralFilter(image, imageJoint, out HObject imageBilateral, sigmaSpatial, sigmaRange, genParamName, genParamValue);
			return imageBilateral;
		}
		public static void ClearOcrClassCnn (HTuple OCRHandle)
		{
			HOperatorSet.ClearOcrClassCnn(OCRHandle);
		}
		public static void ClearTextureInspectionModel (HTuple textureInspectionModel)
		{
			HOperatorSet.ClearTextureInspectionModel(textureInspectionModel);
		}
		public static void AddClassTrainDataSvm (HTuple SVMHandle, HTuple classTrainDataHandle)
		{
			HOperatorSet.AddClassTrainDataSvm(SVMHandle, classTrainDataHandle);
		}
		public static HTuple GetSampleNumClassTrainData (HTuple classTrainDataHandle)
		{
			HOperatorSet.GetSampleNumClassTrainData(classTrainDataHandle, out HTuple numSamples);
			return numSamples;
		}
		public static (HTuple features, HTuple classID) GetSampleClassTrainData (HTuple classTrainDataHandle, HTuple indexSample)
		{
			HOperatorSet.GetSampleClassTrainData(classTrainDataHandle, indexSample, out HTuple features, out HTuple classID);
			return (features,classID);
		}
		public static void ClearAllClassTrainData ()
		{
			HOperatorSet.ClearAllClassTrainData();
		}
		public static void ClearClassTrainData (HTuple classTrainDataHandle)
		{
			HOperatorSet.ClearClassTrainData(classTrainDataHandle);
		}
		public static void AddSampleClassTrainData (HTuple classTrainDataHandle, HTuple order, HTuple features, HTuple classID)
		{
			HOperatorSet.AddSampleClassTrainData(classTrainDataHandle, order, features, classID);
		}
		public static HTuple CreateClassTrainData (HTuple numDim)
		{
			HOperatorSet.CreateClassTrainData(numDim, out HTuple classTrainDataHandle);
			return classTrainDataHandle;
		}
		public static (HTuple MLPHandle, HTuple selectedFeatureIndices, HTuple score) SelectFeatureSetMlp (HTuple classTrainDataHandle, HTuple selectionMethod, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SelectFeatureSetMlp(classTrainDataHandle, selectionMethod, genParamName, genParamValue, out HTuple MLPHandle, out HTuple selectedFeatureIndices, out HTuple score);
			return (MLPHandle,selectedFeatureIndices,score);
		}
		public static (HTuple SVMHandle, HTuple selectedFeatureIndices, HTuple score) SelectFeatureSetSvm (HTuple classTrainDataHandle, HTuple selectionMethod, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SelectFeatureSetSvm(classTrainDataHandle, selectionMethod, genParamName, genParamValue, out HTuple SVMHandle, out HTuple selectedFeatureIndices, out HTuple score);
			return (SVMHandle,selectedFeatureIndices,score);
		}
		public static (HTuple GMMHandle, HTuple selectedFeatureIndices, HTuple score) SelectFeatureSetGmm (HTuple classTrainDataHandle, HTuple selectionMethod, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SelectFeatureSetGmm(classTrainDataHandle, selectionMethod, genParamName, genParamValue, out HTuple GMMHandle, out HTuple selectedFeatureIndices, out HTuple score);
			return (GMMHandle,selectedFeatureIndices,score);
		}
		public static (HTuple KNNHandle, HTuple selectedFeatureIndices, HTuple score) SelectFeatureSetKnn (HTuple classTrainDataHandle, HTuple selectionMethod, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SelectFeatureSetKnn(classTrainDataHandle, selectionMethod, genParamName, genParamValue, out HTuple KNNHandle, out HTuple selectedFeatureIndices, out HTuple score);
			return (KNNHandle,selectedFeatureIndices,score);
		}
		public static void ClearAllClassKnn ()
		{
			HOperatorSet.ClearAllClassKnn();
		}
		public static void ClearClassKnn (HTuple KNNHandle)
		{
			HOperatorSet.ClearClassKnn(KNNHandle);
		}
		public static HTuple GetSampleNumClassKnn (HTuple KNNHandle)
		{
			HOperatorSet.GetSampleNumClassKnn(KNNHandle, out HTuple numSamples);
			return numSamples;
		}
		public static (HTuple features, HTuple classID) GetSampleClassKnn (HTuple KNNHandle, HTuple indexSample)
		{
			HOperatorSet.GetSampleClassKnn(KNNHandle, indexSample, out HTuple features, out HTuple classID);
			return (features,classID);
		}
		public static HTuple DeserializeClassKnn (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeClassKnn(serializedItemHandle, out HTuple KNNHandle);
			return KNNHandle;
		}
		public static HTuple SerializeClassKnn (HTuple KNNHandle)
		{
			HOperatorSet.SerializeClassKnn(KNNHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadClassKnn (HTuple fileName)
		{
			HOperatorSet.ReadClassKnn(fileName, out HTuple KNNHandle);
			return KNNHandle;
		}
		public static void WriteClassKnn (HTuple KNNHandle, HTuple fileName)
		{
			HOperatorSet.WriteClassKnn(KNNHandle, fileName);
		}
		public static HTuple GetParamsClassKnn (HTuple KNNHandle, HTuple genParamName)
		{
			HOperatorSet.GetParamsClassKnn(KNNHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetParamsClassKnn (HTuple KNNHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetParamsClassKnn(KNNHandle, genParamName, genParamValue);
		}
		public static (HTuple result, HTuple rating) ClassifyClassKnn (HTuple KNNHandle, HTuple features)
		{
			HOperatorSet.ClassifyClassKnn(KNNHandle, features, out HTuple result, out HTuple rating);
			return (result,rating);
		}
		public static void TrainClassKnn (HTuple KNNHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.TrainClassKnn(KNNHandle, genParamName, genParamValue);
		}
		public static void AddSampleClassKnn (HTuple KNNHandle, HTuple features, HTuple classID)
		{
			HOperatorSet.AddSampleClassKnn(KNNHandle, features, classID);
		}
		public static HTuple CreateClassKnn (HTuple numDim)
		{
			HOperatorSet.CreateClassKnn(numDim, out HTuple KNNHandle);
			return KNNHandle;
		}
		public static void ClearAllClassLut ()
		{
			HOperatorSet.ClearAllClassLut();
		}
		public static void ClearClassLut (HTuple classLUTHandle)
		{
			HOperatorSet.ClearClassLut(classLUTHandle);
		}
		public static HTuple CreateClassLutKnn (HTuple KNNHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateClassLutKnn(KNNHandle, genParamName, genParamValue, out HTuple classLUTHandle);
			return classLUTHandle;
		}
		public static HTuple CreateClassLutGmm (HTuple GMMHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateClassLutGmm(GMMHandle, genParamName, genParamValue, out HTuple classLUTHandle);
			return classLUTHandle;
		}
		public static HTuple CreateClassLutSvm (HTuple SVMHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateClassLutSvm(SVMHandle, genParamName, genParamValue, out HTuple classLUTHandle);
			return classLUTHandle;
		}
		public static HTuple CreateClassLutMlp (HTuple MLPHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateClassLutMlp(MLPHandle, genParamName, genParamValue, out HTuple classLUTHandle);
			return classLUTHandle;
		}
		public static void ClearAllClassGmm ()
		{
			HOperatorSet.ClearAllClassGmm();
		}
		public static void ClearClassGmm (HTuple GMMHandle)
		{
			HOperatorSet.ClearClassGmm(GMMHandle);
		}
		public static void ClearSamplesClassGmm (HTuple GMMHandle)
		{
			HOperatorSet.ClearSamplesClassGmm(GMMHandle);
		}
		public static HTuple DeserializeClassGmm (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeClassGmm(serializedItemHandle, out HTuple GMMHandle);
			return GMMHandle;
		}
		public static HTuple SerializeClassGmm (HTuple GMMHandle)
		{
			HOperatorSet.SerializeClassGmm(GMMHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadClassGmm (HTuple fileName)
		{
			HOperatorSet.ReadClassGmm(fileName, out HTuple GMMHandle);
			return GMMHandle;
		}
		public static void WriteClassGmm (HTuple GMMHandle, HTuple fileName)
		{
			HOperatorSet.WriteClassGmm(GMMHandle, fileName);
		}
		public static void ReadSamplesClassGmm (HTuple GMMHandle, HTuple fileName)
		{
			HOperatorSet.ReadSamplesClassGmm(GMMHandle, fileName);
		}
		public static void WriteSamplesClassGmm (HTuple GMMHandle, HTuple fileName)
		{
			HOperatorSet.WriteSamplesClassGmm(GMMHandle, fileName);
		}
		public static (HTuple classID, HTuple classProb, HTuple density, HTuple KSigmaProb) ClassifyClassGmm (HTuple GMMHandle, HTuple features, HTuple num)
		{
			HOperatorSet.ClassifyClassGmm(GMMHandle, features, num, out HTuple classID, out HTuple classProb, out HTuple density, out HTuple KSigmaProb);
			return (classID,classProb,density,KSigmaProb);
		}
		public static (HTuple classProb, HTuple density, HTuple KSigmaProb) EvaluateClassGmm (HTuple GMMHandle, HTuple features)
		{
			HOperatorSet.EvaluateClassGmm(GMMHandle, features, out HTuple classProb, out HTuple density, out HTuple KSigmaProb);
			return (classProb,density,KSigmaProb);
		}
		public static (HTuple centers, HTuple iter) TrainClassGmm (HTuple GMMHandle, HTuple maxIter, HTuple threshold, HTuple classPriors, HTuple regularize)
		{
			HOperatorSet.TrainClassGmm(GMMHandle, maxIter, threshold, classPriors, regularize, out HTuple centers, out HTuple iter);
			return (centers,iter);
		}
		public static (HTuple informationCont, HTuple cumInformationCont) GetPrepInfoClassGmm (HTuple GMMHandle, HTuple preprocessing)
		{
			HOperatorSet.GetPrepInfoClassGmm(GMMHandle, preprocessing, out HTuple informationCont, out HTuple cumInformationCont);
			return (informationCont,cumInformationCont);
		}
		public static HTuple GetSampleNumClassGmm (HTuple GMMHandle)
		{
			HOperatorSet.GetSampleNumClassGmm(GMMHandle, out HTuple numSamples);
			return numSamples;
		}
		public static (HTuple features, HTuple classID) GetSampleClassGmm (HTuple GMMHandle, HTuple numSample)
		{
			HOperatorSet.GetSampleClassGmm(GMMHandle, numSample, out HTuple features, out HTuple classID);
			return (features,classID);
		}
		public static void AddSampleClassGmm (HTuple GMMHandle, HTuple features, HTuple classID, HTuple randomize)
		{
			HOperatorSet.AddSampleClassGmm(GMMHandle, features, classID, randomize);
		}
		public static (HTuple numDim, HTuple numClasses, HTuple minCenters, HTuple maxCenters, HTuple covarType) GetParamsClassGmm (HTuple GMMHandle)
		{
			HOperatorSet.GetParamsClassGmm(GMMHandle, out HTuple numDim, out HTuple numClasses, out HTuple minCenters, out HTuple maxCenters, out HTuple covarType);
			return (numDim,numClasses,minCenters,maxCenters,covarType);
		}
		public static HTuple CreateClassGmm (HTuple numDim, HTuple numClasses, HTuple numCenters, HTuple covarType, HTuple preprocessing, HTuple numComponents, HTuple randSeed)
		{
			HOperatorSet.CreateClassGmm(numDim, numClasses, numCenters, covarType, preprocessing, numComponents, randSeed, out HTuple GMMHandle);
			return GMMHandle;
		}
		public static void ClearAllClassSvm ()
		{
			HOperatorSet.ClearAllClassSvm();
		}
		public static void ClearClassSvm (HTuple SVMHandle)
		{
			HOperatorSet.ClearClassSvm(SVMHandle);
		}
		public static void ClearSamplesClassSvm (HTuple SVMHandle)
		{
			HOperatorSet.ClearSamplesClassSvm(SVMHandle);
		}
		public static HTuple DeserializeClassSvm (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeClassSvm(serializedItemHandle, out HTuple SVMHandle);
			return SVMHandle;
		}
		public static HTuple SerializeClassSvm (HTuple SVMHandle)
		{
			HOperatorSet.SerializeClassSvm(SVMHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadClassSvm (HTuple fileName)
		{
			HOperatorSet.ReadClassSvm(fileName, out HTuple SVMHandle);
			return SVMHandle;
		}
		public static void WriteClassSvm (HTuple SVMHandle, HTuple fileName)
		{
			HOperatorSet.WriteClassSvm(SVMHandle, fileName);
		}
		public static void ReadSamplesClassSvm (HTuple SVMHandle, HTuple fileName)
		{
			HOperatorSet.ReadSamplesClassSvm(SVMHandle, fileName);
		}
		public static void WriteSamplesClassSvm (HTuple SVMHandle, HTuple fileName)
		{
			HOperatorSet.WriteSamplesClassSvm(SVMHandle, fileName);
		}
		public static HTuple EvaluateClassSvm (HTuple SVMHandle, HTuple features)
		{
			HOperatorSet.EvaluateClassSvm(SVMHandle, features, out HTuple result);
			return result;
		}
		public static HTuple ClassifyClassSvm (HTuple SVMHandle, HTuple features, HTuple num)
		{
			HOperatorSet.ClassifyClassSvm(SVMHandle, features, num, out HTuple classVal);
			return classVal;
		}
		public static HTuple ReduceClassSvm (HTuple SVMHandle, HTuple method, HTuple minRemainingSV, HTuple maxError)
		{
			HOperatorSet.ReduceClassSvm(SVMHandle, method, minRemainingSV, maxError, out HTuple SVMHandleReduced);
			return SVMHandleReduced;
		}
		public static void TrainClassSvm (HTuple SVMHandle, HTuple epsilon, HTuple trainMode)
		{
			HOperatorSet.TrainClassSvm(SVMHandle, epsilon, trainMode);
		}
		public static (HTuple informationCont, HTuple cumInformationCont) GetPrepInfoClassSvm (HTuple SVMHandle, HTuple preprocessing)
		{
			HOperatorSet.GetPrepInfoClassSvm(SVMHandle, preprocessing, out HTuple informationCont, out HTuple cumInformationCont);
			return (informationCont,cumInformationCont);
		}
		public static (HTuple numSupportVectors, HTuple numSVPerSVM) GetSupportVectorNumClassSvm (HTuple SVMHandle)
		{
			HOperatorSet.GetSupportVectorNumClassSvm(SVMHandle, out HTuple numSupportVectors, out HTuple numSVPerSVM);
			return (numSupportVectors,numSVPerSVM);
		}
		public static HTuple GetSupportVectorClassSvm (HTuple SVMHandle, HTuple indexSupportVector)
		{
			HOperatorSet.GetSupportVectorClassSvm(SVMHandle, indexSupportVector, out HTuple index);
			return index;
		}
		public static HTuple GetSampleNumClassSvm (HTuple SVMHandle)
		{
			HOperatorSet.GetSampleNumClassSvm(SVMHandle, out HTuple numSamples);
			return numSamples;
		}
		public static (HTuple features, HTuple target) GetSampleClassSvm (HTuple SVMHandle, HTuple indexSample)
		{
			HOperatorSet.GetSampleClassSvm(SVMHandle, indexSample, out HTuple features, out HTuple target);
			return (features,target);
		}
		public static void AddSampleClassSvm (HTuple SVMHandle, HTuple features, HTuple classVal)
		{
			HOperatorSet.AddSampleClassSvm(SVMHandle, features, classVal);
		}
		public static (HTuple numFeatures, HTuple kernelType, HTuple kernelParam, HTuple nu, HTuple numClasses, HTuple mode, HTuple preprocessing, HTuple numComponents) GetParamsClassSvm (HTuple SVMHandle)
		{
			HOperatorSet.GetParamsClassSvm(SVMHandle, out HTuple numFeatures, out HTuple kernelType, out HTuple kernelParam, out HTuple nu, out HTuple numClasses, out HTuple mode, out HTuple preprocessing, out HTuple numComponents);
			return (numFeatures,kernelType,kernelParam,nu,numClasses,mode,preprocessing,numComponents);
		}
		public static HTuple CreateClassSvm (HTuple numFeatures, HTuple kernelType, HTuple kernelParam, HTuple nu, HTuple numClasses, HTuple mode, HTuple preprocessing, HTuple numComponents)
		{
			HOperatorSet.CreateClassSvm(numFeatures, kernelType, kernelParam, nu, numClasses, mode, preprocessing, numComponents, out HTuple SVMHandle);
			return SVMHandle;
		}
		public static void ClearAllClassMlp ()
		{
			HOperatorSet.ClearAllClassMlp();
		}
		public static void ClearClassMlp (HTuple MLPHandle)
		{
			HOperatorSet.ClearClassMlp(MLPHandle);
		}
		public static void ClearSamplesClassMlp (HTuple MLPHandle)
		{
			HOperatorSet.ClearSamplesClassMlp(MLPHandle);
		}
		public static HTuple DeserializeClassMlp (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeClassMlp(serializedItemHandle, out HTuple MLPHandle);
			return MLPHandle;
		}
		public static HTuple SerializeClassMlp (HTuple MLPHandle)
		{
			HOperatorSet.SerializeClassMlp(MLPHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadClassMlp (HTuple fileName)
		{
			HOperatorSet.ReadClassMlp(fileName, out HTuple MLPHandle);
			return MLPHandle;
		}
		public static void WriteClassMlp (HTuple MLPHandle, HTuple fileName)
		{
			HOperatorSet.WriteClassMlp(MLPHandle, fileName);
		}
		public static void ReadSamplesClassMlp (HTuple MLPHandle, HTuple fileName)
		{
			HOperatorSet.ReadSamplesClassMlp(MLPHandle, fileName);
		}
		public static void WriteSamplesClassMlp (HTuple MLPHandle, HTuple fileName)
		{
			HOperatorSet.WriteSamplesClassMlp(MLPHandle, fileName);
		}
		public static (HTuple classVal, HTuple confidence) ClassifyClassMlp (HTuple MLPHandle, HTuple features, HTuple num)
		{
			HOperatorSet.ClassifyClassMlp(MLPHandle, features, num, out HTuple classVal, out HTuple confidence);
			return (classVal,confidence);
		}
		public static HTuple EvaluateClassMlp (HTuple MLPHandle, HTuple features)
		{
			HOperatorSet.EvaluateClassMlp(MLPHandle, features, out HTuple result);
			return result;
		}
		public static (HTuple error, HTuple errorLog) TrainClassMlp (HTuple MLPHandle, HTuple maxIterations, HTuple weightTolerance, HTuple errorTolerance)
		{
			HOperatorSet.TrainClassMlp(MLPHandle, maxIterations, weightTolerance, errorTolerance, out HTuple error, out HTuple errorLog);
			return (error,errorLog);
		}
		public static (HTuple informationCont, HTuple cumInformationCont) GetPrepInfoClassMlp (HTuple MLPHandle, HTuple preprocessing)
		{
			HOperatorSet.GetPrepInfoClassMlp(MLPHandle, preprocessing, out HTuple informationCont, out HTuple cumInformationCont);
			return (informationCont,cumInformationCont);
		}
		public static HTuple GetSampleNumClassMlp (HTuple MLPHandle)
		{
			HOperatorSet.GetSampleNumClassMlp(MLPHandle, out HTuple numSamples);
			return numSamples;
		}
		public static (HTuple features, HTuple target) GetSampleClassMlp (HTuple MLPHandle, HTuple indexSample)
		{
			HOperatorSet.GetSampleClassMlp(MLPHandle, indexSample, out HTuple features, out HTuple target);
			return (features,target);
		}
		public static HTuple GetRejectionParamsClassMlp (HTuple MLPHandle, HTuple genParamName)
		{
			HOperatorSet.GetRejectionParamsClassMlp(MLPHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetRejectionParamsClassMlp (HTuple MLPHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetRejectionParamsClassMlp(MLPHandle, genParamName, genParamValue);
		}
		public static void AddSampleClassMlp (HTuple MLPHandle, HTuple features, HTuple target)
		{
			HOperatorSet.AddSampleClassMlp(MLPHandle, features, target);
		}
		public static HTuple GetRegularizationParamsClassMlp (HTuple MLPHandle, HTuple genParamName)
		{
			HOperatorSet.GetRegularizationParamsClassMlp(MLPHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetRegularizationParamsClassMlp (HTuple MLPHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetRegularizationParamsClassMlp(MLPHandle, genParamName, genParamValue);
		}
		public static (HTuple numInput, HTuple numHidden, HTuple numOutput, HTuple outputFunction, HTuple preprocessing, HTuple numComponents) GetParamsClassMlp (HTuple MLPHandle)
		{
			HOperatorSet.GetParamsClassMlp(MLPHandle, out HTuple numInput, out HTuple numHidden, out HTuple numOutput, out HTuple outputFunction, out HTuple preprocessing, out HTuple numComponents);
			return (numInput,numHidden,numOutput,outputFunction,preprocessing,numComponents);
		}
		public static HTuple CreateClassMlp (HTuple numInput, HTuple numHidden, HTuple numOutput, HTuple outputFunction, HTuple preprocessing, HTuple numComponents, HTuple randSeed)
		{
			HOperatorSet.CreateClassMlp(numInput, numHidden, numOutput, outputFunction, preprocessing, numComponents, randSeed, out HTuple MLPHandle);
			return MLPHandle;
		}
		public static void DeserializeClassBox (HTuple classifHandle, HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeClassBox(classifHandle, serializedItemHandle);
		}
		public static HTuple SerializeClassBox (HTuple classifHandle)
		{
			HOperatorSet.SerializeClassBox(classifHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static void WriteClassBox (HTuple classifHandle, HTuple fileName)
		{
			HOperatorSet.WriteClassBox(classifHandle, fileName);
		}
		public static void SetClassBoxParam (HTuple classifHandle, HTuple flag, HTuple value)
		{
			HOperatorSet.SetClassBoxParam(classifHandle, flag, value);
		}
		public static HTuple ReadSampset (HTuple fileName)
		{
			HOperatorSet.ReadSampset(fileName, out HTuple sampKey);
			return sampKey;
		}
		public static void ReadClassBox (HTuple classifHandle, HTuple fileName)
		{
			HOperatorSet.ReadClassBox(classifHandle, fileName);
		}
		public static void LearnSampsetBox (HTuple classifHandle, HTuple sampKey, HTuple outfile, HTuple NSamples, HTuple stopError, HTuple errorN)
		{
			HOperatorSet.LearnSampsetBox(classifHandle, sampKey, outfile, NSamples, stopError, errorN);
		}
		public static void LearnClassBox (HTuple classifHandle, HTuple features, HTuple classVal)
		{
			HOperatorSet.LearnClassBox(classifHandle, features, classVal);
		}
		public static HTuple GetClassBoxParam (HTuple classifHandle, HTuple flag)
		{
			HOperatorSet.GetClassBoxParam(classifHandle, flag, out HTuple value);
			return value;
		}
		public static void ClearSampset (HTuple sampKey)
		{
			HOperatorSet.ClearSampset(sampKey);
		}
		public static void CloseClassBox (HTuple classifHandle)
		{
			HOperatorSet.CloseClassBox(classifHandle);
		}
		public static HTuple CreateClassBox ()
		{
			HOperatorSet.CreateClassBox(out HTuple classifHandle);
			return classifHandle;
		}
		public static (HTuple classIdx, HTuple boxIdx, HTuple boxLowerBound, HTuple boxHigherBound, HTuple boxNumSamplesTrain, HTuple boxNumSamplesWrong) DescriptClassBox (HTuple classifHandle, HTuple dimensions)
		{
			HOperatorSet.DescriptClassBox(classifHandle, dimensions, out HTuple classIdx, out HTuple boxIdx, out HTuple boxLowerBound, out HTuple boxHigherBound, out HTuple boxNumSamplesTrain, out HTuple boxNumSamplesWrong);
			return (classIdx,boxIdx,boxLowerBound,boxHigherBound,boxNumSamplesTrain,boxNumSamplesWrong);
		}
		public static HTuple TestSampsetBox (HTuple classifHandle, HTuple sampKey)
		{
			HOperatorSet.TestSampsetBox(classifHandle, sampKey, out HTuple error);
			return error;
		}
		public static HTuple EnquireRejectClassBox (HTuple classifHandle, HTuple featureList)
		{
			HOperatorSet.EnquireRejectClassBox(classifHandle, featureList, out HTuple classVal);
			return classVal;
		}
		public static HTuple EnquireClassBox (HTuple classifHandle, HTuple featureList)
		{
			HOperatorSet.EnquireClassBox(classifHandle, featureList, out HTuple classVal);
			return classVal;
		}
		public static void CloseAllClassBox ()
		{
			HOperatorSet.CloseAllClassBox();
		}
		public static HObject ConvertMapType (HObject map, HTuple newType, HTuple imageWidth)
		{
			HOperatorSet.ConvertMapType(map, out HObject mapConverted, newType, imageWidth);
			return mapConverted;
		}
		public static (HTuple pose, HTuple quality) VectorToPose (HTuple worldX, HTuple worldY, HTuple worldZ, HTuple imageRow, HTuple imageColumn, HTuple cameraParam, HTuple method, HTuple qualityType)
		{
			HOperatorSet.VectorToPose(worldX, worldY, worldZ, imageRow, imageColumn, cameraParam, method, qualityType, out HTuple pose, out HTuple quality);
			return (pose,quality);
		}
		public static HTuple ProjHomMat2dToPose (HTuple homography, HTuple cameraMatrix, HTuple method)
		{
			HOperatorSet.ProjHomMat2dToPose(homography, cameraMatrix, method, out HTuple pose);
			return pose;
		}
		public static (HObject selectedContours, HTuple cameraParam) RadialDistortionSelfCalibration (HObject contours, HTuple width, HTuple height, HTuple inlierThreshold, HTuple randSeed, HTuple distortionModel, HTuple distortionCenter, HTuple principalPointVar)
		{
			HOperatorSet.RadialDistortionSelfCalibration(contours, out HObject selectedContours, width, height, inlierThreshold, randSeed, distortionModel, distortionCenter, principalPointVar, out HTuple cameraParam);
			return (selectedContours,cameraParam);
		}
		public static (HTuple cameraMatrix, HTuple imageWidth, HTuple imageHeight) CamParToCamMat (HTuple cameraParam)
		{
			HOperatorSet.CamParToCamMat(cameraParam, out HTuple cameraMatrix, out HTuple imageWidth, out HTuple imageHeight);
			return (cameraMatrix,imageWidth,imageHeight);
		}
		public static HTuple CamMatToCamPar (HTuple cameraMatrix, HTuple kappa, HTuple imageWidth, HTuple imageHeight)
		{
			HOperatorSet.CamMatToCamPar(cameraMatrix, kappa, imageWidth, imageHeight, out HTuple cameraParam);
			return cameraParam;
		}
		public static (HTuple cameraMatrices, HTuple kappa, HTuple rotationMatrices, HTuple x, HTuple y, HTuple z, HTuple error) StationaryCameraSelfCalibration (HTuple numImages, HTuple imageWidth, HTuple imageHeight, HTuple referenceImage, HTuple mappingSource, HTuple mappingDest, HTuple homMatrices2D, HTuple rows1, HTuple cols1, HTuple rows2, HTuple cols2, HTuple numCorrespondences, HTuple estimationMethod, HTuple cameraModel, HTuple fixedCameraParams)
		{
			HOperatorSet.StationaryCameraSelfCalibration(numImages, imageWidth, imageHeight, referenceImage, mappingSource, mappingDest, homMatrices2D, rows1, cols1, rows2, cols2, numCorrespondences, estimationMethod, cameraModel, fixedCameraParams, out HTuple cameraMatrices, out HTuple kappa, out HTuple rotationMatrices, out HTuple x, out HTuple y, out HTuple z, out HTuple error);
			return (cameraMatrices,kappa,rotationMatrices,x,y,z,error);
		}
		public static (HTuple pose, HTuple covPose, HTuple error) GetRectanglePose (HObject contour, HTuple cameraParam, HTuple width, HTuple height, HTuple weightingMode, HTuple clippingFactor)
		{
			HOperatorSet.GetRectanglePose(contour, cameraParam, width, height, weightingMode, clippingFactor, out HTuple pose, out HTuple covPose, out HTuple error);
			return (pose,covPose,error);
		}
		public static (HTuple pose1, HTuple pose2) GetCirclePose (HObject contour, HTuple cameraParam, HTuple radius, HTuple outputType)
		{
			HOperatorSet.GetCirclePose(contour, cameraParam, radius, outputType, out HTuple pose1, out HTuple pose2);
			return (pose1,pose2);
		}
		public static HTuple RadiometricSelfCalibration (HObject images, HTuple exposureRatios, HTuple features, HTuple functionType, HTuple smoothness, HTuple polynomialDegree)
		{
			HOperatorSet.RadiometricSelfCalibration(images, exposureRatios, features, functionType, smoothness, polynomialDegree, out HTuple inverseResponse);
			return inverseResponse;
		}
		public static HObject MapImage (HObject image, HObject map)
		{
			HOperatorSet.MapImage(image, map, out HObject imageMapped);
			return imageMapped;
		}
		public static HObject GenRadialDistortionMap (HTuple camParamIn, HTuple camParamOut, HTuple mapType)
		{
			HOperatorSet.GenRadialDistortionMap(out HObject map, camParamIn, camParamOut, mapType);
			return map;
		}
		public static HObject GenImageToWorldPlaneMap (HTuple cameraParam, HTuple worldPose, HTuple widthIn, HTuple heightIn, HTuple widthMapped, HTuple heightMapped, HTuple scale, HTuple mapType)
		{
			HOperatorSet.GenImageToWorldPlaneMap(out HObject map, cameraParam, worldPose, widthIn, heightIn, widthMapped, heightMapped, scale, mapType);
			return map;
		}
		public static HObject ImageToWorldPlane (HObject image, HTuple cameraParam, HTuple worldPose, HTuple width, HTuple height, HTuple scale, HTuple interpolation)
		{
			HOperatorSet.ImageToWorldPlane(image, out HObject imageWorld, cameraParam, worldPose, width, height, scale, interpolation);
			return imageWorld;
		}
		public static HObject ContourToWorldPlaneXld (HObject contours, HTuple cameraParam, HTuple worldPose, HTuple scale)
		{
			HOperatorSet.ContourToWorldPlaneXld(contours, out HObject contoursTrans, cameraParam, worldPose, scale);
			return contoursTrans;
		}
		public static (HTuple x, HTuple y) ImagePointsToWorldPlane (HTuple cameraParam, HTuple worldPose, HTuple rows, HTuple cols, HTuple scale)
		{
			HOperatorSet.ImagePointsToWorldPlane(cameraParam, worldPose, rows, cols, scale, out HTuple x, out HTuple y);
			return (x,y);
		}
		public static HTuple SetOriginPose (HTuple poseIn, HTuple DX, HTuple DY, HTuple DZ)
		{
			HOperatorSet.SetOriginPose(poseIn, DX, DY, DZ, out HTuple poseNewOrigin);
			return poseNewOrigin;
		}
		public static (HTuple cameraPose, HTuple calibrationPose, HTuple quality) HandEyeCalibration (HTuple x, HTuple y, HTuple z, HTuple row, HTuple col, HTuple numPoints, HTuple robotPoses, HTuple cameraParam, HTuple method, HTuple qualityType)
		{
			HOperatorSet.HandEyeCalibration(x, y, z, row, col, numPoints, robotPoses, cameraParam, method, qualityType, out HTuple cameraPose, out HTuple calibrationPose, out HTuple quality);
			return (cameraPose,calibrationPose,quality);
		}
		public static (HTuple orderOfTransform, HTuple orderOfRotation, HTuple viewOfTransform) GetPoseType (HTuple pose)
		{
			HOperatorSet.GetPoseType(pose, out HTuple orderOfTransform, out HTuple orderOfRotation, out HTuple viewOfTransform);
			return (orderOfTransform,orderOfRotation,viewOfTransform);
		}
		public static void FnewLine (HTuple fileHandle)
		{
			HOperatorSet.FnewLine(fileHandle);
		}
		public static void CloseFile (HTuple fileHandle)
		{
			HOperatorSet.CloseFile(fileHandle);
		}
		public static void CloseAllFiles ()
		{
			HOperatorSet.CloseAllFiles();
		}
		public static HTuple TestClosedXld (HObject XLD)
		{
			HOperatorSet.TestClosedXld(XLD, out HTuple isClosed);
			return isClosed;
		}
		public static HTuple GetGrayvalContourXld (HObject image, HObject contour, HTuple interpolation)
		{
			HOperatorSet.GetGrayvalContourXld(image, contour, interpolation, out HTuple grayval);
			return grayval;
		}
		public static HTuple MomentsAnyPointsXld (HObject XLD, HTuple mode, HTuple area, HTuple centerRow, HTuple centerCol, HTuple p, HTuple q)
		{
			HOperatorSet.MomentsAnyPointsXld(XLD, mode, area, centerRow, centerCol, p, q, out HTuple m);
			return m;
		}
		public static HTuple EccentricityPointsXld (HObject XLD)
		{
			HOperatorSet.EccentricityPointsXld(XLD, out HTuple anisometry);
			return anisometry;
		}
		public static (HTuple ra, HTuple rb, HTuple phi) EllipticAxisPointsXld (HObject XLD)
		{
			HOperatorSet.EllipticAxisPointsXld(XLD, out HTuple ra, out HTuple rb, out HTuple phi);
			return (ra,rb,phi);
		}
		public static HTuple OrientationPointsXld (HObject XLD)
		{
			HOperatorSet.OrientationPointsXld(XLD, out HTuple phi);
			return phi;
		}
		public static (HTuple m11, HTuple m20, HTuple m02) MomentsPointsXld (HObject XLD)
		{
			HOperatorSet.MomentsPointsXld(XLD, out HTuple m11, out HTuple m20, out HTuple m02);
			return (m11,m20,m02);
		}
		public static (HTuple area, HTuple row, HTuple column) AreaCenterPointsXld (HObject XLD)
		{
			HOperatorSet.AreaCenterPointsXld(XLD, out HTuple area, out HTuple row, out HTuple column);
			return (area,row,column);
		}
		public static HTuple TestSelfIntersectionXld (HObject XLD, HTuple closeXLD)
		{
			HOperatorSet.TestSelfIntersectionXld(XLD, closeXLD, out HTuple doesIntersect);
			return doesIntersect;
		}
		public static HObject SelectXldPoint (HObject XLDs, HTuple row, HTuple column)
		{
			HOperatorSet.SelectXldPoint(XLDs, out HObject destXLDs, row, column);
			return destXLDs;
		}
		public static HTuple TestXldPoint (HObject XLD, HTuple row, HTuple column)
		{
			HOperatorSet.TestXldPoint(XLD, row, column, out HTuple isInside);
			return isInside;
		}
		public static HObject SelectShapeXld (HObject XLD, HTuple features, HTuple operation, HTuple min, HTuple max)
		{
			HOperatorSet.SelectShapeXld(XLD, out HObject selectedXLD, features, operation, min, max);
			return selectedXLD;
		}
		public static HTuple OrientationXld (HObject XLD)
		{
			HOperatorSet.OrientationXld(XLD, out HTuple phi);
			return phi;
		}
		public static (HTuple anisometry, HTuple bulkiness, HTuple structureFactor) EccentricityXld (HObject XLD)
		{
			HOperatorSet.EccentricityXld(XLD, out HTuple anisometry, out HTuple bulkiness, out HTuple structureFactor);
			return (anisometry,bulkiness,structureFactor);
		}
		public static HTuple CompactnessXld (HObject XLD)
		{
			HOperatorSet.CompactnessXld(XLD, out HTuple compactness);
			return compactness;
		}
		public static (HTuple row1, HTuple column1, HTuple row2, HTuple column2, HTuple diameter) DiameterXld (HObject XLD)
		{
			HOperatorSet.DiameterXld(XLD, out HTuple row1, out HTuple column1, out HTuple row2, out HTuple column2, out HTuple diameter);
			return (row1,column1,row2,column2,diameter);
		}
		public static HTuple ConvexityXld (HObject XLD)
		{
			HOperatorSet.ConvexityXld(XLD, out HTuple convexity);
			return convexity;
		}
		public static HTuple CircularityXld (HObject XLD)
		{
			HOperatorSet.CircularityXld(XLD, out HTuple circularity);
			return circularity;
		}
		public static (HTuple ra, HTuple rb, HTuple phi) EllipticAxisXld (HObject XLD)
		{
			HOperatorSet.EllipticAxisXld(XLD, out HTuple ra, out HTuple rb, out HTuple phi);
			return (ra,rb,phi);
		}
		public static (HTuple row, HTuple column, HTuple phi, HTuple length1, HTuple length2) SmallestRectangle2Xld (HObject XLD)
		{
			HOperatorSet.SmallestRectangle2Xld(XLD, out HTuple row, out HTuple column, out HTuple phi, out HTuple length1, out HTuple length2);
			return (row,column,phi,length1,length2);
		}
		public static (HTuple row1, HTuple column1, HTuple row2, HTuple column2) SmallestRectangle1Xld (HObject XLD)
		{
			HOperatorSet.SmallestRectangle1Xld(XLD, out HTuple row1, out HTuple column1, out HTuple row2, out HTuple column2);
			return (row1,column1,row2,column2);
		}
		public static (HTuple row, HTuple column, HTuple radius) SmallestCircleXld (HObject XLD)
		{
			HOperatorSet.SmallestCircleXld(XLD, out HTuple row, out HTuple column, out HTuple radius);
			return (row,column,radius);
		}
		public static HObject ShapeTransXld (HObject XLD, HTuple type)
		{
			HOperatorSet.ShapeTransXld(XLD, out HObject XLDTrans, type);
			return XLDTrans;
		}
		public static HTuple LengthXld (HObject XLD)
		{
			HOperatorSet.LengthXld(XLD, out HTuple length);
			return length;
		}
		public static HTuple MomentsAnyXld (HObject XLD, HTuple mode, HTuple pointOrder, HTuple area, HTuple centerRow, HTuple centerCol, HTuple p, HTuple q)
		{
			HOperatorSet.MomentsAnyXld(XLD, mode, pointOrder, area, centerRow, centerCol, p, q, out HTuple m);
			return m;
		}
		public static (HTuple m11, HTuple m20, HTuple m02) MomentsXld (HObject XLD)
		{
			HOperatorSet.MomentsXld(XLD, out HTuple m11, out HTuple m20, out HTuple m02);
			return (m11,m20,m02);
		}
		public static (HTuple area, HTuple row, HTuple column, HTuple pointOrder) AreaCenterXld (HObject XLD)
		{
			HOperatorSet.AreaCenterXld(XLD, out HTuple area, out HTuple row, out HTuple column, out HTuple pointOrder);
			return (area,row,column,pointOrder);
		}
		public static (HTuple PSI1, HTuple PSI2, HTuple PSI3, HTuple PSI4) MomentsRegionCentralInvar (HObject regions)
		{
			HOperatorSet.MomentsRegionCentralInvar(regions, out HTuple PSI1, out HTuple PSI2, out HTuple PSI3, out HTuple PSI4);
			return (PSI1,PSI2,PSI3,PSI4);
		}
		public static (HTuple i1, HTuple i2, HTuple i3, HTuple i4) MomentsRegionCentral (HObject regions)
		{
			HOperatorSet.MomentsRegionCentral(regions, out HTuple i1, out HTuple i2, out HTuple i3, out HTuple i4);
			return (i1,i2,i3,i4);
		}
		public static (HTuple m21, HTuple m12, HTuple m03, HTuple m30) MomentsRegion3rdInvar (HObject regions)
		{
			HOperatorSet.MomentsRegion3rdInvar(regions, out HTuple m21, out HTuple m12, out HTuple m03, out HTuple m30);
			return (m21,m12,m03,m30);
		}
		public static (HTuple m21, HTuple m12, HTuple m03, HTuple m30) MomentsRegion3rd (HObject regions)
		{
			HOperatorSet.MomentsRegion3rd(regions, out HTuple m21, out HTuple m12, out HTuple m03, out HTuple m30);
			return (m21,m12,m03,m30);
		}
		public static (HTuple row, HTuple column, HTuple phi, HTuple length1, HTuple length2) SmallestRectangle2 (HObject regions)
		{
			HOperatorSet.SmallestRectangle2(regions, out HTuple row, out HTuple column, out HTuple phi, out HTuple length1, out HTuple length2);
			return (row,column,phi,length1,length2);
		}
		public static (HTuple row1, HTuple column1, HTuple row2, HTuple column2) SmallestRectangle1 (HObject regions)
		{
			HOperatorSet.SmallestRectangle1(regions, out HTuple row1, out HTuple column1, out HTuple row2, out HTuple column2);
			return (row1,column1,row2,column2);
		}
		public static (HTuple row, HTuple column, HTuple radius) SmallestCircle (HObject regions)
		{
			HOperatorSet.SmallestCircle(regions, out HTuple row, out HTuple column, out HTuple radius);
			return (row,column,radius);
		}
		public static HObject SelectShapeProto (HObject regions, HObject pattern, HTuple feature, HTuple min, HTuple max)
		{
			HOperatorSet.SelectShapeProto(regions, pattern, out HObject selectedRegions, feature, min, max);
			return selectedRegions;
		}
		public static HTuple RegionFeatures (HObject regions, HTuple features)
		{
			HOperatorSet.RegionFeatures(regions, features, out HTuple value);
			return value;
		}
		public static HObject SelectShape (HObject regions, HTuple features, HTuple operation, HTuple min, HTuple max)
		{
			HOperatorSet.SelectShape(regions, out HObject selectedRegions, features, operation, min, max);
			return selectedRegions;
		}
		public static (HTuple numRuns, HTuple KFactor, HTuple LFactor, HTuple meanLength, HTuple bytes) RunlengthFeatures (HObject regions)
		{
			HOperatorSet.RunlengthFeatures(regions, out HTuple numRuns, out HTuple KFactor, out HTuple LFactor, out HTuple meanLength, out HTuple bytes);
			return (numRuns,KFactor,LFactor,meanLength,bytes);
		}
		public static (HTuple regionIndex1, HTuple regionIndex2) FindNeighbors (HObject regions1, HObject regions2, HTuple maxDistance)
		{
			HOperatorSet.FindNeighbors(regions1, regions2, maxDistance, out HTuple regionIndex1, out HTuple regionIndex2);
			return (regionIndex1,regionIndex2);
		}
		public static (HTuple PHI1, HTuple PHI2) MomentsRegion2ndRelInvar (HObject regions)
		{
			HOperatorSet.MomentsRegion2ndRelInvar(regions, out HTuple PHI1, out HTuple PHI2);
			return (PHI1,PHI2);
		}
		public static (HTuple m11, HTuple m20, HTuple m02) MomentsRegion2ndInvar (HObject regions)
		{
			HOperatorSet.MomentsRegion2ndInvar(regions, out HTuple m11, out HTuple m20, out HTuple m02);
			return (m11,m20,m02);
		}
		public static (HTuple m11, HTuple m20, HTuple m02, HTuple ia, HTuple ib) MomentsRegion2nd (HObject regions)
		{
			HOperatorSet.MomentsRegion2nd(regions, out HTuple m11, out HTuple m20, out HTuple m02, out HTuple ia, out HTuple ib);
			return (m11,m20,m02,ia,ib);
		}
		public static (HTuple minDistance, HTuple row1, HTuple column1, HTuple row2, HTuple column2) DistanceRrMin (HObject regions1, HObject regions2)
		{
			HOperatorSet.DistanceRrMin(regions1, regions2, out HTuple minDistance, out HTuple row1, out HTuple column1, out HTuple row2, out HTuple column2);
			return (minDistance,row1,column1,row2,column2);
		}
		public static HTuple DistanceRrMinDil (HObject regions1, HObject regions2)
		{
			HOperatorSet.DistanceRrMinDil(regions1, regions2, out HTuple minDistance);
			return minDistance;
		}
		public static (HTuple row1, HTuple column1, HTuple row2, HTuple column2, HTuple diameter) DiameterRegion (HObject regions)
		{
			HOperatorSet.DiameterRegion(regions, out HTuple row1, out HTuple column1, out HTuple row2, out HTuple column2, out HTuple diameter);
			return (row1,column1,row2,column2,diameter);
		}
		public static HTuple TestRegionPoint (HObject regions, HTuple row, HTuple column)
		{
			HOperatorSet.TestRegionPoint(regions, row, column, out HTuple isInside);
			return isInside;
		}
		public static HTuple GetRegionIndex (HObject regions, HTuple row, HTuple column)
		{
			HOperatorSet.GetRegionIndex(regions, row, column, out HTuple index);
			return index;
		}
		public static HObject SelectRegionPoint (HObject regions, HTuple row, HTuple column)
		{
			HOperatorSet.SelectRegionPoint(regions, out HObject destRegions, row, column);
			return destRegions;
		}
		public static HObject SelectShapeStd (HObject regions, HTuple shape, HTuple percent)
		{
			HOperatorSet.SelectShapeStd(regions, out HObject selectedRegions, shape, percent);
			return selectedRegions;
		}
		public static (HTuple distance, HTuple similarity) HammingDistanceNorm (HObject regions1, HObject regions2, HTuple norm)
		{
			HOperatorSet.HammingDistanceNorm(regions1, regions2, norm, out HTuple distance, out HTuple similarity);
			return (distance,similarity);
		}
		public static (HTuple distance, HTuple similarity) HammingDistance (HObject regions1, HObject regions2)
		{
			HOperatorSet.HammingDistance(regions1, regions2, out HTuple distance, out HTuple similarity);
			return (distance,similarity);
		}
		public static (HTuple anisometry, HTuple bulkiness, HTuple structureFactor) Eccentricity (HObject regions)
		{
			HOperatorSet.Eccentricity(regions, out HTuple anisometry, out HTuple bulkiness, out HTuple structureFactor);
			return (anisometry,bulkiness,structureFactor);
		}
		public static HTuple EulerNumber (HObject regions)
		{
			HOperatorSet.EulerNumber(regions, out HTuple eulerNumber);
			return eulerNumber;
		}
		public static HTuple OrientationRegion (HObject regions)
		{
			HOperatorSet.OrientationRegion(regions, out HTuple phi);
			return phi;
		}
		public static (HTuple ra, HTuple rb, HTuple phi) EllipticAxis (HObject regions)
		{
			HOperatorSet.EllipticAxis(regions, out HTuple ra, out HTuple rb, out HTuple phi);
			return (ra,rb,phi);
		}
		public static (HTuple regionIndex1, HTuple regionIndex2) SelectRegionSpatial (HObject regions1, HObject regions2, HTuple direction)
		{
			HOperatorSet.SelectRegionSpatial(regions1, regions2, direction, out HTuple regionIndex1, out HTuple regionIndex2);
			return (regionIndex1,regionIndex2);
		}
		public static (HTuple regionIndex1, HTuple regionIndex2, HTuple relation1, HTuple relation2) SpatialRelation (HObject regions1, HObject regions2, HTuple percent)
		{
			HOperatorSet.SpatialRelation(regions1, regions2, percent, out HTuple regionIndex1, out HTuple regionIndex2, out HTuple relation1, out HTuple relation2);
			return (regionIndex1,regionIndex2,relation1,relation2);
		}
		public static HTuple Convexity (HObject regions)
		{
			HOperatorSet.Convexity(regions, out HTuple convexity);
			return convexity;
		}
		public static HTuple Contlength (HObject regions)
		{
			HOperatorSet.Contlength(regions, out HTuple contLength);
			return contLength;
		}
		public static (HTuple numConnected, HTuple numHoles) ConnectAndHoles (HObject regions)
		{
			HOperatorSet.ConnectAndHoles(regions, out HTuple numConnected, out HTuple numHoles);
			return (numConnected,numHoles);
		}
		public static HTuple Rectangularity (HObject regions)
		{
			HOperatorSet.Rectangularity(regions, out HTuple rectangularity);
			return rectangularity;
		}
		public static HTuple Compactness (HObject regions)
		{
			HOperatorSet.Compactness(regions, out HTuple compactness);
			return compactness;
		}
		public static HTuple Circularity (HObject regions)
		{
			HOperatorSet.Circularity(regions, out HTuple circularity);
			return circularity;
		}
		public static HTuple AreaHoles (HObject regions)
		{
			HOperatorSet.AreaHoles(regions, out HTuple area);
			return area;
		}
		public static (HTuple area, HTuple row, HTuple column) AreaCenter (HObject regions)
		{
			HOperatorSet.AreaCenter(regions, out HTuple area, out HTuple row, out HTuple column);
			return (area,row,column);
		}
		public static (HTuple foreground, HTuple background) RunlengthDistribution (HObject region)
		{
			HOperatorSet.RunlengthDistribution(region, out HTuple foreground, out HTuple background);
			return (foreground,background);
		}
		public static (HTuple distance, HTuple sigma, HTuple roundness, HTuple sides) Roundness (HObject regions)
		{
			HOperatorSet.Roundness(regions, out HTuple distance, out HTuple sigma, out HTuple roundness, out HTuple sides);
			return (distance,sigma,roundness,sides);
		}
		public static (HTuple row1, HTuple column1, HTuple row2, HTuple column2) InnerRectangle1 (HObject regions)
		{
			HOperatorSet.InnerRectangle1(regions, out HTuple row1, out HTuple column1, out HTuple row2, out HTuple column2);
			return (row1,column1,row2,column2);
		}
		public static (HTuple row, HTuple column, HTuple radius) InnerCircle (HObject regions)
		{
			HOperatorSet.InnerCircle(regions, out HTuple row, out HTuple column, out HTuple radius);
			return (row,column,radius);
		}
		public static (HTuple rowBeginOut, HTuple colBeginOut, HTuple rowEndOut, HTuple colEndOut) SelectLinesLongest (HTuple rowBeginIn, HTuple colBeginIn, HTuple rowEndIn, HTuple colEndIn, HTuple num)
		{
			HOperatorSet.SelectLinesLongest(rowBeginIn, colBeginIn, rowEndIn, colEndIn, num, out HTuple rowBeginOut, out HTuple colBeginOut, out HTuple rowEndOut, out HTuple colEndOut);
			return (rowBeginOut,colBeginOut,rowEndOut,colEndOut);
		}
		public static (HTuple rowBeginOut, HTuple colBeginOut, HTuple rowEndOut, HTuple colEndOut, HTuple failRowBOut, HTuple failColBOut, HTuple failRowEOut, HTuple failColEOut) PartitionLines (HTuple rowBeginIn, HTuple colBeginIn, HTuple rowEndIn, HTuple colEndIn, HTuple feature, HTuple operation, HTuple min, HTuple max)
		{
			HOperatorSet.PartitionLines(rowBeginIn, colBeginIn, rowEndIn, colEndIn, feature, operation, min, max, out HTuple rowBeginOut, out HTuple colBeginOut, out HTuple rowEndOut, out HTuple colEndOut, out HTuple failRowBOut, out HTuple failColBOut, out HTuple failRowEOut, out HTuple failColEOut);
			return (rowBeginOut,colBeginOut,rowEndOut,colEndOut,failRowBOut,failColBOut,failRowEOut,failColEOut);
		}
		public static (HTuple rowBeginOut, HTuple colBeginOut, HTuple rowEndOut, HTuple colEndOut) SelectLines (HTuple rowBeginIn, HTuple colBeginIn, HTuple rowEndIn, HTuple colEndIn, HTuple feature, HTuple operation, HTuple min, HTuple max)
		{
			HOperatorSet.SelectLines(rowBeginIn, colBeginIn, rowEndIn, colEndIn, feature, operation, min, max, out HTuple rowBeginOut, out HTuple colBeginOut, out HTuple rowEndOut, out HTuple colEndOut);
			return (rowBeginOut,colBeginOut,rowEndOut,colEndOut);
		}
		public static (HTuple rowCenter, HTuple colCenter, HTuple length, HTuple phi) LinePosition (HTuple rowBegin, HTuple colBegin, HTuple rowEnd, HTuple colEnd)
		{
			HOperatorSet.LinePosition(rowBegin, colBegin, rowEnd, colEnd, out HTuple rowCenter, out HTuple colCenter, out HTuple length, out HTuple phi);
			return (rowCenter,colCenter,length,phi);
		}
		public static HTuple LineOrientation (HTuple rowBegin, HTuple colBegin, HTuple rowEnd, HTuple colEnd)
		{
			HOperatorSet.LineOrientation(rowBegin, colBegin, rowEnd, colEnd, out HTuple phi);
			return phi;
		}
		public static (HTuple arcCenterRow, HTuple arcCenterCol, HTuple arcAngle, HTuple arcBeginRow, HTuple arcBeginCol, HTuple lineBeginRow, HTuple lineBeginCol, HTuple lineEndRow, HTuple lineEndCol, HTuple order) ApproxChainSimple (HTuple row, HTuple column)
		{
			HOperatorSet.ApproxChainSimple(row, column, out HTuple arcCenterRow, out HTuple arcCenterCol, out HTuple arcAngle, out HTuple arcBeginRow, out HTuple arcBeginCol, out HTuple lineBeginRow, out HTuple lineBeginCol, out HTuple lineEndRow, out HTuple lineEndCol, out HTuple order);
			return (arcCenterRow,arcCenterCol,arcAngle,arcBeginRow,arcBeginCol,lineBeginRow,lineBeginCol,lineEndRow,lineEndCol,order);
		}
		public static (HTuple arcCenterRow, HTuple arcCenterCol, HTuple arcAngle, HTuple arcBeginRow, HTuple arcBeginCol, HTuple lineBeginRow, HTuple lineBeginCol, HTuple lineEndRow, HTuple lineEndCol, HTuple order) ApproxChain (HTuple row, HTuple column, HTuple minWidthCoord, HTuple maxWidthCoord, HTuple threshStart, HTuple threshEnd, HTuple threshStep, HTuple minWidthSmooth, HTuple maxWidthSmooth, HTuple minWidthCurve, HTuple maxWidthCurve, HTuple weight1, HTuple weight2, HTuple weight3)
		{
			HOperatorSet.ApproxChain(row, column, minWidthCoord, maxWidthCoord, threshStart, threshEnd, threshStep, minWidthSmooth, maxWidthSmooth, minWidthCurve, maxWidthCurve, weight1, weight2, weight3, out HTuple arcCenterRow, out HTuple arcCenterCol, out HTuple arcAngle, out HTuple arcBeginRow, out HTuple arcBeginCol, out HTuple lineBeginRow, out HTuple lineBeginCol, out HTuple lineEndRow, out HTuple lineEndCol, out HTuple order);
			return (arcCenterRow,arcCenterCol,arcAngle,arcBeginRow,arcBeginCol,lineBeginRow,lineBeginCol,lineEndRow,lineEndCol,order);
		}
		public static (HTuple alpha, HTuple beta, HTuple gamma) FitSurfaceFirstOrder (HObject regions, HObject image, HTuple algorithm, HTuple iterations, HTuple clippingFactor)
		{
			HOperatorSet.FitSurfaceFirstOrder(regions, image, algorithm, iterations, clippingFactor, out HTuple alpha, out HTuple beta, out HTuple gamma);
			return (alpha,beta,gamma);
		}
		public static (HTuple alpha, HTuple beta, HTuple gamma, HTuple delta, HTuple epsilon, HTuple zeta) FitSurfaceSecondOrder (HObject regions, HObject image, HTuple algorithm, HTuple iterations, HTuple clippingFactor)
		{
			HOperatorSet.FitSurfaceSecondOrder(regions, image, algorithm, iterations, clippingFactor, out HTuple alpha, out HTuple beta, out HTuple gamma, out HTuple delta, out HTuple epsilon, out HTuple zeta);
			return (alpha,beta,gamma,delta,epsilon,zeta);
		}
		public static HObject GenImageSurfaceSecondOrder (HTuple type, HTuple alpha, HTuple beta, HTuple gamma, HTuple delta, HTuple epsilon, HTuple zeta, HTuple row, HTuple column, HTuple width, HTuple height)
		{
			HOperatorSet.GenImageSurfaceSecondOrder(out HObject imageSurface, type, alpha, beta, gamma, delta, epsilon, zeta, row, column, width, height);
			return imageSurface;
		}
		public static HObject GenImageSurfaceFirstOrder (HTuple type, HTuple alpha, HTuple beta, HTuple gamma, HTuple row, HTuple column, HTuple width, HTuple height)
		{
			HOperatorSet.GenImageSurfaceFirstOrder(out HObject imageSurface, type, alpha, beta, gamma, row, column, width, height);
			return imageSurface;
		}
		public static (HTuple absoluteHisto, HTuple relativeHisto) ShapeHistoPoint (HObject region, HObject image, HTuple feature, HTuple row, HTuple column)
		{
			HOperatorSet.ShapeHistoPoint(region, image, feature, row, column, out HTuple absoluteHisto, out HTuple relativeHisto);
			return (absoluteHisto,relativeHisto);
		}
		public static (HTuple absoluteHisto, HTuple relativeHisto) ShapeHistoAll (HObject region, HObject image, HTuple feature)
		{
			HOperatorSet.ShapeHistoAll(region, image, feature, out HTuple absoluteHisto, out HTuple relativeHisto);
			return (absoluteHisto,relativeHisto);
		}
		public static HTuple GrayFeatures (HObject regions, HObject image, HTuple features)
		{
			HOperatorSet.GrayFeatures(regions, image, features, out HTuple value);
			return value;
		}
		public static HObject SelectGray (HObject regions, HObject image, HTuple features, HTuple operation, HTuple min, HTuple max)
		{
			HOperatorSet.SelectGray(regions, image, out HObject selectedRegions, features, operation, min, max);
			return selectedRegions;
		}
		public static (HTuple min, HTuple max, HTuple range) MinMaxGray (HObject regions, HObject image, HTuple percent)
		{
			HOperatorSet.MinMaxGray(regions, image, percent, out HTuple min, out HTuple max, out HTuple range);
			return (min,max,range);
		}
		public static (HTuple mean, HTuple deviation) Intensity (HObject regions, HObject image)
		{
			HOperatorSet.Intensity(regions, image, out HTuple mean, out HTuple deviation);
			return (mean,deviation);
		}
		public static (HTuple histo, HTuple binSize) GrayHistoRange (HObject regions, HObject image, HTuple min, HTuple max, HTuple numBins)
		{
			HOperatorSet.GrayHistoRange(regions, image, min, max, numBins, out HTuple histo, out HTuple binSize);
			return (histo,binSize);
		}
		public static HObject Histo2dim (HObject regions, HObject imageCol, HObject imageRow)
		{
			HOperatorSet.Histo2dim(regions, imageCol, imageRow, out HObject histo2Dim);
			return histo2Dim;
		}
		public static HTuple GrayHistoAbs (HObject regions, HObject image, HTuple quantization)
		{
			HOperatorSet.GrayHistoAbs(regions, image, quantization, out HTuple absoluteHisto);
			return absoluteHisto;
		}
		public static (HTuple absoluteHisto, HTuple relativeHisto) GrayHisto (HObject regions, HObject image)
		{
			HOperatorSet.GrayHisto(regions, image, out HTuple absoluteHisto, out HTuple relativeHisto);
			return (absoluteHisto,relativeHisto);
		}
		public static (HTuple entropy, HTuple anisotropy) EntropyGray (HObject regions, HObject image)
		{
			HOperatorSet.EntropyGray(regions, image, out HTuple entropy, out HTuple anisotropy);
			return (entropy,anisotropy);
		}
		public static (HTuple energy, HTuple correlation, HTuple homogeneity, HTuple contrast) CoocFeatureMatrix (HObject coocMatrix)
		{
			HOperatorSet.CoocFeatureMatrix(coocMatrix, out HTuple energy, out HTuple correlation, out HTuple homogeneity, out HTuple contrast);
			return (energy,correlation,homogeneity,contrast);
		}
		public static (HTuple energy, HTuple correlation, HTuple homogeneity, HTuple contrast) CoocFeatureImage (HObject regions, HObject image, HTuple ldGray, HTuple direction)
		{
			HOperatorSet.CoocFeatureImage(regions, image, ldGray, direction, out HTuple energy, out HTuple correlation, out HTuple homogeneity, out HTuple contrast);
			return (energy,correlation,homogeneity,contrast);
		}
		public static HObject GenCoocMatrix (HObject regions, HObject image, HTuple ldGray, HTuple direction)
		{
			HOperatorSet.GenCoocMatrix(regions, image, out HObject matrix, ldGray, direction);
			return matrix;
		}
		public static (HTuple MRow, HTuple MCol, HTuple alpha, HTuple beta, HTuple mean) MomentsGrayPlane (HObject regions, HObject image)
		{
			HOperatorSet.MomentsGrayPlane(regions, image, out HTuple MRow, out HTuple MCol, out HTuple alpha, out HTuple beta, out HTuple mean);
			return (MRow,MCol,alpha,beta,mean);
		}
		public static HTuple PlaneDeviation (HObject regions, HObject image)
		{
			HOperatorSet.PlaneDeviation(regions, image, out HTuple deviation);
			return deviation;
		}
		public static (HTuple ra, HTuple rb, HTuple phi) EllipticAxisGray (HObject regions, HObject image)
		{
			HOperatorSet.EllipticAxisGray(regions, image, out HTuple ra, out HTuple rb, out HTuple phi);
			return (ra,rb,phi);
		}
		public static (HTuple area, HTuple row, HTuple column) AreaCenterGray (HObject regions, HObject image)
		{
			HOperatorSet.AreaCenterGray(regions, image, out HTuple area, out HTuple row, out HTuple column);
			return (area,row,column);
		}
		public static (HTuple horProjection, HTuple vertProjection) GrayProjections (HObject region, HObject image, HTuple mode)
		{
			HOperatorSet.GrayProjections(region, image, mode, out HTuple horProjection, out HTuple vertProjection);
			return (horProjection,vertProjection);
		}
		public static HObject GetDataCode2dObjects (HTuple dataCodeHandle, HTuple candidateHandle, HTuple objectName)
		{
			HOperatorSet.GetDataCode2dObjects(out HObject dataCodeObjects, dataCodeHandle, candidateHandle, objectName);
			return dataCodeObjects;
		}
		public static HTuple GetDataCode2dResults (HTuple dataCodeHandle, HTuple candidateHandle, HTuple resultNames)
		{
			HOperatorSet.GetDataCode2dResults(dataCodeHandle, candidateHandle, resultNames, out HTuple resultValues);
			return resultValues;
		}
		public static (HObject symbolXLDs, HTuple resultHandles, HTuple decodedDataStrings) FindDataCode2d (HObject image, HTuple dataCodeHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.FindDataCode2d(image, out HObject symbolXLDs, dataCodeHandle, genParamName, genParamValue, out HTuple resultHandles, out HTuple decodedDataStrings);
			return (symbolXLDs,resultHandles,decodedDataStrings);
		}
		public static void SetDataCode2dParam (HTuple dataCodeHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetDataCode2dParam(dataCodeHandle, genParamName, genParamValue);
		}
		public static HTuple GetDataCode2dParam (HTuple dataCodeHandle, HTuple genParamName)
		{
			HOperatorSet.GetDataCode2dParam(dataCodeHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static HTuple QueryDataCode2dParams (HTuple dataCodeHandle, HTuple queryName)
		{
			HOperatorSet.QueryDataCode2dParams(dataCodeHandle, queryName, out HTuple genParamName);
			return genParamName;
		}
		public static HTuple DeserializeDataCode2dModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeDataCode2dModel(serializedItemHandle, out HTuple dataCodeHandle);
			return dataCodeHandle;
		}
		public static HTuple SerializeDataCode2dModel (HTuple dataCodeHandle)
		{
			HOperatorSet.SerializeDataCode2dModel(dataCodeHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadDataCode2dModel (HTuple fileName)
		{
			HOperatorSet.ReadDataCode2dModel(fileName, out HTuple dataCodeHandle);
			return dataCodeHandle;
		}
		public static void WriteDataCode2dModel (HTuple dataCodeHandle, HTuple fileName)
		{
			HOperatorSet.WriteDataCode2dModel(dataCodeHandle, fileName);
		}
		public static void ClearAllDataCode2dModels ()
		{
			HOperatorSet.ClearAllDataCode2dModels();
		}
		public static void ClearDataCode2dModel (HTuple dataCodeHandle)
		{
			HOperatorSet.ClearDataCode2dModel(dataCodeHandle);
		}
		public static HTuple CreateDataCode2dModel (HTuple symbolType, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateDataCode2dModel(symbolType, genParamName, genParamValue, out HTuple dataCodeHandle);
			return dataCodeHandle;
		}
		public static HTuple DeserializeClassTrainData (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeClassTrainData(serializedItemHandle, out HTuple classTrainDataHandle);
			return classTrainDataHandle;
		}
		public static HTuple SerializeClassTrainData (HTuple classTrainDataHandle)
		{
			HOperatorSet.SerializeClassTrainData(classTrainDataHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadClassTrainData (HTuple fileName)
		{
			HOperatorSet.ReadClassTrainData(fileName, out HTuple classTrainDataHandle);
			return classTrainDataHandle;
		}
		public static void WriteClassTrainData (HTuple classTrainDataHandle, HTuple fileName)
		{
			HOperatorSet.WriteClassTrainData(classTrainDataHandle, fileName);
		}
		public static HTuple SelectSubFeatureClassTrainData (HTuple classTrainDataHandle, HTuple subFeatureIndices)
		{
			HOperatorSet.SelectSubFeatureClassTrainData(classTrainDataHandle, subFeatureIndices, out HTuple selectedClassTrainDataHandle);
			return selectedClassTrainDataHandle;
		}
		public static void SetFeatureLengthsClassTrainData (HTuple classTrainDataHandle, HTuple subFeatureLength, HTuple names)
		{
			HOperatorSet.SetFeatureLengthsClassTrainData(classTrainDataHandle, subFeatureLength, names);
		}
		public static HTuple GetClassTrainDataGmm (HTuple GMMHandle)
		{
			HOperatorSet.GetClassTrainDataGmm(GMMHandle, out HTuple classTrainDataHandle);
			return classTrainDataHandle;
		}
		public static void AddClassTrainDataGmm (HTuple GMMHandle, HTuple classTrainDataHandle)
		{
			HOperatorSet.AddClassTrainDataGmm(GMMHandle, classTrainDataHandle);
		}
		public static HTuple GetClassTrainDataMlp (HTuple MLPHandle)
		{
			HOperatorSet.GetClassTrainDataMlp(MLPHandle, out HTuple classTrainDataHandle);
			return classTrainDataHandle;
		}
		public static void AddClassTrainDataMlp (HTuple MLPHandle, HTuple classTrainDataHandle)
		{
			HOperatorSet.AddClassTrainDataMlp(MLPHandle, classTrainDataHandle);
		}
		public static HTuple GetClassTrainDataKnn (HTuple KNNHandle)
		{
			HOperatorSet.GetClassTrainDataKnn(KNNHandle, out HTuple classTrainDataHandle);
			return classTrainDataHandle;
		}
		public static void AddClassTrainDataKnn (HTuple KNNHandle, HTuple classTrainDataHandle)
		{
			HOperatorSet.AddClassTrainDataKnn(KNNHandle, classTrainDataHandle);
		}
		public static HTuple GetClassTrainDataSvm (HTuple SVMHandle)
		{
			HOperatorSet.GetClassTrainDataSvm(SVMHandle, out HTuple classTrainDataHandle);
			return classTrainDataHandle;
		}
		public static HTuple SerializeFftOptimizationData ()
		{
			HOperatorSet.SerializeFftOptimizationData(out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static void ReadFftOptimizationData (HTuple fileName)
		{
			HOperatorSet.ReadFftOptimizationData(fileName);
		}
		public static void WriteFftOptimizationData (HTuple fileName)
		{
			HOperatorSet.WriteFftOptimizationData(fileName);
		}
		public static void OptimizeRftSpeed (HTuple width, HTuple height, HTuple mode)
		{
			HOperatorSet.OptimizeRftSpeed(width, height, mode);
		}
		public static void OptimizeFftSpeed (HTuple width, HTuple height, HTuple mode)
		{
			HOperatorSet.OptimizeFftSpeed(width, height, mode);
		}
		public static HObject RftGeneric (HObject image, HTuple direction, HTuple norm, HTuple resultType, HTuple width)
		{
			HOperatorSet.RftGeneric(image, out HObject imageFFT, direction, norm, resultType, width);
			return imageFFT;
		}
		public static HObject FftImageInv (HObject image)
		{
			HOperatorSet.FftImageInv(image, out HObject imageFFTInv);
			return imageFFTInv;
		}
		public static HObject FftImage (HObject image)
		{
			HOperatorSet.FftImage(image, out HObject imageFFT);
			return imageFFT;
		}
		public static HObject FftGeneric (HObject image, HTuple direction, HTuple exponent, HTuple norm, HTuple mode, HTuple resultType)
		{
			HOperatorSet.FftGeneric(image, out HObject imageFFT, direction, exponent, norm, mode, resultType);
			return imageFFT;
		}
		public static HObject ShockFilter (HObject image, HTuple theta, HTuple iterations, HTuple mode, HTuple sigma)
		{
			HOperatorSet.ShockFilter(image, out HObject sharpenedImage, theta, iterations, mode, sigma);
			return sharpenedImage;
		}
		public static HObject MeanCurvatureFlow (HObject image, HTuple sigma, HTuple theta, HTuple iterations)
		{
			HOperatorSet.MeanCurvatureFlow(image, out HObject imageMCF, sigma, theta, iterations);
			return imageMCF;
		}
		public static HObject CoherenceEnhancingDiff (HObject image, HTuple sigma, HTuple rho, HTuple theta, HTuple iterations)
		{
			HOperatorSet.CoherenceEnhancingDiff(image, out HObject imageCED, sigma, rho, theta, iterations);
			return imageCED;
		}
		public static HObject EquHistoImage (HObject image)
		{
			HOperatorSet.EquHistoImage(image, out HObject imageEquHisto);
			return imageEquHisto;
		}
		public static HObject Illuminate (HObject image, HTuple maskWidth, HTuple maskHeight, HTuple factor)
		{
			HOperatorSet.Illuminate(image, out HObject imageIlluminate, maskWidth, maskHeight, factor);
			return imageIlluminate;
		}
		public static HObject Emphasize (HObject image, HTuple maskWidth, HTuple maskHeight, HTuple factor)
		{
			HOperatorSet.Emphasize(image, out HObject imageEmphasize, maskWidth, maskHeight, factor);
			return imageEmphasize;
		}
		public static HObject ScaleImageMax (HObject image)
		{
			HOperatorSet.ScaleImageMax(image, out HObject imageScaleMax);
			return imageScaleMax;
		}
		public static (HObject imageEdgeAmp, HObject imageEdgeDir) RobinsonDir (HObject image)
		{
			HOperatorSet.RobinsonDir(image, out HObject imageEdgeAmp, out HObject imageEdgeDir);
			return (imageEdgeAmp,imageEdgeDir);
		}
		public static HObject RobinsonAmp (HObject image)
		{
			HOperatorSet.RobinsonAmp(image, out HObject imageEdgeAmp);
			return imageEdgeAmp;
		}
		public static (HObject imageEdgeAmp, HObject imageEdgeDir) KirschDir (HObject image)
		{
			HOperatorSet.KirschDir(image, out HObject imageEdgeAmp, out HObject imageEdgeDir);
			return (imageEdgeAmp,imageEdgeDir);
		}
		public static HObject KirschAmp (HObject image)
		{
			HOperatorSet.KirschAmp(image, out HObject imageEdgeAmp);
			return imageEdgeAmp;
		}
		public static (HObject imageEdgeAmp, HObject imageEdgeDir) FreiDir (HObject image)
		{
			HOperatorSet.FreiDir(image, out HObject imageEdgeAmp, out HObject imageEdgeDir);
			return (imageEdgeAmp,imageEdgeDir);
		}
		public static HObject FreiAmp (HObject image)
		{
			HOperatorSet.FreiAmp(image, out HObject imageEdgeAmp);
			return imageEdgeAmp;
		}
		public static (HObject imageEdgeAmp, HObject imageEdgeDir) PrewittDir (HObject image)
		{
			HOperatorSet.PrewittDir(image, out HObject imageEdgeAmp, out HObject imageEdgeDir);
			return (imageEdgeAmp,imageEdgeDir);
		}
		public static HObject PrewittAmp (HObject image)
		{
			HOperatorSet.PrewittAmp(image, out HObject imageEdgeAmp);
			return imageEdgeAmp;
		}
		public static HObject SobelAmp (HObject image, HTuple filterType, HTuple size)
		{
			HOperatorSet.SobelAmp(image, out HObject edgeAmplitude, filterType, size);
			return edgeAmplitude;
		}
		public static (HObject edgeAmplitude, HObject edgeDirection) SobelDir (HObject image, HTuple filterType, HTuple size)
		{
			HOperatorSet.SobelDir(image, out HObject edgeAmplitude, out HObject edgeDirection, filterType, size);
			return (edgeAmplitude,edgeDirection);
		}
		public static HObject Roberts (HObject image, HTuple filterType)
		{
			HOperatorSet.Roberts(image, out HObject imageRoberts, filterType);
			return imageRoberts;
		}
		public static HObject Laplace (HObject image, HTuple resultType, HTuple maskSize, HTuple filterMask)
		{
			HOperatorSet.Laplace(image, out HObject imageLaplace, resultType, maskSize, filterMask);
			return imageLaplace;
		}
		public static HObject HighpassImage (HObject image, HTuple width, HTuple height)
		{
			HOperatorSet.HighpassImage(image, out HObject highpass, width, height);
			return highpass;
		}
		public static (HTuple size, HTuple coeffs) InfoEdges (HTuple filter, HTuple mode, HTuple alpha)
		{
			HOperatorSet.InfoEdges(filter, mode, alpha, out HTuple size, out HTuple coeffs);
			return (size,coeffs);
		}
		public static HObject EdgesColorSubPix (HObject image, HTuple filter, HTuple alpha, HTuple low, HTuple high)
		{
			HOperatorSet.EdgesColorSubPix(image, out HObject edges, filter, alpha, low, high);
			return edges;
		}
		public static (HObject imaAmp, HObject imaDir) EdgesColor (HObject image, HTuple filter, HTuple alpha, HTuple NMS, HTuple low, HTuple high)
		{
			HOperatorSet.EdgesColor(image, out HObject imaAmp, out HObject imaDir, filter, alpha, NMS, low, high);
			return (imaAmp,imaDir);
		}
		public static HObject EdgesSubPix (HObject image, HTuple filter, HTuple alpha, HTuple low, HTuple high)
		{
			HOperatorSet.EdgesSubPix(image, out HObject edges, filter, alpha, low, high);
			return edges;
		}
		public static (HObject imaAmp, HObject imaDir) EdgesImage (HObject image, HTuple filter, HTuple alpha, HTuple NMS, HTuple low, HTuple high)
		{
			HOperatorSet.EdgesImage(image, out HObject imaAmp, out HObject imaDir, filter, alpha, NMS, low, high);
			return (imaAmp,imaDir);
		}
		public static HObject DerivateGauss (HObject image, HTuple sigma, HTuple component)
		{
			HOperatorSet.DerivateGauss(image, out HObject derivGauss, sigma, component);
			return derivGauss;
		}
		public static HObject LaplaceOfGauss (HObject image, HTuple sigma)
		{
			HOperatorSet.LaplaceOfGauss(image, out HObject imageLaplace, sigma);
			return imageLaplace;
		}
		public static HObject DiffOfGauss (HObject image, HTuple sigma, HTuple sigFactor)
		{
			HOperatorSet.DiffOfGauss(image, out HObject diffOfGauss, sigma, sigFactor);
			return diffOfGauss;
		}
		public static HObject CloseEdgesLength (HObject edges, HObject gradient, HTuple minAmplitude, HTuple maxGapLength)
		{
			HOperatorSet.CloseEdgesLength(edges, gradient, out HObject closedEdges, minAmplitude, maxGapLength);
			return closedEdges;
		}
		public static HObject CloseEdges (HObject edges, HObject edgeImage, HTuple minAmplitude)
		{
			HOperatorSet.CloseEdges(edges, edgeImage, out HObject regionResult, minAmplitude);
			return regionResult;
		}
		public static (HTuple beginRow, HTuple beginCol, HTuple endRow, HTuple endCol) DetectEdgeSegments (HObject image, HTuple sobelSize, HTuple minAmplitude, HTuple maxDistance, HTuple minLength)
		{
			HOperatorSet.DetectEdgeSegments(image, sobelSize, minAmplitude, maxDistance, minLength, out HTuple beginRow, out HTuple beginCol, out HTuple endRow, out HTuple endCol);
			return (beginRow,beginCol,endRow,endCol);
		}
		public static void ClearAllColorTransLuts ()
		{
			HOperatorSet.ClearAllColorTransLuts();
		}
		public static void ClearColorTransLut (HTuple colorTransLUTHandle)
		{
			HOperatorSet.ClearColorTransLut(colorTransLUTHandle);
		}
		public static (HObject imageResult1, HObject imageResult2, HObject imageResult3) ApplyColorTransLut (HObject image1, HObject image2, HObject image3, HTuple colorTransLUTHandle)
		{
			HOperatorSet.ApplyColorTransLut(image1, image2, image3, out HObject imageResult1, out HObject imageResult2, out HObject imageResult3, colorTransLUTHandle);
			return (imageResult1,imageResult2,imageResult3);
		}
		public static HTuple CreateColorTransLut (HTuple colorSpace, HTuple transDirection, HTuple numBits)
		{
			HOperatorSet.CreateColorTransLut(colorSpace, transDirection, numBits, out HTuple colorTransLUTHandle);
			return colorTransLUTHandle;
		}
		public static HObject CfaToRgb (HObject CFAImage, HTuple CFAType, HTuple interpolation)
		{
			HOperatorSet.CfaToRgb(CFAImage, out HObject RGBImage, CFAType, interpolation);
			return RGBImage;
		}
		public static HObject Rgb1ToGray (HObject RGBImage)
		{
			HOperatorSet.Rgb1ToGray(RGBImage, out HObject grayImage);
			return grayImage;
		}
		public static HObject Rgb3ToGray (HObject imageRed, HObject imageGreen, HObject imageBlue)
		{
			HOperatorSet.Rgb3ToGray(imageRed, imageGreen, imageBlue, out HObject imageGray);
			return imageGray;
		}
		public static (HObject imageResult1, HObject imageResult2, HObject imageResult3) TransFromRgb (HObject imageRed, HObject imageGreen, HObject imageBlue, HTuple colorSpace)
		{
			HOperatorSet.TransFromRgb(imageRed, imageGreen, imageBlue, out HObject imageResult1, out HObject imageResult2, out HObject imageResult3, colorSpace);
			return (imageResult1,imageResult2,imageResult3);
		}
		public static (HObject imageRed, HObject imageGreen, HObject imageBlue) TransToRgb (HObject imageInput1, HObject imageInput2, HObject imageInput3, HTuple colorSpace)
		{
			HOperatorSet.TransToRgb(imageInput1, imageInput2, imageInput3, out HObject imageRed, out HObject imageGreen, out HObject imageBlue, colorSpace);
			return (imageRed,imageGreen,imageBlue);
		}
		public static HObject BitMask (HObject image, HTuple bitMask)
		{
			HOperatorSet.BitMask(image, out HObject imageMask, bitMask);
			return imageMask;
		}
		public static HObject BitSlice (HObject image, HTuple bit)
		{
			HOperatorSet.BitSlice(image, out HObject imageSlice, bit);
			return imageSlice;
		}
		public static HObject BitRshift (HObject image, HTuple shift)
		{
			HOperatorSet.BitRshift(image, out HObject imageRShift, shift);
			return imageRShift;
		}
		public static HObject BitLshift (HObject image, HTuple shift)
		{
			HOperatorSet.BitLshift(image, out HObject imageLShift, shift);
			return imageLShift;
		}
		public static HObject BitNot (HObject image)
		{
			HOperatorSet.BitNot(image, out HObject imageNot);
			return imageNot;
		}
		public static HObject BitXor (HObject image1, HObject image2)
		{
			HOperatorSet.BitXor(image1, image2, out HObject imageXor);
			return imageXor;
		}
		public static HObject BitOr (HObject image1, HObject image2)
		{
			HOperatorSet.BitOr(image1, image2, out HObject imageOr);
			return imageOr;
		}
		public static HObject BitAnd (HObject image1, HObject image2)
		{
			HOperatorSet.BitAnd(image1, image2, out HObject imageAnd);
			return imageAnd;
		}
		public static HObject GammaImage (HObject image, HTuple gamma, HTuple offset, HTuple threshold, HTuple maxGray, HTuple encode)
		{
			HOperatorSet.GammaImage(image, out HObject gammaImage, gamma, offset, threshold, maxGray, encode);
			return gammaImage;
		}
		public static HObject PowImage (HObject image, HTuple exponent)
		{
			HOperatorSet.PowImage(image, out HObject powImage, exponent);
			return powImage;
		}
		public static HObject ExpImage (HObject image, HTuple baseVal)
		{
			HOperatorSet.ExpImage(image, out HObject expImage, baseVal);
			return expImage;
		}
		public static HObject LogImage (HObject image, HTuple baseVal)
		{
			HOperatorSet.LogImage(image, out HObject logImage, baseVal);
			return logImage;
		}
		public static HObject Atan2Image (HObject imageY, HObject imageX)
		{
			HOperatorSet.Atan2Image(imageY, imageX, out HObject arctanImage);
			return arctanImage;
		}
		public static HObject AtanImage (HObject image)
		{
			HOperatorSet.AtanImage(image, out HObject arctanImage);
			return arctanImage;
		}
		public static HObject AcosImage (HObject image)
		{
			HOperatorSet.AcosImage(image, out HObject arccosImage);
			return arccosImage;
		}
		public static HObject AsinImage (HObject image)
		{
			HOperatorSet.AsinImage(image, out HObject arcsinImage);
			return arcsinImage;
		}
		public static HObject TanImage (HObject image)
		{
			HOperatorSet.TanImage(image, out HObject tanImage);
			return tanImage;
		}
		public static HObject CosImage (HObject image)
		{
			HOperatorSet.CosImage(image, out HObject cosImage);
			return cosImage;
		}
		public static HObject SinImage (HObject image)
		{
			HOperatorSet.SinImage(image, out HObject sinImage);
			return sinImage;
		}
		public static HObject AbsDiffImage (HObject image1, HObject image2, HTuple mult)
		{
			HOperatorSet.AbsDiffImage(image1, image2, out HObject imageAbsDiff, mult);
			return imageAbsDiff;
		}
		public static HObject SqrtImage (HObject image)
		{
			HOperatorSet.SqrtImage(image, out HObject sqrtImage);
			return sqrtImage;
		}
		public static HObject SubImage (HObject imageMinuend, HObject imageSubtrahend, HTuple mult, HTuple add)
		{
			HOperatorSet.SubImage(imageMinuend, imageSubtrahend, out HObject imageSub, mult, add);
			return imageSub;
		}
		public static HObject ScaleImage (HObject image, HTuple mult, HTuple add)
		{
			HOperatorSet.ScaleImage(image, out HObject imageScaled, mult, add);
			return imageScaled;
		}
		public static HObject DivImage (HObject image1, HObject image2, HTuple mult, HTuple add)
		{
			HOperatorSet.DivImage(image1, image2, out HObject imageResult, mult, add);
			return imageResult;
		}
		public static HObject MultImage (HObject image1, HObject image2, HTuple mult, HTuple add)
		{
			HOperatorSet.MultImage(image1, image2, out HObject imageResult, mult, add);
			return imageResult;
		}
		public static HObject AddImage (HObject image1, HObject image2, HTuple mult, HTuple add)
		{
			HOperatorSet.AddImage(image1, image2, out HObject imageResult, mult, add);
			return imageResult;
		}
		public static HObject AbsImage (HObject image)
		{
			HOperatorSet.AbsImage(image, out HObject imageAbs);
			return imageAbs;
		}
		public static HObject MinImage (HObject image1, HObject image2)
		{
			HOperatorSet.MinImage(image1, image2, out HObject imageMin);
			return imageMin;
		}
		public static HObject MaxImage (HObject image1, HObject image2)
		{
			HOperatorSet.MaxImage(image1, image2, out HObject imageMax);
			return imageMax;
		}
		public static HObject InvertImage (HObject image)
		{
			HOperatorSet.InvertImage(image, out HObject imageInvert);
			return imageInvert;
		}
		public static HObject AdjustMosaicImages (HObject images, HTuple from, HTuple to, HTuple referenceImage, HTuple homMatrices2D, HTuple estimationMethod, HTuple estimateParameters, HTuple OECFModel)
		{
			HOperatorSet.AdjustMosaicImages(images, out HObject correctedImages, from, to, referenceImage, homMatrices2D, estimationMethod, estimateParameters, OECFModel);
			return correctedImages;
		}
		public static (HObject front, HObject rear, HObject left, HObject right, HObject top, HObject bottom) GenCubeMapMosaic (HObject images, HTuple cameraMatrices, HTuple rotationMatrices, HTuple cubeMapDimension, HTuple stackingOrder, HTuple interpolation)
		{
			HOperatorSet.GenCubeMapMosaic(images, out HObject front, out HObject rear, out HObject left, out HObject right, out HObject top, out HObject bottom, cameraMatrices, rotationMatrices, cubeMapDimension, stackingOrder, interpolation);
			return (front,rear,left,right,top,bottom);
		}
		public static HObject GenSphericalMosaic (HObject images, HTuple cameraMatrices, HTuple rotationMatrices, HTuple latMin, HTuple latMax, HTuple longMin, HTuple longMax, HTuple latLongStep, HTuple stackingOrder, HTuple interpolation)
		{
			HOperatorSet.GenSphericalMosaic(images, out HObject mosaicImage, cameraMatrices, rotationMatrices, latMin, latMax, longMin, longMax, latLongStep, stackingOrder, interpolation);
			return mosaicImage;
		}
		public static (HObject mosaicImage, HTuple transMat2D) GenBundleAdjustedMosaic (HObject images, HTuple homMatrices2D, HTuple stackingOrder, HTuple transformDomain)
		{
			HOperatorSet.GenBundleAdjustedMosaic(images, out HObject mosaicImage, homMatrices2D, stackingOrder, transformDomain, out HTuple transMat2D);
			return (mosaicImage,transMat2D);
		}
		public static (HObject mosaicImage, HTuple mosaicMatrices2D) GenProjectiveMosaic (HObject images, HTuple startImage, HTuple mappingSource, HTuple mappingDest, HTuple homMatrices2D, HTuple stackingOrder, HTuple transformDomain)
		{
			HOperatorSet.GenProjectiveMosaic(images, out HObject mosaicImage, startImage, mappingSource, mappingDest, homMatrices2D, stackingOrder, transformDomain, out HTuple mosaicMatrices2D);
			return (mosaicImage,mosaicMatrices2D);
		}
		public static HObject ProjectiveTransImageSize (HObject image, HTuple homMat2D, HTuple interpolation, HTuple width, HTuple height, HTuple transformDomain)
		{
			HOperatorSet.ProjectiveTransImageSize(image, out HObject transImage, homMat2D, interpolation, width, height, transformDomain);
			return transImage;
		}
		public static HObject ProjectiveTransImage (HObject image, HTuple homMat2D, HTuple interpolation, HTuple adaptImageSize, HTuple transformDomain)
		{
			HOperatorSet.ProjectiveTransImage(image, out HObject transImage, homMat2D, interpolation, adaptImageSize, transformDomain);
			return transImage;
		}
		public static HObject AffineTransImageSize (HObject image, HTuple homMat2D, HTuple interpolation, HTuple width, HTuple height)
		{
			HOperatorSet.AffineTransImageSize(image, out HObject imageAffineTrans, homMat2D, interpolation, width, height);
			return imageAffineTrans;
		}
		public static HObject AffineTransImage (HObject image, HTuple homMat2D, HTuple interpolation, HTuple adaptImageSize)
		{
			HOperatorSet.AffineTransImage(image, out HObject imageAffineTrans, homMat2D, interpolation, adaptImageSize);
			return imageAffineTrans;
		}
		public static HObject ZoomImageFactor (HObject image, HTuple scaleWidth, HTuple scaleHeight, HTuple interpolation)
		{
			HOperatorSet.ZoomImageFactor(image, out HObject imageZoomed, scaleWidth, scaleHeight, interpolation);
			return imageZoomed;
		}
		public static HObject ZoomImageSize (HObject image, HTuple width, HTuple height, HTuple interpolation)
		{
			HOperatorSet.ZoomImageSize(image, out HObject imageZoom, width, height, interpolation);
			return imageZoom;
		}
		public static HObject MirrorImage (HObject image, HTuple mode)
		{
			HOperatorSet.MirrorImage(image, out HObject imageMirror, mode);
			return imageMirror;
		}
		public static HObject RotateImage (HObject image, HTuple phi, HTuple interpolation)
		{
			HOperatorSet.RotateImage(image, out HObject imageRotate, phi, interpolation);
			return imageRotate;
		}
		public static HObject PolarTransImageInv (HObject polarImage, HTuple row, HTuple column, HTuple angleStart, HTuple angleEnd, HTuple radiusStart, HTuple radiusEnd, HTuple width, HTuple height, HTuple interpolation)
		{
			HOperatorSet.PolarTransImageInv(polarImage, out HObject XYTransImage, row, column, angleStart, angleEnd, radiusStart, radiusEnd, width, height, interpolation);
			return XYTransImage;
		}
		public static HObject PolarTransImageExt (HObject image, HTuple row, HTuple column, HTuple angleStart, HTuple angleEnd, HTuple radiusStart, HTuple radiusEnd, HTuple width, HTuple height, HTuple interpolation)
		{
			HOperatorSet.PolarTransImageExt(image, out HObject polarTransImage, row, column, angleStart, angleEnd, radiusStart, radiusEnd, width, height, interpolation);
			return polarTransImage;
		}
		public static HObject PolarTransImage (HObject imageXY, HTuple row, HTuple column, HTuple width, HTuple height)
		{
			HOperatorSet.PolarTransImage(imageXY, out HObject imagePolar, row, column, width, height);
			return imagePolar;
		}
		public static HTuple VectorFieldToHomMat2d (HObject vectorField)
		{
			HOperatorSet.VectorFieldToHomMat2d(vectorField, out HTuple homMat2D);
			return homMat2D;
		}
		public static HObject DeserializeXld (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeXld(out HObject XLD, serializedItemHandle);
			return XLD;
		}
		public static HTuple SerializeXld (HObject XLD)
		{
			HOperatorSet.SerializeXld(XLD, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static (HObject polygons, HTuple dxfStatus) ReadPolygonXldDxf (HTuple fileName, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.ReadPolygonXldDxf(out HObject polygons, fileName, genParamName, genParamValue, out HTuple dxfStatus);
			return (polygons,dxfStatus);
		}
		public static void WritePolygonXldDxf (HObject polygons, HTuple fileName)
		{
			HOperatorSet.WritePolygonXldDxf(polygons, fileName);
		}
		public static (HObject contours, HTuple dxfStatus) ReadContourXldDxf (HTuple fileName, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.ReadContourXldDxf(out HObject contours, fileName, genParamName, genParamValue, out HTuple dxfStatus);
			return (contours,dxfStatus);
		}
		public static void WriteContourXldDxf (HObject contours, HTuple fileName)
		{
			HOperatorSet.WriteContourXldDxf(contours, fileName);
		}
		public static void CopyFile (HTuple sourceFile, HTuple destinationFile)
		{
			HOperatorSet.CopyFile(sourceFile, destinationFile);
		}
		public static void SetCurrentDir (HTuple dirName)
		{
			HOperatorSet.SetCurrentDir(dirName);
		}
		public static HTuple GetCurrentDir ()
		{
			HOperatorSet.GetCurrentDir(out HTuple dirName);
			return dirName;
		}
		public static void RemoveDir (HTuple dirName)
		{
			HOperatorSet.RemoveDir(dirName);
		}
		public static void MakeDir (HTuple dirName)
		{
			HOperatorSet.MakeDir(dirName);
		}
		public static HTuple ListFiles (HTuple directory, HTuple options)
		{
			HOperatorSet.ListFiles(directory, options, out HTuple files);
			return files;
		}
		public static void DeleteFile (HTuple fileName)
		{
			HOperatorSet.DeleteFile(fileName);
		}
		public static HTuple FileExists (HTuple fileName)
		{
			HOperatorSet.FileExists(fileName, out HTuple fileExists);
			return fileExists;
		}
		public static HObject ReadObject (HTuple fileName)
		{
			HOperatorSet.ReadObject(out HObject objectVal, fileName);
			return objectVal;
		}
		public static void WriteObject (HObject objectVal, HTuple fileName)
		{
			HOperatorSet.WriteObject(objectVal, fileName);
		}
		public static HObject DeserializeObject (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeObject(out HObject objectVal, serializedItemHandle);
			return objectVal;
		}
		public static HTuple SerializeObject (HObject objectVal)
		{
			HOperatorSet.SerializeObject(objectVal, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HObject DeserializeImage (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeImage(out HObject image, serializedItemHandle);
			return image;
		}
		public static HTuple SerializeImage (HObject image)
		{
			HOperatorSet.SerializeImage(image, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HObject DeserializeRegion (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeRegion(out HObject region, serializedItemHandle);
			return region;
		}
		public static HTuple SerializeRegion (HObject region)
		{
			HOperatorSet.SerializeRegion(region, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static void WriteRegion (HObject region, HTuple fileName)
		{
			HOperatorSet.WriteRegion(region, fileName);
		}
		public static void WriteImage (HObject image, HTuple format, HTuple fillColor, HTuple fileName)
		{
			HOperatorSet.WriteImage(image, format, fillColor, fileName);
		}
		public static HObject ReadSequence (HTuple headerSize, HTuple sourceWidth, HTuple sourceHeight, HTuple startRow, HTuple startColumn, HTuple destWidth, HTuple destHeight, HTuple pixelType, HTuple bitOrder, HTuple byteOrder, HTuple pad, HTuple index, HTuple fileName)
		{
			HOperatorSet.ReadSequence(out HObject image, headerSize, sourceWidth, sourceHeight, startRow, startColumn, destWidth, destHeight, pixelType, bitOrder, byteOrder, pad, index, fileName);
			return image;
		}
		public static HObject ReadRegion (HTuple fileName)
		{
			HOperatorSet.ReadRegion(out HObject region, fileName);
			return region;
		}
		public static HObject ReadImage (HTuple fileName)
		{
			HOperatorSet.ReadImage(out HObject image, fileName);
			return image;
		}
		public static HTuple OpenFile (HTuple fileName, HTuple fileType)
		{
			HOperatorSet.OpenFile(fileName, fileType, out HTuple fileHandle);
			return fileHandle;
		}
		public static void FwriteString (HTuple fileHandle, HTuple stringVal)
		{
			HOperatorSet.FwriteString(fileHandle, stringVal);
		}
		public static (HTuple outLine, HTuple isEOF) FreadLine (HTuple fileHandle)
		{
			HOperatorSet.FreadLine(fileHandle, out HTuple outLine, out HTuple isEOF);
			return (outLine,isEOF);
		}
		public static (HTuple outString, HTuple isEOF) FreadString (HTuple fileHandle)
		{
			HOperatorSet.FreadString(fileHandle, out HTuple outString, out HTuple isEOF);
			return (outString,isEOF);
		}
		public static HTuple FreadChar (HTuple fileHandle)
		{
			HOperatorSet.FreadChar(fileHandle, out HTuple charVal);
			return charVal;
		}
		public static HObject SigmaImage (HObject image, HTuple maskHeight, HTuple maskWidth, HTuple sigma)
		{
			HOperatorSet.SigmaImage(image, out HObject imageSigma, maskHeight, maskWidth, sigma);
			return imageSigma;
		}
		public static HObject MidrangeImage (HObject image, HObject mask, HTuple margin)
		{
			HOperatorSet.MidrangeImage(image, mask, out HObject imageMidrange, margin);
			return imageMidrange;
		}
		public static HObject TrimmedMean (HObject image, HObject mask, HTuple number, HTuple margin)
		{
			HOperatorSet.TrimmedMean(image, mask, out HObject imageTMean, number, margin);
			return imageTMean;
		}
		public static HObject MedianSeparate (HObject image, HTuple maskWidth, HTuple maskHeight, HTuple margin)
		{
			HOperatorSet.MedianSeparate(image, out HObject imageSMedian, maskWidth, maskHeight, margin);
			return imageSMedian;
		}
		public static HObject MedianRect (HObject image, HTuple maskWidth, HTuple maskHeight)
		{
			HOperatorSet.MedianRect(image, out HObject imageMedian, maskWidth, maskHeight);
			return imageMedian;
		}
		public static HObject MedianImage (HObject image, HTuple maskType, HTuple radius, HTuple margin)
		{
			HOperatorSet.MedianImage(image, out HObject imageMedian, maskType, radius, margin);
			return imageMedian;
		}
		public static HObject MedianWeighted (HObject image, HTuple maskType, HTuple maskSize)
		{
			HOperatorSet.MedianWeighted(image, out HObject imageWMedian, maskType, maskSize);
			return imageWMedian;
		}
		public static HObject RankRect (HObject image, HTuple maskWidth, HTuple maskHeight, HTuple rank)
		{
			HOperatorSet.RankRect(image, out HObject imageRank, maskWidth, maskHeight, rank);
			return imageRank;
		}
		public static HObject RankImage (HObject image, HObject mask, HTuple rank, HTuple margin)
		{
			HOperatorSet.RankImage(image, mask, out HObject imageRank, rank, margin);
			return imageRank;
		}
		public static HObject DualRank (HObject image, HTuple maskType, HTuple radius, HTuple modePercent, HTuple margin)
		{
			HOperatorSet.DualRank(image, out HObject imageRank, maskType, radius, modePercent, margin);
			return imageRank;
		}
		public static HObject MeanImage (HObject image, HTuple maskWidth, HTuple maskHeight)
		{
			HOperatorSet.MeanImage(image, out HObject imageMean, maskWidth, maskHeight);
			return imageMean;
		}
		public static (HTuple size, HTuple coeffs) InfoSmooth (HTuple filter, HTuple alpha)
		{
			HOperatorSet.InfoSmooth(filter, alpha, out HTuple size, out HTuple coeffs);
			return (size,coeffs);
		}
		public static HObject BinomialFilter (HObject image, HTuple maskWidth, HTuple maskHeight)
		{
			HOperatorSet.BinomialFilter(image, out HObject imageBinomial, maskWidth, maskHeight);
			return imageBinomial;
		}
		public static HObject GaussImage (HObject image, HTuple size)
		{
			HOperatorSet.GaussImage(image, out HObject imageGauss, size);
			return imageGauss;
		}
		public static HObject GaussFilter (HObject image, HTuple size)
		{
			HOperatorSet.GaussFilter(image, out HObject imageGauss, size);
			return imageGauss;
		}
		public static HObject EliminateMinMax (HObject image, HTuple maskWidth, HTuple maskHeight, HTuple gap, HTuple mode)
		{
			HOperatorSet.EliminateMinMax(image, out HObject filteredImage, maskWidth, maskHeight, gap, mode);
			return filteredImage;
		}
		public static HObject FillInterlace (HObject imageCamera, HTuple mode)
		{
			HOperatorSet.FillInterlace(imageCamera, out HObject imageFilled, mode);
			return imageFilled;
		}
		public static HObject RankN (HObject image, HTuple rankIndex)
		{
			HOperatorSet.RankN(image, out HObject rankImage, rankIndex);
			return rankImage;
		}
		public static HObject MeanN (HObject image)
		{
			HOperatorSet.MeanN(image, out HObject imageMean);
			return imageMean;
		}
		public static HObject EliminateSp (HObject image, HTuple maskWidth, HTuple maskHeight, HTuple minThresh, HTuple maxThresh)
		{
			HOperatorSet.EliminateSp(image, out HObject imageFillSP, maskWidth, maskHeight, minThresh, maxThresh);
			return imageFillSP;
		}
		public static HObject MeanSp (HObject image, HTuple maskWidth, HTuple maskHeight, HTuple minThresh, HTuple maxThresh)
		{
			HOperatorSet.MeanSp(image, out HObject imageSPMean, maskWidth, maskHeight, minThresh, maxThresh);
			return imageSPMean;
		}
		public static (HTuple row, HTuple column) PointsSojka (HObject image, HTuple maskSize, HTuple sigmaW, HTuple sigmaD, HTuple minGrad, HTuple minApparentness, HTuple minAngle, HTuple subpix)
		{
			HOperatorSet.PointsSojka(image, maskSize, sigmaW, sigmaD, minGrad, minApparentness, minAngle, subpix, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static HObject DotsImage (HObject image, HTuple diameter, HTuple filterType, HTuple pixelShift)
		{
			HOperatorSet.DotsImage(image, out HObject dotImage, diameter, filterType, pixelShift);
			return dotImage;
		}
		public static (HTuple row, HTuple column) LocalMinSubPix (HObject image, HTuple filter, HTuple sigma, HTuple threshold)
		{
			HOperatorSet.LocalMinSubPix(image, filter, sigma, threshold, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static (HTuple row, HTuple column) LocalMaxSubPix (HObject image, HTuple filter, HTuple sigma, HTuple threshold)
		{
			HOperatorSet.LocalMaxSubPix(image, filter, sigma, threshold, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static (HTuple row, HTuple column) SaddlePointsSubPix (HObject image, HTuple filter, HTuple sigma, HTuple threshold)
		{
			HOperatorSet.SaddlePointsSubPix(image, filter, sigma, threshold, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static (HTuple rowMin, HTuple columnMin, HTuple rowMax, HTuple columnMax, HTuple rowSaddle, HTuple columnSaddle) CriticalPointsSubPix (HObject image, HTuple filter, HTuple sigma, HTuple threshold)
		{
			HOperatorSet.CriticalPointsSubPix(image, filter, sigma, threshold, out HTuple rowMin, out HTuple columnMin, out HTuple rowMax, out HTuple columnMax, out HTuple rowSaddle, out HTuple columnSaddle);
			return (rowMin,columnMin,rowMax,columnMax,rowSaddle,columnSaddle);
		}
		public static (HTuple row, HTuple column) PointsHarris (HObject image, HTuple sigmaGrad, HTuple sigmaSmooth, HTuple alpha, HTuple threshold)
		{
			HOperatorSet.PointsHarris(image, sigmaGrad, sigmaSmooth, alpha, threshold, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static (HTuple row, HTuple column) PointsHarrisBinomial (HObject image, HTuple maskSizeGrad, HTuple maskSizeSmooth, HTuple alpha, HTuple threshold, HTuple subpix)
		{
			HOperatorSet.PointsHarrisBinomial(image, maskSizeGrad, maskSizeSmooth, alpha, threshold, subpix, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static (HTuple row, HTuple column) PointsLepetit (HObject image, HTuple radius, HTuple checkNeighbor, HTuple minCheckNeighborDiff, HTuple minScore, HTuple subpix)
		{
			HOperatorSet.PointsLepetit(image, radius, checkNeighbor, minCheckNeighborDiff, minScore, subpix, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static (HTuple rowJunctions, HTuple columnJunctions, HTuple coRRJunctions, HTuple coRCJunctions, HTuple coCCJunctions, HTuple rowArea, HTuple columnArea, HTuple coRRArea, HTuple coRCArea, HTuple coCCArea) PointsFoerstner (HObject image, HTuple sigmaGrad, HTuple sigmaInt, HTuple sigmaPoints, HTuple threshInhom, HTuple threshShape, HTuple smoothing, HTuple eliminateDoublets)
		{
			HOperatorSet.PointsFoerstner(image, sigmaGrad, sigmaInt, sigmaPoints, threshInhom, threshShape, smoothing, eliminateDoublets, out HTuple rowJunctions, out HTuple columnJunctions, out HTuple coRRJunctions, out HTuple coRCJunctions, out HTuple coCCJunctions, out HTuple rowArea, out HTuple columnArea, out HTuple coRRArea, out HTuple coRCArea, out HTuple coCCArea);
			return (rowJunctions,columnJunctions,coRRJunctions,coRCJunctions,coCCJunctions,rowArea,columnArea,coRRArea,coRCArea,coCCArea);
		}
		public static HTuple EstimateNoise (HObject image, HTuple method, HTuple percent)
		{
			HOperatorSet.EstimateNoise(image, method, percent, out HTuple sigma);
			return sigma;
		}
		public static HTuple NoiseDistributionMean (HObject constRegion, HObject image, HTuple filterSize)
		{
			HOperatorSet.NoiseDistributionMean(constRegion, image, filterSize, out HTuple distribution);
			return distribution;
		}
		public static HObject AddNoiseWhite (HObject image, HTuple amp)
		{
			HOperatorSet.AddNoiseWhite(image, out HObject imageNoise, amp);
			return imageNoise;
		}
		public static HObject AddNoiseDistribution (HObject image, HTuple distribution)
		{
			HOperatorSet.AddNoiseDistribution(image, out HObject imageNoise, distribution);
			return imageNoise;
		}
		public static HTuple GaussDistribution (HTuple sigma)
		{
			HOperatorSet.GaussDistribution(sigma, out HTuple distribution);
			return distribution;
		}
		public static HTuple SpDistribution (HTuple percentSalt, HTuple percentPepper)
		{
			HOperatorSet.SpDistribution(percentSalt, percentPepper, out HTuple distribution);
			return distribution;
		}
		public static HObject DeviationN (HObject image)
		{
			HOperatorSet.DeviationN(image, out HObject imageDeviation);
			return imageDeviation;
		}
		public static HObject InpaintingTexture (HObject image, HObject region, HTuple maskSize, HTuple searchSize, HTuple anisotropy, HTuple postIteration, HTuple smoothness)
		{
			HOperatorSet.InpaintingTexture(image, region, out HObject inpaintedImage, maskSize, searchSize, anisotropy, postIteration, smoothness);
			return inpaintedImage;
		}
		public static HObject InpaintingCt (HObject image, HObject region, HTuple epsilon, HTuple kappa, HTuple sigma, HTuple rho, HTuple channelCoefficients)
		{
			HOperatorSet.InpaintingCt(image, region, out HObject inpaintedImage, epsilon, kappa, sigma, rho, channelCoefficients);
			return inpaintedImage;
		}
		public static HObject InpaintingMcf (HObject image, HObject region, HTuple sigma, HTuple theta, HTuple iterations)
		{
			HOperatorSet.InpaintingMcf(image, region, out HObject inpaintedImage, sigma, theta, iterations);
			return inpaintedImage;
		}
		public static HObject InpaintingCed (HObject image, HObject region, HTuple sigma, HTuple rho, HTuple theta, HTuple iterations)
		{
			HOperatorSet.InpaintingCed(image, region, out HObject inpaintedImage, sigma, rho, theta, iterations);
			return inpaintedImage;
		}
		public static HObject InpaintingAniso (HObject image, HObject region, HTuple mode, HTuple contrast, HTuple theta, HTuple iterations, HTuple rho)
		{
			HOperatorSet.InpaintingAniso(image, region, out HObject inpaintedImage, mode, contrast, theta, iterations, rho);
			return inpaintedImage;
		}
		public static HObject HarmonicInterpolation (HObject image, HObject region, HTuple precision)
		{
			HOperatorSet.HarmonicInterpolation(image, region, out HObject inpaintedImage, precision);
			return inpaintedImage;
		}
		public static HObject ExpandDomainGray (HObject inputImage, HTuple expansionRange)
		{
			HOperatorSet.ExpandDomainGray(inputImage, out HObject expandedImage, expansionRange);
			return expandedImage;
		}
		public static HObject TopographicSketch (HObject image)
		{
			HOperatorSet.TopographicSketch(image, out HObject sketch);
			return sketch;
		}
		public static HObject LinearTransColor (HObject image, HTuple transMat)
		{
			HOperatorSet.LinearTransColor(image, out HObject imageTrans, transMat);
			return imageTrans;
		}
		public static (HTuple trans, HTuple transInv, HTuple mean, HTuple cov, HTuple infoPerComp) GenPrincipalCompTrans (HObject multichannelImage)
		{
			HOperatorSet.GenPrincipalCompTrans(multichannelImage, out HTuple trans, out HTuple transInv, out HTuple mean, out HTuple cov, out HTuple infoPerComp);
			return (trans,transInv,mean,cov,infoPerComp);
		}
		public static (HObject PCAImage, HTuple infoPerComp) PrincipalComp (HObject multichannelImage)
		{
			HOperatorSet.PrincipalComp(multichannelImage, out HObject PCAImage, out HTuple infoPerComp);
			return (PCAImage,infoPerComp);
		}
		public static HTuple FuzzyEntropy (HObject regions, HObject image, HTuple apar, HTuple cpar)
		{
			HOperatorSet.FuzzyEntropy(regions, image, apar, cpar, out HTuple entropy);
			return entropy;
		}
		public static HTuple FuzzyPerimeter (HObject regions, HObject image, HTuple apar, HTuple cpar)
		{
			HOperatorSet.FuzzyPerimeter(regions, image, apar, cpar, out HTuple perimeter);
			return perimeter;
		}
		public static HObject GrayClosingShape (HObject image, HTuple maskHeight, HTuple maskWidth, HTuple maskShape)
		{
			HOperatorSet.GrayClosingShape(image, out HObject imageClosing, maskHeight, maskWidth, maskShape);
			return imageClosing;
		}
		public static HObject GrayOpeningShape (HObject image, HTuple maskHeight, HTuple maskWidth, HTuple maskShape)
		{
			HOperatorSet.GrayOpeningShape(image, out HObject imageOpening, maskHeight, maskWidth, maskShape);
			return imageOpening;
		}
		public static HObject GrayErosionShape (HObject image, HTuple maskHeight, HTuple maskWidth, HTuple maskShape)
		{
			HOperatorSet.GrayErosionShape(image, out HObject imageMin, maskHeight, maskWidth, maskShape);
			return imageMin;
		}
		public static HObject GrayDilationShape (HObject image, HTuple maskHeight, HTuple maskWidth, HTuple maskShape)
		{
			HOperatorSet.GrayDilationShape(image, out HObject imageMax, maskHeight, maskWidth, maskShape);
			return imageMax;
		}
		public static HObject GrayRangeRect (HObject image, HTuple maskHeight, HTuple maskWidth)
		{
			HOperatorSet.GrayRangeRect(image, out HObject imageResult, maskHeight, maskWidth);
			return imageResult;
		}
		public static HObject GrayClosingRect (HObject image, HTuple maskHeight, HTuple maskWidth)
		{
			HOperatorSet.GrayClosingRect(image, out HObject imageClosing, maskHeight, maskWidth);
			return imageClosing;
		}
		public static HObject GrayOpeningRect (HObject image, HTuple maskHeight, HTuple maskWidth)
		{
			HOperatorSet.GrayOpeningRect(image, out HObject imageOpening, maskHeight, maskWidth);
			return imageOpening;
		}
		public static HObject GrayErosionRect (HObject image, HTuple maskHeight, HTuple maskWidth)
		{
			HOperatorSet.GrayErosionRect(image, out HObject imageMin, maskHeight, maskWidth);
			return imageMin;
		}
		public static HObject GrayDilationRect (HObject image, HTuple maskHeight, HTuple maskWidth)
		{
			HOperatorSet.GrayDilationRect(image, out HObject imageMax, maskHeight, maskWidth);
			return imageMax;
		}
		public static HObject GraySkeleton (HObject image)
		{
			HOperatorSet.GraySkeleton(image, out HObject graySkeleton);
			return graySkeleton;
		}
		public static HObject LutTrans (HObject image, HTuple lut)
		{
			HOperatorSet.LutTrans(image, out HObject imageResult, lut);
			return imageResult;
		}
		public static HObject ConvolImage (HObject image, HTuple filterMask, HTuple margin)
		{
			HOperatorSet.ConvolImage(image, out HObject imageResult, filterMask, margin);
			return imageResult;
		}
		public static HObject ConvertImageType (HObject image, HTuple newType)
		{
			HOperatorSet.ConvertImageType(image, out HObject imageConverted, newType);
			return imageConverted;
		}
		public static HObject RealToVectorField (HObject row, HObject col, HTuple type)
		{
			HOperatorSet.RealToVectorField(row, col, out HObject vectorField, type);
			return vectorField;
		}
		public static (HObject row, HObject col) VectorFieldToReal (HObject vectorField)
		{
			HOperatorSet.VectorFieldToReal(vectorField, out HObject row, out HObject col);
			return (row,col);
		}
		public static HObject RealToComplex (HObject imageReal, HObject imageImaginary)
		{
			HOperatorSet.RealToComplex(imageReal, imageImaginary, out HObject imageComplex);
			return imageComplex;
		}
		public static (HObject imageReal, HObject imageImaginary) ComplexToReal (HObject imageComplex)
		{
			HOperatorSet.ComplexToReal(imageComplex, out HObject imageReal, out HObject imageImaginary);
			return (imageReal,imageImaginary);
		}
		public static HObject RegionToMean (HObject regions, HObject image)
		{
			HOperatorSet.RegionToMean(regions, image, out HObject imageMean);
			return imageMean;
		}
		public static HObject GrayInside (HObject image)
		{
			HOperatorSet.GrayInside(image, out HObject imageDist);
			return imageDist;
		}
		public static HObject Symmetry (HObject image, HTuple maskSize, HTuple direction, HTuple exponent)
		{
			HOperatorSet.Symmetry(image, out HObject imageSymmetry, maskSize, direction, exponent);
			return imageSymmetry;
		}
		public static HObject SelectGrayvaluesFromChannels (HObject multichannelImage, HObject indexImage)
		{
			HOperatorSet.SelectGrayvaluesFromChannels(multichannelImage, indexImage, out HObject selected);
			return selected;
		}
		public static (HObject depth, HObject confidence) DepthFromFocus (HObject multiFocusImage, HTuple filter, HTuple selection)
		{
			HOperatorSet.DepthFromFocus(multiFocusImage, out HObject depth, out HObject confidence, filter, selection);
			return (depth,confidence);
		}
		public static HTuple SceneFlowCalib (HObject imageRect1T1, HObject imageRect2T1, HObject imageRect1T2, HObject imageRect2T2, HObject disparity, HTuple smoothingFlow, HTuple smoothingDisparity, HTuple genParamName, HTuple genParamValue, HTuple camParamRect1, HTuple camParamRect2, HTuple relPoseRect)
		{
			HOperatorSet.SceneFlowCalib(imageRect1T1, imageRect2T1, imageRect1T2, imageRect2T2, disparity, smoothingFlow, smoothingDisparity, genParamName, genParamValue, camParamRect1, camParamRect2, relPoseRect, out HTuple objectModel3D);
			return objectModel3D;
		}
		public static (HObject opticalFlow, HObject disparityChange) SceneFlowUncalib (HObject imageRect1T1, HObject imageRect2T1, HObject imageRect1T2, HObject imageRect2T2, HObject disparity, HTuple smoothingFlow, HTuple smoothingDisparity, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SceneFlowUncalib(imageRect1T1, imageRect2T1, imageRect1T2, imageRect2T2, disparity, out HObject opticalFlow, out HObject disparityChange, smoothingFlow, smoothingDisparity, genParamName, genParamValue);
			return (opticalFlow,disparityChange);
		}
		public static HObject UnwarpImageVectorField (HObject image, HObject vectorField)
		{
			HOperatorSet.UnwarpImageVectorField(image, vectorField, out HObject imageUnwarped);
			return imageUnwarped;
		}
		public static HObject DerivateVectorField (HObject vectorField, HTuple sigma, HTuple component)
		{
			HOperatorSet.DerivateVectorField(vectorField, out HObject result, sigma, component);
			return result;
		}
		public static HObject VectorFieldLength (HObject vectorField, HTuple mode)
		{
			HOperatorSet.VectorFieldLength(vectorField, out HObject length, mode);
			return length;
		}
		public static HObject OpticalFlowMg (HObject imageT1, HObject imageT2, HTuple algorithm, HTuple smoothingSigma, HTuple integrationSigma, HTuple flowSmoothness, HTuple gradientConstancy, HTuple MGParamName, HTuple MGParamValue)
		{
			HOperatorSet.OpticalFlowMg(imageT1, imageT2, out HObject vectorField, algorithm, smoothingSigma, integrationSigma, flowSmoothness, gradientConstancy, MGParamName, MGParamValue);
			return vectorField;
		}
		public static HObject ExhaustiveMatchMg (HObject image, HObject imageTemplate, HTuple mode, HTuple level, HTuple threshold)
		{
			HOperatorSet.ExhaustiveMatchMg(image, imageTemplate, out HObject imageMatch, mode, level, threshold);
			return imageMatch;
		}
		public static HTuple CreateTemplateRot (HObject template, HTuple numLevel, HTuple angleStart, HTuple angleExtend, HTuple angleStep, HTuple optimize, HTuple grayValues)
		{
			HOperatorSet.CreateTemplateRot(template, numLevel, angleStart, angleExtend, angleStep, optimize, grayValues, out HTuple templateID);
			return templateID;
		}
		public static HTuple CreateTemplate (HObject template, HTuple firstError, HTuple numLevel, HTuple optimize, HTuple grayValues)
		{
			HOperatorSet.CreateTemplate(template, firstError, numLevel, optimize, grayValues, out HTuple templateID);
			return templateID;
		}
		public static HTuple SerializeTemplate (HTuple templateID)
		{
			HOperatorSet.SerializeTemplate(templateID, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple DeserializeTemplate (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeTemplate(serializedItemHandle, out HTuple templateID);
			return templateID;
		}
		public static void WriteTemplate (HTuple templateID, HTuple fileName)
		{
			HOperatorSet.WriteTemplate(templateID, fileName);
		}
		public static HTuple ReadTemplate (HTuple fileName)
		{
			HOperatorSet.ReadTemplate(fileName, out HTuple templateID);
			return templateID;
		}
		public static void ClearAllTemplates ()
		{
			HOperatorSet.ClearAllTemplates();
		}
		public static void ClearTemplate (HTuple templateID)
		{
			HOperatorSet.ClearTemplate(templateID);
		}
		public static void SetOffsetTemplate (HTuple templateID, HTuple grayOffset)
		{
			HOperatorSet.SetOffsetTemplate(templateID, grayOffset);
		}
		public static void SetReferenceTemplate (HTuple templateID, HTuple row, HTuple column)
		{
			HOperatorSet.SetReferenceTemplate(templateID, row, column);
		}
		public static void AdaptTemplate (HObject image, HTuple templateID)
		{
			HOperatorSet.AdaptTemplate(image, templateID);
		}
		public static HObject FastMatchMg (HObject image, HTuple templateID, HTuple maxError, HTuple numLevel)
		{
			HOperatorSet.FastMatchMg(image, out HObject matches, templateID, maxError, numLevel);
			return matches;
		}
		public static (HTuple row, HTuple column, HTuple error) BestMatchPreMg (HObject imagePyramid, HTuple templateID, HTuple maxError, HTuple subPixel, HTuple numLevels, HTuple whichLevels)
		{
			HOperatorSet.BestMatchPreMg(imagePyramid, templateID, maxError, subPixel, numLevels, whichLevels, out HTuple row, out HTuple column, out HTuple error);
			return (row,column,error);
		}
		public static (HTuple row, HTuple column, HTuple error) BestMatchMg (HObject image, HTuple templateID, HTuple maxError, HTuple subPixel, HTuple numLevels, HTuple whichLevels)
		{
			HOperatorSet.BestMatchMg(image, templateID, maxError, subPixel, numLevels, whichLevels, out HTuple row, out HTuple column, out HTuple error);
			return (row,column,error);
		}
		public static HObject FastMatch (HObject image, HTuple templateID, HTuple maxError)
		{
			HOperatorSet.FastMatch(image, out HObject matches, templateID, maxError);
			return matches;
		}
		public static (HTuple row, HTuple column, HTuple angle, HTuple error) BestMatchRotMg (HObject image, HTuple templateID, HTuple angleStart, HTuple angleExtend, HTuple maxError, HTuple subPixel, HTuple numLevels)
		{
			HOperatorSet.BestMatchRotMg(image, templateID, angleStart, angleExtend, maxError, subPixel, numLevels, out HTuple row, out HTuple column, out HTuple angle, out HTuple error);
			return (row,column,angle,error);
		}
		public static (HTuple row, HTuple column, HTuple angle, HTuple error) BestMatchRot (HObject image, HTuple templateID, HTuple angleStart, HTuple angleExtend, HTuple maxError, HTuple subPixel)
		{
			HOperatorSet.BestMatchRot(image, templateID, angleStart, angleExtend, maxError, subPixel, out HTuple row, out HTuple column, out HTuple angle, out HTuple error);
			return (row,column,angle,error);
		}
		public static (HTuple row, HTuple column, HTuple error) BestMatch (HObject image, HTuple templateID, HTuple maxError, HTuple subPixel)
		{
			HOperatorSet.BestMatch(image, templateID, maxError, subPixel, out HTuple row, out HTuple column, out HTuple error);
			return (row,column,error);
		}
		public static HObject ExhaustiveMatch (HObject image, HObject regionOfInterest, HObject imageTemplate, HTuple mode)
		{
			HOperatorSet.ExhaustiveMatch(image, regionOfInterest, imageTemplate, out HObject imageMatch, mode);
			return imageMatch;
		}
		public static HObject CornerResponse (HObject image, HTuple size, HTuple weight)
		{
			HOperatorSet.CornerResponse(image, out HObject imageCorner, size, weight);
			return imageCorner;
		}
		public static HObject GenGaussPyramid (HObject image, HTuple mode, HTuple scale)
		{
			HOperatorSet.GenGaussPyramid(image, out HObject imagePyramid, mode, scale);
			return imagePyramid;
		}
		public static HObject Monotony (HObject image)
		{
			HOperatorSet.Monotony(image, out HObject imageMonotony);
			return imageMonotony;
		}
		public static HObject BandpassImage (HObject image, HTuple filterType)
		{
			HOperatorSet.BandpassImage(image, out HObject imageBandpass, filterType);
			return imageBandpass;
		}
		public static HObject LinesColor (HObject image, HTuple sigma, HTuple low, HTuple high, HTuple extractWidth, HTuple completeJunctions)
		{
			HOperatorSet.LinesColor(image, out HObject lines, sigma, low, high, extractWidth, completeJunctions);
			return lines;
		}
		public static HObject LinesGauss (HObject image, HTuple sigma, HTuple low, HTuple high, HTuple lightDark, HTuple extractWidth, HTuple lineModel, HTuple completeJunctions)
		{
			HOperatorSet.LinesGauss(image, out HObject lines, sigma, low, high, lightDark, extractWidth, lineModel, completeJunctions);
			return lines;
		}
		public static HObject LinesFacet (HObject image, HTuple maskSize, HTuple low, HTuple high, HTuple lightDark)
		{
			HOperatorSet.LinesFacet(image, out HObject lines, maskSize, low, high, lightDark);
			return lines;
		}
		public static HObject GenFilterMask (HTuple filterMask, HTuple scale, HTuple width, HTuple height)
		{
			HOperatorSet.GenFilterMask(out HObject imageFilter, filterMask, scale, width, height);
			return imageFilter;
		}
		public static HObject GenMeanFilter (HTuple maskShape, HTuple diameter1, HTuple diameter2, HTuple phi, HTuple norm, HTuple mode, HTuple width, HTuple height)
		{
			HOperatorSet.GenMeanFilter(out HObject imageMean, maskShape, diameter1, diameter2, phi, norm, mode, width, height);
			return imageMean;
		}
		public static HObject GenGaussFilter (HTuple sigma1, HTuple sigma2, HTuple phi, HTuple norm, HTuple mode, HTuple width, HTuple height)
		{
			HOperatorSet.GenGaussFilter(out HObject imageGauss, sigma1, sigma2, phi, norm, mode, width, height);
			return imageGauss;
		}
		public static HObject GenDerivativeFilter (HTuple derivative, HTuple exponent, HTuple norm, HTuple mode, HTuple width, HTuple height)
		{
			HOperatorSet.GenDerivativeFilter(out HObject imageDerivative, derivative, exponent, norm, mode, width, height);
			return imageDerivative;
		}
		public static HObject GenStdBandpass (HTuple frequency, HTuple sigma, HTuple type, HTuple norm, HTuple mode, HTuple width, HTuple height)
		{
			HOperatorSet.GenStdBandpass(out HObject imageFilter, frequency, sigma, type, norm, mode, width, height);
			return imageFilter;
		}
		public static HObject GenSinBandpass (HTuple frequency, HTuple norm, HTuple mode, HTuple width, HTuple height)
		{
			HOperatorSet.GenSinBandpass(out HObject imageFilter, frequency, norm, mode, width, height);
			return imageFilter;
		}
		public static HObject GenBandfilter (HTuple minFrequency, HTuple maxFrequency, HTuple norm, HTuple mode, HTuple width, HTuple height)
		{
			HOperatorSet.GenBandfilter(out HObject imageFilter, minFrequency, maxFrequency, norm, mode, width, height);
			return imageFilter;
		}
		public static HObject GenBandpass (HTuple minFrequency, HTuple maxFrequency, HTuple norm, HTuple mode, HTuple width, HTuple height)
		{
			HOperatorSet.GenBandpass(out HObject imageBandpass, minFrequency, maxFrequency, norm, mode, width, height);
			return imageBandpass;
		}
		public static HObject GenLowpass (HTuple frequency, HTuple norm, HTuple mode, HTuple width, HTuple height)
		{
			HOperatorSet.GenLowpass(out HObject imageLowpass, frequency, norm, mode, width, height);
			return imageLowpass;
		}
		public static HObject GenHighpass (HTuple frequency, HTuple norm, HTuple mode, HTuple width, HTuple height)
		{
			HOperatorSet.GenHighpass(out HObject imageHighpass, frequency, norm, mode, width, height);
			return imageHighpass;
		}
		public static HObject PowerLn (HObject image)
		{
			HOperatorSet.PowerLn(image, out HObject imageResult);
			return imageResult;
		}
		public static HObject PowerReal (HObject image)
		{
			HOperatorSet.PowerReal(image, out HObject imageResult);
			return imageResult;
		}
		public static HObject PowerByte (HObject image)
		{
			HOperatorSet.PowerByte(image, out HObject powerByte);
			return powerByte;
		}
		public static HObject PhaseDeg (HObject imageComplex)
		{
			HOperatorSet.PhaseDeg(imageComplex, out HObject imagePhase);
			return imagePhase;
		}
		public static HObject PhaseRad (HObject imageComplex)
		{
			HOperatorSet.PhaseRad(imageComplex, out HObject imagePhase);
			return imagePhase;
		}
		public static HObject EnergyGabor (HObject imageGabor, HObject imageHilbert)
		{
			HOperatorSet.EnergyGabor(imageGabor, imageHilbert, out HObject energy);
			return energy;
		}
		public static (HObject imageResultGabor, HObject imageResultHilbert) ConvolGabor (HObject imageFFT, HObject gaborFilter)
		{
			HOperatorSet.ConvolGabor(imageFFT, gaborFilter, out HObject imageResultGabor, out HObject imageResultHilbert);
			return (imageResultGabor,imageResultHilbert);
		}
		public static HObject GenGabor (HTuple angle, HTuple frequency, HTuple bandwidth, HTuple orientation, HTuple norm, HTuple mode, HTuple width, HTuple height)
		{
			HOperatorSet.GenGabor(out HObject imageFilter, angle, frequency, bandwidth, orientation, norm, mode, width, height);
			return imageFilter;
		}
		public static HObject PhaseCorrelationFft (HObject imageFFT1, HObject imageFFT2)
		{
			HOperatorSet.PhaseCorrelationFft(imageFFT1, imageFFT2, out HObject imagePhaseCorrelation);
			return imagePhaseCorrelation;
		}
		public static HObject CorrelationFft (HObject imageFFT1, HObject imageFFT2)
		{
			HOperatorSet.CorrelationFft(imageFFT1, imageFFT2, out HObject imageCorrelation);
			return imageCorrelation;
		}
		public static HObject ConvolFft (HObject imageFFT, HObject imageFilter)
		{
			HOperatorSet.ConvolFft(imageFFT, imageFilter, out HObject imageConvol);
			return imageConvol;
		}
		public static void DeserializeFftOptimizationData (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeFftOptimizationData(serializedItemHandle);
		}
		public static (HTuple row, HTuple column, HTuple button) GetMpositionSubPix (HTuple windowHandle)
		{
			HOperatorSet.GetMpositionSubPix(windowHandle, out HTuple row, out HTuple column, out HTuple button);
			return (row,column,button);
		}
		public static (HTuple row, HTuple column, HTuple button) GetMposition (HTuple windowHandle)
		{
			HOperatorSet.GetMposition(windowHandle, out HTuple row, out HTuple column, out HTuple button);
			return (row,column,button);
		}
		public static (HTuple row, HTuple column, HTuple button) GetMbuttonSubPix (HTuple windowHandle)
		{
			HOperatorSet.GetMbuttonSubPix(windowHandle, out HTuple row, out HTuple column, out HTuple button);
			return (row,column,button);
		}
		public static (HTuple row, HTuple column, HTuple button) GetMbutton (HTuple windowHandle)
		{
			HOperatorSet.GetMbutton(windowHandle, out HTuple row, out HTuple column, out HTuple button);
			return (row,column,button);
		}
		public static void WriteLut (HTuple windowHandle, HTuple fileName)
		{
			HOperatorSet.WriteLut(windowHandle, fileName);
		}
		public static void DispLut (HTuple windowHandle, HTuple row, HTuple column, HTuple scale)
		{
			HOperatorSet.DispLut(windowHandle, row, column, scale);
		}
		public static HTuple QueryLut (HTuple windowHandle)
		{
			HOperatorSet.QueryLut(windowHandle, out HTuple lookUpTable);
			return lookUpTable;
		}
		public static (HTuple hue, HTuple saturation, HTuple intensity) GetLutStyle (HTuple windowHandle)
		{
			HOperatorSet.GetLutStyle(windowHandle, out HTuple hue, out HTuple saturation, out HTuple intensity);
			return (hue,saturation,intensity);
		}
		public static void SetLutStyle (HTuple windowHandle, HTuple hue, HTuple saturation, HTuple intensity)
		{
			HOperatorSet.SetLutStyle(windowHandle, hue, saturation, intensity);
		}
		public static HTuple GetLut (HTuple windowHandle)
		{
			HOperatorSet.GetLut(windowHandle, out HTuple lookUpTable);
			return lookUpTable;
		}
		public static void SetLut (HTuple windowHandle, HTuple lookUpTable)
		{
			HOperatorSet.SetLut(windowHandle, lookUpTable);
		}
		public static HTuple GetFix (HTuple windowHandle)
		{
			HOperatorSet.GetFix(windowHandle, out HTuple mode);
			return mode;
		}
		public static void SetFix (HTuple windowHandle, HTuple mode)
		{
			HOperatorSet.SetFix(windowHandle, mode);
		}
		public static HTuple GetFixedLut (HTuple windowHandle)
		{
			HOperatorSet.GetFixedLut(windowHandle, out HTuple mode);
			return mode;
		}
		public static void SetFixedLut (HTuple windowHandle, HTuple mode)
		{
			HOperatorSet.SetFixedLut(windowHandle, mode);
		}
		public static void GnuplotPlotFunct1d (HTuple gnuplotFileID, HTuple function)
		{
			HOperatorSet.GnuplotPlotFunct1d(gnuplotFileID, function);
		}
		public static void GnuplotPlotCtrl (HTuple gnuplotFileID, HTuple values)
		{
			HOperatorSet.GnuplotPlotCtrl(gnuplotFileID, values);
		}
		public static void GnuplotPlotImage (HObject image, HTuple gnuplotFileID, HTuple samplesX, HTuple samplesY, HTuple viewRotX, HTuple viewRotZ, HTuple hidden3D)
		{
			HOperatorSet.GnuplotPlotImage(image, gnuplotFileID, samplesX, samplesY, viewRotX, viewRotZ, hidden3D);
		}
		public static void GnuplotClose (HTuple gnuplotFileID)
		{
			HOperatorSet.GnuplotClose(gnuplotFileID);
		}
		public static HTuple GnuplotOpenFile (HTuple fileName)
		{
			HOperatorSet.GnuplotOpenFile(fileName, out HTuple gnuplotFileID);
			return gnuplotFileID;
		}
		public static HTuple GnuplotOpenPipe ()
		{
			HOperatorSet.GnuplotOpenPipe(out HTuple gnuplotFileID);
			return gnuplotFileID;
		}
		public static HTuple CreateDrawingObjectText (HTuple row, HTuple column, HTuple stringVal)
		{
			HOperatorSet.CreateDrawingObjectText(row, column, stringVal, out HTuple drawID);
			return drawID;
		}
		public static HObject GetDrawingObjectIconic (HTuple drawID)
		{
			HOperatorSet.GetDrawingObjectIconic(out HObject objectVal, drawID);
			return objectVal;
		}
		public static void ClearDrawingObject (HTuple drawID)
		{
			HOperatorSet.ClearDrawingObject(drawID);
		}
		public static void SetDrawingObjectParams (HTuple drawID, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetDrawingObjectParams(drawID, genParamName, genParamValue);
		}
		public static HTuple GetDrawingObjectParams (HTuple drawID, HTuple genParamName)
		{
			HOperatorSet.GetDrawingObjectParams(drawID, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetDrawingObjectXld (HObject contour, HTuple drawID)
		{
			HOperatorSet.SetDrawingObjectXld(contour, drawID);
		}
		public static HTuple CreateDrawingObjectXld (HTuple row, HTuple column)
		{
			HOperatorSet.CreateDrawingObjectXld(row, column, out HTuple drawID);
			return drawID;
		}
		public static HTuple CreateDrawingObjectCircleSector (HTuple row, HTuple column, HTuple radius, HTuple startAngle, HTuple endAngle)
		{
			HOperatorSet.CreateDrawingObjectCircleSector(row, column, radius, startAngle, endAngle, out HTuple drawID);
			return drawID;
		}
		public static HTuple CreateDrawingObjectEllipseSector (HTuple row, HTuple column, HTuple phi, HTuple radius1, HTuple radius2, HTuple startAngle, HTuple endAngle)
		{
			HOperatorSet.CreateDrawingObjectEllipseSector(row, column, phi, radius1, radius2, startAngle, endAngle, out HTuple drawID);
			return drawID;
		}
		public static HTuple CreateDrawingObjectLine (HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.CreateDrawingObjectLine(row1, column1, row2, column2, out HTuple drawID);
			return drawID;
		}
		public static HTuple CreateDrawingObjectCircle (HTuple row, HTuple column, HTuple radius)
		{
			HOperatorSet.CreateDrawingObjectCircle(row, column, radius, out HTuple drawID);
			return drawID;
		}
		public static HTuple CreateDrawingObjectEllipse (HTuple row, HTuple column, HTuple phi, HTuple radius1, HTuple radius2)
		{
			HOperatorSet.CreateDrawingObjectEllipse(row, column, phi, radius1, radius2, out HTuple drawID);
			return drawID;
		}
		public static HTuple CreateDrawingObjectRectangle2 (HTuple row, HTuple column, HTuple phi, HTuple length1, HTuple length2)
		{
			HOperatorSet.CreateDrawingObjectRectangle2(row, column, phi, length1, length2, out HTuple drawID);
			return drawID;
		}
		public static HTuple CreateDrawingObjectRectangle1 (HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.CreateDrawingObjectRectangle1(row1, column1, row2, column2, out HTuple drawID);
			return drawID;
		}
		public static HObject DragRegion3 (HObject sourceRegion, HObject maskRegion, HTuple windowHandle, HTuple row, HTuple column)
		{
			HOperatorSet.DragRegion3(sourceRegion, maskRegion, out HObject destinationRegion, windowHandle, row, column);
			return destinationRegion;
		}
		public static HObject DragRegion2 (HObject sourceRegion, HTuple windowHandle, HTuple row, HTuple column)
		{
			HOperatorSet.DragRegion2(sourceRegion, out HObject destinationRegion, windowHandle, row, column);
			return destinationRegion;
		}
		public static HObject DragRegion1 (HObject sourceRegion, HTuple windowHandle)
		{
			HOperatorSet.DragRegion1(sourceRegion, out HObject destinationRegion, windowHandle);
			return destinationRegion;
		}
		public static (HObject contOut, HTuple controlRows, HTuple controlCols, HTuple knots, HTuple rows, HTuple cols, HTuple tangents) DrawNurbsInterpMod (HTuple windowHandle, HTuple rotate, HTuple move, HTuple scale, HTuple keepRatio, HTuple edit, HTuple degree, HTuple rowsIn, HTuple colsIn, HTuple tangentsIn)
		{
			HOperatorSet.DrawNurbsInterpMod(out HObject contOut, windowHandle, rotate, move, scale, keepRatio, edit, degree, rowsIn, colsIn, tangentsIn, out HTuple controlRows, out HTuple controlCols, out HTuple knots, out HTuple rows, out HTuple cols, out HTuple tangents);
			return (contOut,controlRows,controlCols,knots,rows,cols,tangents);
		}
		public static (HObject contOut, HTuple controlRows, HTuple controlCols, HTuple knots, HTuple rows, HTuple cols, HTuple tangents) DrawNurbsInterp (HTuple windowHandle, HTuple rotate, HTuple move, HTuple scale, HTuple keepRatio, HTuple degree)
		{
			HOperatorSet.DrawNurbsInterp(out HObject contOut, windowHandle, rotate, move, scale, keepRatio, degree, out HTuple controlRows, out HTuple controlCols, out HTuple knots, out HTuple rows, out HTuple cols, out HTuple tangents);
			return (contOut,controlRows,controlCols,knots,rows,cols,tangents);
		}
		public static (HObject contOut, HTuple rows, HTuple cols, HTuple weights) DrawNurbsMod (HTuple windowHandle, HTuple rotate, HTuple move, HTuple scale, HTuple keepRatio, HTuple edit, HTuple degree, HTuple rowsIn, HTuple colsIn, HTuple weightsIn)
		{
			HOperatorSet.DrawNurbsMod(out HObject contOut, windowHandle, rotate, move, scale, keepRatio, edit, degree, rowsIn, colsIn, weightsIn, out HTuple rows, out HTuple cols, out HTuple weights);
			return (contOut,rows,cols,weights);
		}
		public static (HObject contOut, HTuple rows, HTuple cols, HTuple weights) DrawNurbs (HTuple windowHandle, HTuple rotate, HTuple move, HTuple scale, HTuple keepRatio, HTuple degree)
		{
			HOperatorSet.DrawNurbs(out HObject contOut, windowHandle, rotate, move, scale, keepRatio, degree, out HTuple rows, out HTuple cols, out HTuple weights);
			return (contOut,rows,cols,weights);
		}
		public static HObject DrawXldMod (HObject contIn, HTuple windowHandle, HTuple rotate, HTuple move, HTuple scale, HTuple keepRatio, HTuple edit)
		{
			HOperatorSet.DrawXldMod(contIn, out HObject contOut, windowHandle, rotate, move, scale, keepRatio, edit);
			return contOut;
		}
		public static HObject DrawXld (HTuple windowHandle, HTuple rotate, HTuple move, HTuple scale, HTuple keepRatio)
		{
			HOperatorSet.DrawXld(out HObject contOut, windowHandle, rotate, move, scale, keepRatio);
			return contOut;
		}
		public static (HTuple row, HTuple column, HTuple phi, HTuple length1, HTuple length2) DrawRectangle2Mod (HTuple windowHandle, HTuple rowIn, HTuple columnIn, HTuple phiIn, HTuple length1In, HTuple length2In)
		{
			HOperatorSet.DrawRectangle2Mod(windowHandle, rowIn, columnIn, phiIn, length1In, length2In, out HTuple row, out HTuple column, out HTuple phi, out HTuple length1, out HTuple length2);
			return (row,column,phi,length1,length2);
		}
		public static (HTuple row, HTuple column, HTuple phi, HTuple length1, HTuple length2) DrawRectangle2 (HTuple windowHandle)
		{
			HOperatorSet.DrawRectangle2(windowHandle, out HTuple row, out HTuple column, out HTuple phi, out HTuple length1, out HTuple length2);
			return (row,column,phi,length1,length2);
		}
		public static (HTuple row1, HTuple column1, HTuple row2, HTuple column2) DrawRectangle1Mod (HTuple windowHandle, HTuple row1In, HTuple column1In, HTuple row2In, HTuple column2In)
		{
			HOperatorSet.DrawRectangle1Mod(windowHandle, row1In, column1In, row2In, column2In, out HTuple row1, out HTuple column1, out HTuple row2, out HTuple column2);
			return (row1,column1,row2,column2);
		}
		public static (HTuple row1, HTuple column1, HTuple row2, HTuple column2) DrawRectangle1 (HTuple windowHandle)
		{
			HOperatorSet.DrawRectangle1(windowHandle, out HTuple row1, out HTuple column1, out HTuple row2, out HTuple column2);
			return (row1,column1,row2,column2);
		}
		public static (HTuple row, HTuple column) DrawPointMod (HTuple windowHandle, HTuple rowIn, HTuple columnIn)
		{
			HOperatorSet.DrawPointMod(windowHandle, rowIn, columnIn, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static (HTuple row, HTuple column) DrawPoint (HTuple windowHandle)
		{
			HOperatorSet.DrawPoint(windowHandle, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static (HTuple row1, HTuple column1, HTuple row2, HTuple column2) DrawLineMod (HTuple windowHandle, HTuple row1In, HTuple column1In, HTuple row2In, HTuple column2In)
		{
			HOperatorSet.DrawLineMod(windowHandle, row1In, column1In, row2In, column2In, out HTuple row1, out HTuple column1, out HTuple row2, out HTuple column2);
			return (row1,column1,row2,column2);
		}
		public static (HTuple row1, HTuple column1, HTuple row2, HTuple column2) DrawLine (HTuple windowHandle)
		{
			HOperatorSet.DrawLine(windowHandle, out HTuple row1, out HTuple column1, out HTuple row2, out HTuple column2);
			return (row1,column1,row2,column2);
		}
		public static (HTuple row, HTuple column, HTuple phi, HTuple radius1, HTuple radius2) DrawEllipseMod (HTuple windowHandle, HTuple rowIn, HTuple columnIn, HTuple phiIn, HTuple radius1In, HTuple radius2In)
		{
			HOperatorSet.DrawEllipseMod(windowHandle, rowIn, columnIn, phiIn, radius1In, radius2In, out HTuple row, out HTuple column, out HTuple phi, out HTuple radius1, out HTuple radius2);
			return (row,column,phi,radius1,radius2);
		}
		public static (HTuple row, HTuple column, HTuple phi, HTuple radius1, HTuple radius2) DrawEllipse (HTuple windowHandle)
		{
			HOperatorSet.DrawEllipse(windowHandle, out HTuple row, out HTuple column, out HTuple phi, out HTuple radius1, out HTuple radius2);
			return (row,column,phi,radius1,radius2);
		}
		public static (HTuple row, HTuple column, HTuple radius) DrawCircleMod (HTuple windowHandle, HTuple rowIn, HTuple columnIn, HTuple radiusIn)
		{
			HOperatorSet.DrawCircleMod(windowHandle, rowIn, columnIn, radiusIn, out HTuple row, out HTuple column, out HTuple radius);
			return (row,column,radius);
		}
		public static (HTuple row, HTuple column, HTuple radius) DrawCircle (HTuple windowHandle)
		{
			HOperatorSet.DrawCircle(windowHandle, out HTuple row, out HTuple column, out HTuple radius);
			return (row,column,radius);
		}
		public static HObject DrawRegion (HTuple windowHandle)
		{
			HOperatorSet.DrawRegion(out HObject region, windowHandle);
			return region;
		}
		public static HObject DrawPolygon (HTuple windowHandle)
		{
			HOperatorSet.DrawPolygon(out HObject polygonRegion, windowHandle);
			return polygonRegion;
		}
		public static (HTuple rowProj, HTuple colProj) ProjectionPl (HTuple row, HTuple column, HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.ProjectionPl(row, column, row1, column1, row2, column2, out HTuple rowProj, out HTuple colProj);
			return (rowProj,colProj);
		}
		public static (HTuple rowPoint, HTuple colPoint) GetPointsEllipse (HTuple angle, HTuple row, HTuple column, HTuple phi, HTuple radius1, HTuple radius2)
		{
			HOperatorSet.GetPointsEllipse(angle, row, column, phi, radius1, radius2, out HTuple rowPoint, out HTuple colPoint);
			return (rowPoint,colPoint);
		}
		public static (HTuple row, HTuple column, HTuple isParallel) IntersectionLl (HTuple rowA1, HTuple columnA1, HTuple rowA2, HTuple columnA2, HTuple rowB1, HTuple columnB1, HTuple rowB2, HTuple columnB2)
		{
			HOperatorSet.IntersectionLl(rowA1, columnA1, rowA2, columnA2, rowB1, columnB1, rowB2, columnB2, out HTuple row, out HTuple column, out HTuple isParallel);
			return (row,column,isParallel);
		}
		public static (HTuple row, HTuple column, HTuple isOverlapping) IntersectionContoursXld (HObject contour1, HObject contour2, HTuple intersectionType)
		{
			HOperatorSet.IntersectionContoursXld(contour1, contour2, intersectionType, out HTuple row, out HTuple column, out HTuple isOverlapping);
			return (row,column,isOverlapping);
		}
		public static (HTuple row, HTuple column) IntersectionCircleContourXld (HObject contour, HTuple circleRow, HTuple circleColumn, HTuple circleRadius, HTuple circleStartPhi, HTuple circleEndPhi, HTuple circlePointOrder)
		{
			HOperatorSet.IntersectionCircleContourXld(contour, circleRow, circleColumn, circleRadius, circleStartPhi, circleEndPhi, circlePointOrder, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static (HTuple row, HTuple column, HTuple isOverlapping) IntersectionCircles (HTuple circle1Row, HTuple circle1Column, HTuple circle1Radius, HTuple circle1StartPhi, HTuple circle1EndPhi, HTuple circle1PointOrder, HTuple circle2Row, HTuple circle2Column, HTuple circle2Radius, HTuple circle2StartPhi, HTuple circle2EndPhi, HTuple circle2PointOrder)
		{
			HOperatorSet.IntersectionCircles(circle1Row, circle1Column, circle1Radius, circle1StartPhi, circle1EndPhi, circle1PointOrder, circle2Row, circle2Column, circle2Radius, circle2StartPhi, circle2EndPhi, circle2PointOrder, out HTuple row, out HTuple column, out HTuple isOverlapping);
			return (row,column,isOverlapping);
		}
		public static (HTuple row, HTuple column, HTuple isOverlapping) IntersectionLineContourXld (HObject contour, HTuple lineRow1, HTuple lineColumn1, HTuple lineRow2, HTuple lineColumn2)
		{
			HOperatorSet.IntersectionLineContourXld(contour, lineRow1, lineColumn1, lineRow2, lineColumn2, out HTuple row, out HTuple column, out HTuple isOverlapping);
			return (row,column,isOverlapping);
		}
		public static (HTuple row, HTuple column) IntersectionLineCircle (HTuple lineRow1, HTuple lineColumn1, HTuple lineRow2, HTuple lineColumn2, HTuple circleRow, HTuple circleColumn, HTuple circleRadius, HTuple circleStartPhi, HTuple circleEndPhi, HTuple circlePointOrder)
		{
			HOperatorSet.IntersectionLineCircle(lineRow1, lineColumn1, lineRow2, lineColumn2, circleRow, circleColumn, circleRadius, circleStartPhi, circleEndPhi, circlePointOrder, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static (HTuple row, HTuple column, HTuple isOverlapping) IntersectionLines (HTuple line1Row1, HTuple line1Column1, HTuple line1Row2, HTuple line1Column2, HTuple line2Row1, HTuple line2Column1, HTuple line2Row2, HTuple line2Column2)
		{
			HOperatorSet.IntersectionLines(line1Row1, line1Column1, line1Row2, line1Column2, line2Row1, line2Column1, line2Row2, line2Column2, out HTuple row, out HTuple column, out HTuple isOverlapping);
			return (row,column,isOverlapping);
		}
		public static (HTuple row, HTuple column, HTuple isOverlapping) IntersectionSegmentContourXld (HObject contour, HTuple segmentRow1, HTuple segmentColumn1, HTuple segmentRow2, HTuple segmentColumn2)
		{
			HOperatorSet.IntersectionSegmentContourXld(contour, segmentRow1, segmentColumn1, segmentRow2, segmentColumn2, out HTuple row, out HTuple column, out HTuple isOverlapping);
			return (row,column,isOverlapping);
		}
		public static (HTuple row, HTuple column) IntersectionSegmentCircle (HTuple segmentRow1, HTuple segmentColumn1, HTuple segmentRow2, HTuple segmentColumn2, HTuple circleRow, HTuple circleColumn, HTuple circleRadius, HTuple circleStartPhi, HTuple circleEndPhi, HTuple circlePointOrder)
		{
			HOperatorSet.IntersectionSegmentCircle(segmentRow1, segmentColumn1, segmentRow2, segmentColumn2, circleRow, circleColumn, circleRadius, circleStartPhi, circleEndPhi, circlePointOrder, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static (HTuple row, HTuple column, HTuple isOverlapping) IntersectionSegmentLine (HTuple segmentRow1, HTuple segmentColumn1, HTuple segmentRow2, HTuple segmentColumn2, HTuple lineRow1, HTuple lineColumn1, HTuple lineRow2, HTuple lineColumn2)
		{
			HOperatorSet.IntersectionSegmentLine(segmentRow1, segmentColumn1, segmentRow2, segmentColumn2, lineRow1, lineColumn1, lineRow2, lineColumn2, out HTuple row, out HTuple column, out HTuple isOverlapping);
			return (row,column,isOverlapping);
		}
		public static (HTuple row, HTuple column, HTuple isOverlapping) IntersectionSegments (HTuple segment1Row1, HTuple segment1Column1, HTuple segment1Row2, HTuple segment1Column2, HTuple segment2Row1, HTuple segment2Column1, HTuple segment2Row2, HTuple segment2Column2)
		{
			HOperatorSet.IntersectionSegments(segment1Row1, segment1Column1, segment1Row2, segment1Column2, segment2Row1, segment2Column1, segment2Row2, segment2Column2, out HTuple row, out HTuple column, out HTuple isOverlapping);
			return (row,column,isOverlapping);
		}
		public static void ClearDistanceTransformXld (HTuple distanceTransformID)
		{
			HOperatorSet.ClearDistanceTransformXld(distanceTransformID);
		}
		public static HObject ApplyDistanceTransformXld (HObject contour, HTuple distanceTransformID)
		{
			HOperatorSet.ApplyDistanceTransformXld(contour, out HObject contourOut, distanceTransformID);
			return contourOut;
		}
		public static HTuple ReadDistanceTransformXld (HTuple fileName)
		{
			HOperatorSet.ReadDistanceTransformXld(fileName, out HTuple distanceTransformID);
			return distanceTransformID;
		}
		public static HTuple DeserializeDistanceTransformXld (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeDistanceTransformXld(serializedItemHandle, out HTuple distanceTransformID);
			return distanceTransformID;
		}
		public static HTuple SerializeDistanceTransformXld (HTuple distanceTransformID)
		{
			HOperatorSet.SerializeDistanceTransformXld(distanceTransformID, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static void WriteDistanceTransformXld (HTuple distanceTransformID, HTuple fileName)
		{
			HOperatorSet.WriteDistanceTransformXld(distanceTransformID, fileName);
		}
		public static void SetDistanceTransformXldParam (HTuple distanceTransformID, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetDistanceTransformXldParam(distanceTransformID, genParamName, genParamValue);
		}
		public static HTuple GetDistanceTransformXldParam (HTuple distanceTransformID, HTuple genParamName)
		{
			HOperatorSet.GetDistanceTransformXldParam(distanceTransformID, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static HObject GetDistanceTransformXldContour (HTuple distanceTransformID)
		{
			HOperatorSet.GetDistanceTransformXldContour(out HObject contour, distanceTransformID);
			return contour;
		}
		public static HTuple CreateDistanceTransformXld (HObject contour, HTuple mode, HTuple maxDistance)
		{
			HOperatorSet.CreateDistanceTransformXld(contour, mode, maxDistance, out HTuple distanceTransformID);
			return distanceTransformID;
		}
		public static HObject DistanceContoursXld (HObject contourFrom, HObject contourTo, HTuple mode)
		{
			HOperatorSet.DistanceContoursXld(contourFrom, contourTo, out HObject contourOut, mode);
			return contourOut;
		}
		public static HTuple DistanceCcMin (HObject contour1, HObject contour2, HTuple mode)
		{
			HOperatorSet.DistanceCcMin(contour1, contour2, mode, out HTuple distanceMin);
			return distanceMin;
		}
		public static (HTuple distanceMin, HTuple distanceMax) DistanceCc (HObject contour1, HObject contour2, HTuple mode)
		{
			HOperatorSet.DistanceCc(contour1, contour2, mode, out HTuple distanceMin, out HTuple distanceMax);
			return (distanceMin,distanceMax);
		}
		public static (HTuple distanceMin, HTuple distanceMax) DistanceSc (HObject contour, HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.DistanceSc(contour, row1, column1, row2, column2, out HTuple distanceMin, out HTuple distanceMax);
			return (distanceMin,distanceMax);
		}
		public static (HTuple distanceMin, HTuple distanceMax) DistanceLc (HObject contour, HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.DistanceLc(contour, row1, column1, row2, column2, out HTuple distanceMin, out HTuple distanceMax);
			return (distanceMin,distanceMax);
		}
		public static (HTuple distanceMin, HTuple distanceMax) DistancePc (HObject contour, HTuple row, HTuple column)
		{
			HOperatorSet.DistancePc(contour, row, column, out HTuple distanceMin, out HTuple distanceMax);
			return (distanceMin,distanceMax);
		}
		public static (HTuple distanceMin, HTuple distanceMax) DistanceSr (HObject region, HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.DistanceSr(region, row1, column1, row2, column2, out HTuple distanceMin, out HTuple distanceMax);
			return (distanceMin,distanceMax);
		}
		public static (HTuple distanceMin, HTuple distanceMax) DistanceLr (HObject region, HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.DistanceLr(region, row1, column1, row2, column2, out HTuple distanceMin, out HTuple distanceMax);
			return (distanceMin,distanceMax);
		}
		public static (HTuple distanceMin, HTuple distanceMax) DistancePr (HObject region, HTuple row, HTuple column)
		{
			HOperatorSet.DistancePr(region, row, column, out HTuple distanceMin, out HTuple distanceMax);
			return (distanceMin,distanceMax);
		}
		public static HTuple AngleLx (HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.AngleLx(row1, column1, row2, column2, out HTuple angle);
			return angle;
		}
		public static HTuple AngleLl (HTuple rowA1, HTuple columnA1, HTuple rowA2, HTuple columnA2, HTuple rowB1, HTuple columnB1, HTuple rowB2, HTuple columnB2)
		{
			HOperatorSet.AngleLl(rowA1, columnA1, rowA2, columnA2, rowB1, columnB1, rowB2, columnB2, out HTuple angle);
			return angle;
		}
		public static (HTuple distanceMin, HTuple distanceMax) DistanceSl (HTuple rowA1, HTuple columnA1, HTuple rowA2, HTuple columnA2, HTuple rowB1, HTuple columnB1, HTuple rowB2, HTuple columnB2)
		{
			HOperatorSet.DistanceSl(rowA1, columnA1, rowA2, columnA2, rowB1, columnB1, rowB2, columnB2, out HTuple distanceMin, out HTuple distanceMax);
			return (distanceMin,distanceMax);
		}
		public static (HTuple distanceMin, HTuple distanceMax) DistanceSs (HTuple rowA1, HTuple columnA1, HTuple rowA2, HTuple columnA2, HTuple rowB1, HTuple columnB1, HTuple rowB2, HTuple columnB2)
		{
			HOperatorSet.DistanceSs(rowA1, columnA1, rowA2, columnA2, rowB1, columnB1, rowB2, columnB2, out HTuple distanceMin, out HTuple distanceMax);
			return (distanceMin,distanceMax);
		}
		public static (HTuple distanceMin, HTuple distanceMax) DistancePs (HTuple row, HTuple column, HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.DistancePs(row, column, row1, column1, row2, column2, out HTuple distanceMin, out HTuple distanceMax);
			return (distanceMin,distanceMax);
		}
		public static HTuple DistancePl (HTuple row, HTuple column, HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.DistancePl(row, column, row1, column1, row2, column2, out HTuple distance);
			return distance;
		}
		public static HTuple DistancePp (HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.DistancePp(row1, column1, row2, column2, out HTuple distance);
			return distance;
		}
		public static HTuple ComposeFunct1d (HTuple function1, HTuple function2, HTuple border)
		{
			HOperatorSet.ComposeFunct1d(function1, function2, border, out HTuple composedFunction);
			return composedFunction;
		}
		public static HTuple InvertFunct1d (HTuple function)
		{
			HOperatorSet.InvertFunct1d(function, out HTuple inverseFunction);
			return inverseFunction;
		}
		public static HTuple DerivateFunct1d (HTuple function, HTuple mode)
		{
			HOperatorSet.DerivateFunct1d(function, mode, out HTuple derivative);
			return derivative;
		}
		public static (HTuple min, HTuple max) LocalMinMaxFunct1d (HTuple function, HTuple mode, HTuple interpolation)
		{
			HOperatorSet.LocalMinMaxFunct1d(function, mode, interpolation, out HTuple min, out HTuple max);
			return (min,max);
		}
		public static HTuple ZeroCrossingsFunct1d (HTuple function)
		{
			HOperatorSet.ZeroCrossingsFunct1d(function, out HTuple zeroCrossings);
			return zeroCrossings;
		}
		public static HTuple ScaleYFunct1d (HTuple function, HTuple mult, HTuple add)
		{
			HOperatorSet.ScaleYFunct1d(function, mult, add, out HTuple functionScaled);
			return functionScaled;
		}
		public static HTuple NegateFunct1d (HTuple function)
		{
			HOperatorSet.NegateFunct1d(function, out HTuple functionInverted);
			return functionInverted;
		}
		public static HTuple AbsFunct1d (HTuple function)
		{
			HOperatorSet.AbsFunct1d(function, out HTuple functionAbsolute);
			return functionAbsolute;
		}
		public static HTuple GetYValueFunct1d (HTuple function, HTuple x, HTuple border)
		{
			HOperatorSet.GetYValueFunct1d(function, x, border, out HTuple y);
			return y;
		}
		public static (HTuple x, HTuple y) GetPairFunct1d (HTuple function, HTuple index)
		{
			HOperatorSet.GetPairFunct1d(function, index, out HTuple x, out HTuple y);
			return (x,y);
		}
		public static HTuple NumPointsFunct1d (HTuple function)
		{
			HOperatorSet.NumPointsFunct1d(function, out HTuple length);
			return length;
		}
		public static (HTuple YMin, HTuple YMax) YRangeFunct1d (HTuple function)
		{
			HOperatorSet.YRangeFunct1d(function, out HTuple YMin, out HTuple YMax);
			return (YMin,YMax);
		}
		public static (HTuple XMin, HTuple XMax) XRangeFunct1d (HTuple function)
		{
			HOperatorSet.XRangeFunct1d(function, out HTuple XMin, out HTuple XMax);
			return (XMin,XMax);
		}
		public static (HTuple XValues, HTuple YValues) Funct1dToPairs (HTuple function)
		{
			HOperatorSet.Funct1dToPairs(function, out HTuple XValues, out HTuple YValues);
			return (XValues,YValues);
		}
		public static HTuple SampleFunct1d (HTuple function, HTuple XMin, HTuple XMax, HTuple XDist, HTuple border)
		{
			HOperatorSet.SampleFunct1d(function, XMin, XMax, XDist, border, out HTuple sampledFunction);
			return sampledFunction;
		}
		public static HTuple TransformFunct1d (HTuple function, HTuple paramsVal)
		{
			HOperatorSet.TransformFunct1d(function, paramsVal, out HTuple transformedFunction);
			return transformedFunction;
		}
		public static (HTuple paramsVal, HTuple chiSquare, HTuple covar) MatchFunct1dTrans (HTuple function1, HTuple function2, HTuple border, HTuple paramsConst, HTuple useParams)
		{
			HOperatorSet.MatchFunct1dTrans(function1, function2, border, paramsConst, useParams, out HTuple paramsVal, out HTuple chiSquare, out HTuple covar);
			return (paramsVal,chiSquare,covar);
		}
		public static HTuple DistanceFunct1d (HTuple function1, HTuple function2, HTuple mode, HTuple sigma)
		{
			HOperatorSet.DistanceFunct1d(function1, function2, mode, sigma, out HTuple distance);
			return distance;
		}
		public static HTuple SmoothFunct1dGauss (HTuple function, HTuple sigma)
		{
			HOperatorSet.SmoothFunct1dGauss(function, sigma, out HTuple smoothedFunction);
			return smoothedFunction;
		}
		public static (HTuple positive, HTuple negative) IntegrateFunct1d (HTuple function)
		{
			HOperatorSet.IntegrateFunct1d(function, out HTuple positive, out HTuple negative);
			return (positive,negative);
		}
		public static HTuple ReadFunct1d (HTuple fileName)
		{
			HOperatorSet.ReadFunct1d(fileName, out HTuple function);
			return function;
		}
		public static void WriteFunct1d (HTuple function, HTuple fileName)
		{
			HOperatorSet.WriteFunct1d(function, fileName);
		}
		public static HTuple CreateFunct1dArray (HTuple YValues)
		{
			HOperatorSet.CreateFunct1dArray(YValues, out HTuple function);
			return function;
		}
		public static HTuple CreateFunct1dPairs (HTuple XValues, HTuple YValues)
		{
			HOperatorSet.CreateFunct1dPairs(XValues, YValues, out HTuple function);
			return function;
		}
		public static HTuple SmoothFunct1dMean (HTuple function, HTuple smoothSize, HTuple iterations)
		{
			HOperatorSet.SmoothFunct1dMean(function, smoothSize, iterations, out HTuple smoothedFunction);
			return smoothedFunction;
		}
		public static HObject TextureLaws (HObject image, HTuple filterTypes, HTuple shift, HTuple filterSize)
		{
			HOperatorSet.TextureLaws(image, out HObject imageTexture, filterTypes, shift, filterSize);
			return imageTexture;
		}
		public static HObject DeviationImage (HObject image, HTuple width, HTuple height)
		{
			HOperatorSet.DeviationImage(image, out HObject imageDeviation, width, height);
			return imageDeviation;
		}
		public static HObject EntropyImage (HObject image, HTuple width, HTuple height)
		{
			HOperatorSet.EntropyImage(image, out HObject imageEntropy, width, height);
			return imageEntropy;
		}
		public static HObject IsotropicDiffusion (HObject image, HTuple sigma, HTuple iterations)
		{
			HOperatorSet.IsotropicDiffusion(image, out HObject smoothedImage, sigma, iterations);
			return smoothedImage;
		}
		public static HObject AnisotropicDiffusion (HObject image, HTuple mode, HTuple contrast, HTuple theta, HTuple iterations)
		{
			HOperatorSet.AnisotropicDiffusion(image, out HObject imageAniso, mode, contrast, theta, iterations);
			return imageAniso;
		}
		public static HObject SmoothImage (HObject image, HTuple filter, HTuple alpha)
		{
			HOperatorSet.SmoothImage(image, out HObject imageSmooth, filter, alpha);
			return imageSmooth;
		}
		public static HObject HoughLineTransDir (HObject imageDir, HTuple directionUncertainty, HTuple angleResolution)
		{
			HOperatorSet.HoughLineTransDir(imageDir, out HObject houghImage, directionUncertainty, angleResolution);
			return houghImage;
		}
		public static (HTuple angle, HTuple dist) HoughLines (HObject regionIn, HTuple angleResolution, HTuple threshold, HTuple angleGap, HTuple distGap)
		{
			HOperatorSet.HoughLines(regionIn, angleResolution, threshold, angleGap, distGap, out HTuple angle, out HTuple dist);
			return (angle,dist);
		}
		public static HObject HoughLineTrans (HObject region, HTuple angleResolution)
		{
			HOperatorSet.HoughLineTrans(region, out HObject houghImage, angleResolution);
			return houghImage;
		}
		public static (HObject regionLines, HTuple angleOut, HTuple distOut) SelectMatchingLines (HObject regionIn, HTuple angleIn, HTuple distIn, HTuple lineWidth, HTuple thresh)
		{
			HOperatorSet.SelectMatchingLines(regionIn, out HObject regionLines, angleIn, distIn, lineWidth, thresh, out HTuple angleOut, out HTuple distOut);
			return (regionLines,angleOut,distOut);
		}
		public static HObject FindRectificationGrid (HObject image, HTuple minContrast, HTuple radius)
		{
			HOperatorSet.FindRectificationGrid(image, out HObject gridRegion, minContrast, radius);
			return gridRegion;
		}
		public static void CreateRectificationGrid (HTuple width, HTuple numSquares, HTuple gridFile)
		{
			HOperatorSet.CreateRectificationGrid(width, numSquares, gridFile);
		}
		public static HObject ConnectGridPoints (HObject image, HTuple row, HTuple column, HTuple sigma, HTuple maxDist)
		{
			HOperatorSet.ConnectGridPoints(image, out HObject connectingLines, row, column, sigma, maxDist);
			return connectingLines;
		}
		public static (HObject map, HObject meshes) GenGridRectificationMap (HObject image, HObject connectingLines, HTuple gridSpacing, HTuple rotation, HTuple row, HTuple column, HTuple mapType)
		{
			HOperatorSet.GenGridRectificationMap(image, connectingLines, out HObject map, out HObject meshes, gridSpacing, rotation, row, column, mapType);
			return (map,meshes);
		}
		public static HObject GenArbitraryDistortionMap (HTuple gridSpacing, HTuple row, HTuple column, HTuple gridWidth, HTuple imageWidth, HTuple imageHeight, HTuple mapType)
		{
			HOperatorSet.GenArbitraryDistortionMap(out HObject map, gridSpacing, row, column, gridWidth, imageWidth, imageHeight, mapType);
			return map;
		}
		public static HObject GetWindowBackgroundImage (HTuple windowHandle)
		{
			HOperatorSet.GetWindowBackgroundImage(out HObject backgroundImage, windowHandle);
			return backgroundImage;
		}
		public static void SetDrawingObjectCallback (HTuple drawHandle, HTuple drawObjectEvent, HTuple callbackFunction)
		{
			HOperatorSet.SetDrawingObjectCallback(drawHandle, drawObjectEvent, callbackFunction);
		}
		public static void DetachBackgroundFromWindow (HTuple windowHandle)
		{
			HOperatorSet.DetachBackgroundFromWindow(windowHandle);
		}
		public static void AttachBackgroundToWindow (HObject image, HTuple windowHandle)
		{
			HOperatorSet.AttachBackgroundToWindow(image, windowHandle);
		}
		public static void DetachDrawingObjectFromWindow (HTuple windowHandle, HTuple drawHandle)
		{
			HOperatorSet.DetachDrawingObjectFromWindow(windowHandle, drawHandle);
		}
		public static void AttachDrawingObjectToWindow (HTuple windowHandle, HTuple drawHandle)
		{
			HOperatorSet.AttachDrawingObjectToWindow(windowHandle, drawHandle);
		}
		public static void UpdateWindowPose (HTuple windowHandle, HTuple lastRow, HTuple lastCol, HTuple currentRow, HTuple currentCol, HTuple mode)
		{
			HOperatorSet.UpdateWindowPose(windowHandle, lastRow, lastCol, currentRow, currentCol, mode);
		}
		public static (HTuple imageRow, HTuple imageColumn, HTuple height) UnprojectCoordinates (HObject image, HTuple windowHandle, HTuple row, HTuple column)
		{
			HOperatorSet.UnprojectCoordinates(image, windowHandle, row, column, out HTuple imageRow, out HTuple imageColumn, out HTuple height);
			return (imageRow,imageColumn,height);
		}
		public static (HTuple OSWindowHandle, HTuple OSDisplayHandle) GetOsWindowHandle (HTuple windowHandle)
		{
			HOperatorSet.GetOsWindowHandle(windowHandle, out HTuple OSWindowHandle, out HTuple OSDisplayHandle);
			return (OSWindowHandle,OSDisplayHandle);
		}
		public static void SetWindowDc (HTuple windowHandle, HTuple WINHDC)
		{
			HOperatorSet.SetWindowDc(windowHandle, WINHDC);
		}
		public static HTuple NewExternWindow (HTuple WINHWnd, HTuple row, HTuple column, HTuple width, HTuple height)
		{
			HOperatorSet.NewExternWindow(WINHWnd, row, column, width, height, out HTuple windowHandle);
			return windowHandle;
		}
		public static void SlideImage (HTuple windowHandleSource1, HTuple windowHandleSource2, HTuple windowHandle)
		{
			HOperatorSet.SlideImage(windowHandleSource1, windowHandleSource2, windowHandle);
		}
		public static void SetWindowType (HTuple windowType)
		{
			HOperatorSet.SetWindowType(windowType);
		}
		public static void SetWindowExtents (HTuple windowHandle, HTuple row, HTuple column, HTuple width, HTuple height)
		{
			HOperatorSet.SetWindowExtents(windowHandle, row, column, width, height);
		}
		public static HTuple GetWindowAttr (HTuple attributeName)
		{
			HOperatorSet.GetWindowAttr(attributeName, out HTuple attributeValue);
			return attributeValue;
		}
		public static void SetWindowAttr (HTuple attributeName, HTuple attributeValue)
		{
			HOperatorSet.SetWindowAttr(attributeName, attributeValue);
		}
		public static HTuple QueryWindowType ()
		{
			HOperatorSet.QueryWindowType(out HTuple windowTypes);
			return windowTypes;
		}
		public static HTuple OpenWindow (HTuple row, HTuple column, HTuple width, HTuple height, HTuple fatherWindow, HTuple mode, HTuple machine)
		{
			HOperatorSet.OpenWindow(row, column, width, height, fatherWindow, mode, machine, out HTuple windowHandle);
			return windowHandle;
		}
		public static HTuple OpenTextwindow (HTuple row, HTuple column, HTuple width, HTuple height, HTuple borderWidth, HTuple borderColor, HTuple backgroundColor, HTuple fatherWindow, HTuple mode, HTuple machine)
		{
			HOperatorSet.OpenTextwindow(row, column, width, height, borderWidth, borderColor, backgroundColor, fatherWindow, mode, machine, out HTuple windowHandle);
			return windowHandle;
		}
		public static void MoveRectangle (HTuple windowHandle, HTuple row1, HTuple column1, HTuple row2, HTuple column2, HTuple destRow, HTuple destColumn)
		{
			HOperatorSet.MoveRectangle(windowHandle, row1, column1, row2, column2, destRow, destColumn);
		}
		public static HTuple GetWindowType (HTuple windowHandle)
		{
			HOperatorSet.GetWindowType(windowHandle, out HTuple windowType);
			return windowType;
		}
		public static (HTuple imageRed, HTuple imageGreen, HTuple imageBlue, HTuple width, HTuple height) GetWindowPointer3 (HTuple windowHandle)
		{
			HOperatorSet.GetWindowPointer3(windowHandle, out HTuple imageRed, out HTuple imageGreen, out HTuple imageBlue, out HTuple width, out HTuple height);
			return (imageRed,imageGreen,imageBlue,width,height);
		}
		public static (HTuple row, HTuple column, HTuple width, HTuple height) GetWindowExtents (HTuple windowHandle)
		{
			HOperatorSet.GetWindowExtents(windowHandle, out HTuple row, out HTuple column, out HTuple width, out HTuple height);
			return (row,column,width,height);
		}
		public static HObject DumpWindowImage (HTuple windowHandle)
		{
			HOperatorSet.DumpWindowImage(out HObject image, windowHandle);
			return image;
		}
		public static void DumpWindow (HTuple windowHandle, HTuple device, HTuple fileName)
		{
			HOperatorSet.DumpWindow(windowHandle, device, fileName);
		}
		public static void CopyRectangle (HTuple windowHandleSource, HTuple windowHandleDestination, HTuple row1, HTuple column1, HTuple row2, HTuple column2, HTuple destRow, HTuple destColumn)
		{
			HOperatorSet.CopyRectangle(windowHandleSource, windowHandleDestination, row1, column1, row2, column2, destRow, destColumn);
		}
		public static void CloseWindow (HTuple windowHandle)
		{
			HOperatorSet.CloseWindow(windowHandle);
		}
		public static void ClearWindow (HTuple windowHandle)
		{
			HOperatorSet.ClearWindow(windowHandle);
		}
		public static void ClearRectangle (HTuple windowHandle, HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.ClearRectangle(windowHandle, row1, column1, row2, column2);
		}
		public static void WriteString (HTuple windowHandle, HTuple stringVal)
		{
			HOperatorSet.WriteString(windowHandle, stringVal);
		}
		public static void SetTshape (HTuple windowHandle, HTuple textCursor)
		{
			HOperatorSet.SetTshape(windowHandle, textCursor);
		}
		public static void SetTposition (HTuple windowHandle, HTuple row, HTuple column)
		{
			HOperatorSet.SetTposition(windowHandle, row, column);
		}
		public static HTuple ReadString (HTuple windowHandle, HTuple inString, HTuple length)
		{
			HOperatorSet.ReadString(windowHandle, inString, length, out HTuple outString);
			return outString;
		}
		public static (HTuple charVal, HTuple code) ReadChar (HTuple windowHandle)
		{
			HOperatorSet.ReadChar(windowHandle, out HTuple charVal, out HTuple code);
			return (charVal,code);
		}
		public static void NewLine (HTuple windowHandle)
		{
			HOperatorSet.NewLine(windowHandle);
		}
		public static HTuple GetTshape (HTuple windowHandle)
		{
			HOperatorSet.GetTshape(windowHandle, out HTuple textCursor);
			return textCursor;
		}
		public static (HTuple row, HTuple column) GetTposition (HTuple windowHandle)
		{
			HOperatorSet.GetTposition(windowHandle, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static (HTuple maxAscent, HTuple maxDescent, HTuple maxWidth, HTuple maxHeight) GetFontExtents (HTuple windowHandle)
		{
			HOperatorSet.GetFontExtents(windowHandle, out HTuple maxAscent, out HTuple maxDescent, out HTuple maxWidth, out HTuple maxHeight);
			return (maxAscent,maxDescent,maxWidth,maxHeight);
		}
		public static (HTuple ascent, HTuple descent, HTuple width, HTuple height) GetStringExtents (HTuple windowHandle, HTuple values)
		{
			HOperatorSet.GetStringExtents(windowHandle, values, out HTuple ascent, out HTuple descent, out HTuple width, out HTuple height);
			return (ascent,descent,width,height);
		}
		public static HTuple QueryFont (HTuple windowHandle)
		{
			HOperatorSet.QueryFont(windowHandle, out HTuple font);
			return font;
		}
		public static HTuple QueryTshape (HTuple windowHandle)
		{
			HOperatorSet.QueryTshape(windowHandle, out HTuple textCursor);
			return textCursor;
		}
		public static void SetFont (HTuple windowHandle, HTuple font)
		{
			HOperatorSet.SetFont(windowHandle, font);
		}
		public static HTuple GetFont (HTuple windowHandle)
		{
			HOperatorSet.GetFont(windowHandle, out HTuple font);
			return font;
		}
		public static HTuple GetDisplayScene3dInfo (HTuple windowHandle, HTuple scene3D, HTuple row, HTuple column, HTuple information)
		{
			HOperatorSet.GetDisplayScene3dInfo(windowHandle, scene3D, row, column, information, out HTuple value);
			return value;
		}
		public static void SetScene3dToWorldPose (HTuple scene3D, HTuple toWorldPose)
		{
			HOperatorSet.SetScene3dToWorldPose(scene3D, toWorldPose);
		}
		public static void SetScene3dParam (HTuple scene3D, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetScene3dParam(scene3D, genParamName, genParamValue);
		}
		public static void SetScene3dLightParam (HTuple scene3D, HTuple lightIndex, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetScene3dLightParam(scene3D, lightIndex, genParamName, genParamValue);
		}
		public static void SetScene3dInstancePose (HTuple scene3D, HTuple instanceIndex, HTuple pose)
		{
			HOperatorSet.SetScene3dInstancePose(scene3D, instanceIndex, pose);
		}
		public static void SetScene3dInstanceParam (HTuple scene3D, HTuple instanceIndex, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetScene3dInstanceParam(scene3D, instanceIndex, genParamName, genParamValue);
		}
		public static void SetScene3dCameraPose (HTuple scene3D, HTuple cameraIndex, HTuple pose)
		{
			HOperatorSet.SetScene3dCameraPose(scene3D, cameraIndex, pose);
		}
		public static HObject RenderScene3d (HTuple scene3D, HTuple cameraIndex)
		{
			HOperatorSet.RenderScene3d(out HObject image, scene3D, cameraIndex);
			return image;
		}
		public static void RemoveScene3dLight (HTuple scene3D, HTuple lightIndex)
		{
			HOperatorSet.RemoveScene3dLight(scene3D, lightIndex);
		}
		public static void RemoveScene3dInstance (HTuple scene3D, HTuple instanceIndex)
		{
			HOperatorSet.RemoveScene3dInstance(scene3D, instanceIndex);
		}
		public static void RemoveScene3dCamera (HTuple scene3D, HTuple cameraIndex)
		{
			HOperatorSet.RemoveScene3dCamera(scene3D, cameraIndex);
		}
		public static void DisplayScene3d (HTuple windowHandle, HTuple scene3D, HTuple cameraIndex)
		{
			HOperatorSet.DisplayScene3d(windowHandle, scene3D, cameraIndex);
		}
		public static HTuple AddScene3dLight (HTuple scene3D, HTuple lightPosition, HTuple lightKind)
		{
			HOperatorSet.AddScene3dLight(scene3D, lightPosition, lightKind, out HTuple lightIndex);
			return lightIndex;
		}
		public static HTuple AddScene3dInstance (HTuple scene3D, HTuple objectModel3D, HTuple pose)
		{
			HOperatorSet.AddScene3dInstance(scene3D, objectModel3D, pose, out HTuple instanceIndex);
			return instanceIndex;
		}
		public static HTuple AddScene3dCamera (HTuple scene3D, HTuple cameraParam)
		{
			HOperatorSet.AddScene3dCamera(scene3D, cameraParam, out HTuple cameraIndex);
			return cameraIndex;
		}
		public static void ClearScene3d (HTuple scene3D)
		{
			HOperatorSet.ClearScene3d(scene3D);
		}
		public static HTuple CreateScene3d ()
		{
			HOperatorSet.CreateScene3d(out HTuple scene3D);
			return scene3D;
		}
		public static HTuple GetWindowParam (HTuple windowHandle, HTuple param)
		{
			HOperatorSet.GetWindowParam(windowHandle, param, out HTuple value);
			return value;
		}
		public static void SetWindowParam (HTuple windowHandle, HTuple param, HTuple value)
		{
			HOperatorSet.SetWindowParam(windowHandle, param, value);
		}
		public static void SetShape (HTuple windowHandle, HTuple shape)
		{
			HOperatorSet.SetShape(windowHandle, shape);
		}
		public static void SetRgb (HTuple windowHandle, HTuple red, HTuple green, HTuple blue)
		{
			HOperatorSet.SetRgb(windowHandle, red, green, blue);
		}
		public static void SetPixel (HTuple windowHandle, HTuple pixel)
		{
			HOperatorSet.SetPixel(windowHandle, pixel);
		}
		public static void SetPartStyle (HTuple windowHandle, HTuple style)
		{
			HOperatorSet.SetPartStyle(windowHandle, style);
		}
		public static void SetPart (HTuple windowHandle, HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.SetPart(windowHandle, row1, column1, row2, column2);
		}
		public static void SetPaint (HTuple windowHandle, HTuple mode)
		{
			HOperatorSet.SetPaint(windowHandle, mode);
		}
		public static void SetLineWidth (HTuple windowHandle, HTuple width)
		{
			HOperatorSet.SetLineWidth(windowHandle, width);
		}
		public static void SetLineStyle (HTuple windowHandle, HTuple style)
		{
			HOperatorSet.SetLineStyle(windowHandle, style);
		}
		public static void SetLineApprox (HTuple windowHandle, HTuple approximation)
		{
			HOperatorSet.SetLineApprox(windowHandle, approximation);
		}
		public static void SetInsert (HTuple windowHandle, HTuple mode)
		{
			HOperatorSet.SetInsert(windowHandle, mode);
		}
		public static void SetHsi (HTuple windowHandle, HTuple hue, HTuple saturation, HTuple intensity)
		{
			HOperatorSet.SetHsi(windowHandle, hue, saturation, intensity);
		}
		public static void SetGray (HTuple windowHandle, HTuple grayValues)
		{
			HOperatorSet.SetGray(windowHandle, grayValues);
		}
		public static void SetDraw (HTuple windowHandle, HTuple mode)
		{
			HOperatorSet.SetDraw(windowHandle, mode);
		}
		public static void SetComprise (HTuple windowHandle, HTuple mode)
		{
			HOperatorSet.SetComprise(windowHandle, mode);
		}
		public static void SetColored (HTuple windowHandle, HTuple numberOfColors)
		{
			HOperatorSet.SetColored(windowHandle, numberOfColors);
		}
		public static void SetColor (HTuple windowHandle, HTuple color)
		{
			HOperatorSet.SetColor(windowHandle, color);
		}
		public static HTuple GetShape (HTuple windowHandle)
		{
			HOperatorSet.GetShape(windowHandle, out HTuple displayShape);
			return displayShape;
		}
		public static (HTuple red, HTuple green, HTuple blue) GetRgb (HTuple windowHandle)
		{
			HOperatorSet.GetRgb(windowHandle, out HTuple red, out HTuple green, out HTuple blue);
			return (red,green,blue);
		}
		public static HTuple GetPixel (HTuple windowHandle)
		{
			HOperatorSet.GetPixel(windowHandle, out HTuple pixel);
			return pixel;
		}
		public static HTuple GetPartStyle (HTuple windowHandle)
		{
			HOperatorSet.GetPartStyle(windowHandle, out HTuple style);
			return style;
		}
		public static (HTuple row1, HTuple column1, HTuple row2, HTuple column2) GetPart (HTuple windowHandle)
		{
			HOperatorSet.GetPart(windowHandle, out HTuple row1, out HTuple column1, out HTuple row2, out HTuple column2);
			return (row1,column1,row2,column2);
		}
		public static HTuple GetPaint (HTuple windowHandle)
		{
			HOperatorSet.GetPaint(windowHandle, out HTuple mode);
			return mode;
		}
		public static HTuple GetLineWidth (HTuple windowHandle)
		{
			HOperatorSet.GetLineWidth(windowHandle, out HTuple width);
			return width;
		}
		public static HTuple GetLineStyle (HTuple windowHandle)
		{
			HOperatorSet.GetLineStyle(windowHandle, out HTuple style);
			return style;
		}
		public static HTuple GetLineApprox (HTuple windowHandle)
		{
			HOperatorSet.GetLineApprox(windowHandle, out HTuple approximation);
			return approximation;
		}
		public static HTuple GetInsert (HTuple windowHandle)
		{
			HOperatorSet.GetInsert(windowHandle, out HTuple mode);
			return mode;
		}
		public static (HTuple hue, HTuple saturation, HTuple intensity) GetHsi (HTuple windowHandle)
		{
			HOperatorSet.GetHsi(windowHandle, out HTuple hue, out HTuple saturation, out HTuple intensity);
			return (hue,saturation,intensity);
		}
		public static HTuple GetDraw (HTuple windowHandle)
		{
			HOperatorSet.GetDraw(windowHandle, out HTuple mode);
			return mode;
		}
		public static HTuple GetComprise (HTuple windowHandle)
		{
			HOperatorSet.GetComprise(windowHandle, out HTuple mode);
			return mode;
		}
		public static HTuple QueryShape ()
		{
			HOperatorSet.QueryShape(out HTuple displayShape);
			return displayShape;
		}
		public static HTuple QueryPaint (HTuple windowHandle)
		{
			HOperatorSet.QueryPaint(windowHandle, out HTuple mode);
			return mode;
		}
		public static (HTuple min, HTuple max) QueryLineWidth ()
		{
			HOperatorSet.QueryLineWidth(out HTuple min, out HTuple max);
			return (min,max);
		}
		public static HTuple QueryInsert (HTuple windowHandle)
		{
			HOperatorSet.QueryInsert(windowHandle, out HTuple mode);
			return mode;
		}
		public static HTuple QueryGray (HTuple windowHandle)
		{
			HOperatorSet.QueryGray(windowHandle, out HTuple grayval);
			return grayval;
		}
		public static HTuple QueryColored ()
		{
			HOperatorSet.QueryColored(out HTuple possibleNumberOfColors);
			return possibleNumberOfColors;
		}
		public static HTuple QueryAllColors (HTuple windowHandle)
		{
			HOperatorSet.QueryAllColors(windowHandle, out HTuple colors);
			return colors;
		}
		public static HTuple QueryColor (HTuple windowHandle)
		{
			HOperatorSet.QueryColor(windowHandle, out HTuple colors);
			return colors;
		}
		public static HObject GetIcon (HTuple windowHandle)
		{
			HOperatorSet.GetIcon(out HObject icon, windowHandle);
			return icon;
		}
		public static void SetIcon (HObject icon, HTuple windowHandle)
		{
			HOperatorSet.SetIcon(icon, windowHandle);
		}
		public static void DispRegion (HObject dispRegions, HTuple windowHandle)
		{
			HOperatorSet.DispRegion(dispRegions, windowHandle);
		}
		public static void DispRectangle2 (HTuple windowHandle, HTuple centerRow, HTuple centerCol, HTuple phi, HTuple length1, HTuple length2)
		{
			HOperatorSet.DispRectangle2(windowHandle, centerRow, centerCol, phi, length1, length2);
		}
		public static void DispRectangle1 (HTuple windowHandle, HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.DispRectangle1(windowHandle, row1, column1, row2, column2);
		}
		public static void DispPolygon (HTuple windowHandle, HTuple row, HTuple column)
		{
			HOperatorSet.DispPolygon(windowHandle, row, column);
		}
		public static void DispLine (HTuple windowHandle, HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.DispLine(windowHandle, row1, column1, row2, column2);
		}
		public static void DispCross (HTuple windowHandle, HTuple row, HTuple column, HTuple size, HTuple angle)
		{
			HOperatorSet.DispCross(windowHandle, row, column, size, angle);
		}
		public static void DispImage (HObject image, HTuple windowHandle)
		{
			HOperatorSet.DispImage(image, windowHandle);
		}
		public static void DispChannel (HObject multichannelImage, HTuple windowHandle, HTuple channel)
		{
			HOperatorSet.DispChannel(multichannelImage, windowHandle, channel);
		}
		public static void DispColor (HObject colorImage, HTuple windowHandle)
		{
			HOperatorSet.DispColor(colorImage, windowHandle);
		}
		public static void DispEllipse (HTuple windowHandle, HTuple centerRow, HTuple centerCol, HTuple phi, HTuple radius1, HTuple radius2)
		{
			HOperatorSet.DispEllipse(windowHandle, centerRow, centerCol, phi, radius1, radius2);
		}
		public static void DispDistribution (HTuple windowHandle, HTuple distribution, HTuple row, HTuple column, HTuple scale)
		{
			HOperatorSet.DispDistribution(windowHandle, distribution, row, column, scale);
		}
		public static void DispCircle (HTuple windowHandle, HTuple row, HTuple column, HTuple radius)
		{
			HOperatorSet.DispCircle(windowHandle, row, column, radius);
		}
		public static void DispArrow (HTuple windowHandle, HTuple row1, HTuple column1, HTuple row2, HTuple column2, HTuple size)
		{
			HOperatorSet.DispArrow(windowHandle, row1, column1, row2, column2, size);
		}
		public static void DispArc (HTuple windowHandle, HTuple centerRow, HTuple centerCol, HTuple angle, HTuple beginRow, HTuple beginCol)
		{
			HOperatorSet.DispArc(windowHandle, centerRow, centerCol, angle, beginRow, beginCol);
		}
		public static void DispObj (HObject objectVal, HTuple windowHandle)
		{
			HOperatorSet.DispObj(objectVal, windowHandle);
		}
		public static void SetMshape (HTuple windowHandle, HTuple cursor)
		{
			HOperatorSet.SetMshape(windowHandle, cursor);
		}
		public static HTuple GetMshape (HTuple windowHandle)
		{
			HOperatorSet.GetMshape(windowHandle, out HTuple cursor);
			return cursor;
		}
		public static HTuple QueryMshape (HTuple windowHandle)
		{
			HOperatorSet.QueryMshape(windowHandle, out HTuple shapeNames);
			return shapeNames;
		}
		public static HTuple ReadDeformableSurfaceModel (HTuple fileName)
		{
			HOperatorSet.ReadDeformableSurfaceModel(fileName, out HTuple deformableSurfaceModel);
			return deformableSurfaceModel;
		}
		public static void WriteDeformableSurfaceModel (HTuple deformableSurfaceModel, HTuple fileName)
		{
			HOperatorSet.WriteDeformableSurfaceModel(deformableSurfaceModel, fileName);
		}
		public static (HTuple score, HTuple deformableSurfaceMatchingResult) RefineDeformableSurfaceModel (HTuple deformableSurfaceModel, HTuple objectModel3D, HTuple relSamplingDistance, HTuple initialDeformationObjectModel3D, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.RefineDeformableSurfaceModel(deformableSurfaceModel, objectModel3D, relSamplingDistance, initialDeformationObjectModel3D, genParamName, genParamValue, out HTuple score, out HTuple deformableSurfaceMatchingResult);
			return (score,deformableSurfaceMatchingResult);
		}
		public static (HTuple score, HTuple deformableSurfaceMatchingResult) FindDeformableSurfaceModel (HTuple deformableSurfaceModel, HTuple objectModel3D, HTuple relSamplingDistance, HTuple minScore, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.FindDeformableSurfaceModel(deformableSurfaceModel, objectModel3D, relSamplingDistance, minScore, genParamName, genParamValue, out HTuple score, out HTuple deformableSurfaceMatchingResult);
			return (score,deformableSurfaceMatchingResult);
		}
		public static HTuple GetDeformableSurfaceModelParam (HTuple deformableSurfaceModel, HTuple genParamName)
		{
			HOperatorSet.GetDeformableSurfaceModelParam(deformableSurfaceModel, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static HTuple AddDeformableSurfaceModelReferencePoint (HTuple deformableSurfaceModel, HTuple referencePointX, HTuple referencePointY, HTuple referencePointZ)
		{
			HOperatorSet.AddDeformableSurfaceModelReferencePoint(deformableSurfaceModel, referencePointX, referencePointY, referencePointZ, out HTuple referencePointIndex);
			return referencePointIndex;
		}
		public static void AddDeformableSurfaceModelSample (HTuple deformableSurfaceModel, HTuple objectModel3D)
		{
			HOperatorSet.AddDeformableSurfaceModelSample(deformableSurfaceModel, objectModel3D);
		}
		public static HTuple CreateDeformableSurfaceModel (HTuple objectModel3D, HTuple relSamplingDistance, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateDeformableSurfaceModel(objectModel3D, relSamplingDistance, genParamName, genParamValue, out HTuple deformableSurfaceModel);
			return deformableSurfaceModel;
		}
		public static HTuple GetSurfaceMatchingResult (HTuple surfaceMatchingResultID, HTuple resultName, HTuple resultIndex)
		{
			HOperatorSet.GetSurfaceMatchingResult(surfaceMatchingResultID, resultName, resultIndex, out HTuple resultValue);
			return resultValue;
		}
		public static void ClearAllSurfaceMatchingResults ()
		{
			HOperatorSet.ClearAllSurfaceMatchingResults();
		}
		public static void ClearSurfaceMatchingResult (HTuple surfaceMatchingResultID)
		{
			HOperatorSet.ClearSurfaceMatchingResult(surfaceMatchingResultID);
		}
		public static void ClearAllSurfaceModels ()
		{
			HOperatorSet.ClearAllSurfaceModels();
		}
		public static void ClearSurfaceModel (HTuple surfaceModelID)
		{
			HOperatorSet.ClearSurfaceModel(surfaceModelID);
		}
		public static HTuple DeserializeSurfaceModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeSurfaceModel(serializedItemHandle, out HTuple surfaceModelID);
			return surfaceModelID;
		}
		public static HTuple SerializeSurfaceModel (HTuple surfaceModelID)
		{
			HOperatorSet.SerializeSurfaceModel(surfaceModelID, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadSurfaceModel (HTuple fileName)
		{
			HOperatorSet.ReadSurfaceModel(fileName, out HTuple surfaceModelID);
			return surfaceModelID;
		}
		public static void WriteSurfaceModel (HTuple surfaceModelID, HTuple fileName)
		{
			HOperatorSet.WriteSurfaceModel(surfaceModelID, fileName);
		}
		public static (HTuple pose, HTuple score, HTuple surfaceMatchingResultID) RefineSurfaceModelPose (HTuple surfaceModelID, HTuple objectModel3D, HTuple initialPose, HTuple minScore, HTuple returnResultHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.RefineSurfaceModelPose(surfaceModelID, objectModel3D, initialPose, minScore, returnResultHandle, genParamName, genParamValue, out HTuple pose, out HTuple score, out HTuple surfaceMatchingResultID);
			return (pose,score,surfaceMatchingResultID);
		}
		public static (HTuple pose, HTuple score, HTuple surfaceMatchingResultID) FindSurfaceModel (HTuple surfaceModelID, HTuple objectModel3D, HTuple relSamplingDistance, HTuple keyPointFraction, HTuple minScore, HTuple returnResultHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.FindSurfaceModel(surfaceModelID, objectModel3D, relSamplingDistance, keyPointFraction, minScore, returnResultHandle, genParamName, genParamValue, out HTuple pose, out HTuple score, out HTuple surfaceMatchingResultID);
			return (pose,score,surfaceMatchingResultID);
		}
		public static HTuple GetSurfaceModelParam (HTuple surfaceModelID, HTuple genParamName)
		{
			HOperatorSet.GetSurfaceModelParam(surfaceModelID, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static HTuple CreateSurfaceModel (HTuple objectModel3D, HTuple relSamplingDistance, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateSurfaceModel(objectModel3D, relSamplingDistance, genParamName, genParamValue, out HTuple surfaceModelID);
			return surfaceModelID;
		}
		public static HTuple CreateCamPoseLookAtPoint (HTuple camPosX, HTuple camPosY, HTuple camPosZ, HTuple lookAtX, HTuple lookAtY, HTuple lookAtZ, HTuple refPlaneNormal, HTuple camRoll)
		{
			HOperatorSet.CreateCamPoseLookAtPoint(camPosX, camPosY, camPosZ, lookAtX, lookAtY, lookAtZ, refPlaneNormal, camRoll, out HTuple camPose);
			return camPose;
		}
		public static (HTuple x, HTuple y, HTuple z) ConvertPoint3dSpherToCart (HTuple longitude, HTuple latitude, HTuple radius, HTuple equatPlaneNormal, HTuple zeroMeridian)
		{
			HOperatorSet.ConvertPoint3dSpherToCart(longitude, latitude, radius, equatPlaneNormal, zeroMeridian, out HTuple x, out HTuple y, out HTuple z);
			return (x,y,z);
		}
		public static (HTuple longitude, HTuple latitude, HTuple radius) ConvertPoint3dCartToSpher (HTuple x, HTuple y, HTuple z, HTuple equatPlaneNormal, HTuple zeroMeridian)
		{
			HOperatorSet.ConvertPoint3dCartToSpher(x, y, z, equatPlaneNormal, zeroMeridian, out HTuple longitude, out HTuple latitude, out HTuple radius);
			return (longitude,latitude,radius);
		}
		public static void ClearAllShapeModel3d ()
		{
			HOperatorSet.ClearAllShapeModel3d();
		}
		public static void ClearShapeModel3d (HTuple shapeModel3DID)
		{
			HOperatorSet.ClearShapeModel3d(shapeModel3DID);
		}
		public static HTuple DeserializeShapeModel3d (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeShapeModel3d(serializedItemHandle, out HTuple shapeModel3DID);
			return shapeModel3DID;
		}
		public static HTuple SerializeShapeModel3d (HTuple shapeModel3DID)
		{
			HOperatorSet.SerializeShapeModel3d(shapeModel3DID, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadShapeModel3d (HTuple fileName)
		{
			HOperatorSet.ReadShapeModel3d(fileName, out HTuple shapeModel3DID);
			return shapeModel3DID;
		}
		public static void WriteShapeModel3d (HTuple shapeModel3DID, HTuple fileName)
		{
			HOperatorSet.WriteShapeModel3d(shapeModel3DID, fileName);
		}
		public static HTuple TransPoseShapeModel3d (HTuple shapeModel3DID, HTuple poseIn, HTuple transformation)
		{
			HOperatorSet.TransPoseShapeModel3d(shapeModel3DID, poseIn, transformation, out HTuple poseOut);
			return poseOut;
		}
		public static HObject ProjectShapeModel3d (HTuple shapeModel3DID, HTuple camParam, HTuple pose, HTuple hiddenSurfaceRemoval, HTuple minFaceAngle)
		{
			HOperatorSet.ProjectShapeModel3d(out HObject modelContours, shapeModel3DID, camParam, pose, hiddenSurfaceRemoval, minFaceAngle);
			return modelContours;
		}
		public static (HObject modelContours, HTuple viewPose) GetShapeModel3dContours (HTuple shapeModel3DID, HTuple level, HTuple view)
		{
			HOperatorSet.GetShapeModel3dContours(out HObject modelContours, shapeModel3DID, level, view, out HTuple viewPose);
			return (modelContours,viewPose);
		}
		public static HTuple GetShapeModel3dParams (HTuple shapeModel3DID, HTuple genParamName)
		{
			HOperatorSet.GetShapeModel3dParams(shapeModel3DID, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static (HTuple pose, HTuple covPose, HTuple score) FindShapeModel3d (HObject image, HTuple shapeModel3DID, HTuple minScore, HTuple greediness, HTuple numLevels, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.FindShapeModel3d(image, shapeModel3DID, minScore, greediness, numLevels, genParamName, genParamValue, out HTuple pose, out HTuple covPose, out HTuple score);
			return (pose,covPose,score);
		}
		public static HTuple CreateShapeModel3d (HTuple objectModel3D, HTuple camParam, HTuple refRotX, HTuple refRotY, HTuple refRotZ, HTuple orderOfRotation, HTuple longitudeMin, HTuple longitudeMax, HTuple latitudeMin, HTuple latitudeMax, HTuple camRollMin, HTuple camRollMax, HTuple distMin, HTuple distMax, HTuple minContrast, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateShapeModel3d(objectModel3D, camParam, refRotX, refRotY, refRotZ, orderOfRotation, longitudeMin, longitudeMax, latitudeMin, latitudeMax, camRollMin, camRollMax, distMin, distMax, minContrast, genParamName, genParamValue, out HTuple shapeModel3DID);
			return shapeModel3DID;
		}
		public static HTuple SimplifyObjectModel3d (HTuple objectModel3D, HTuple method, HTuple amount, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SimplifyObjectModel3d(objectModel3D, method, amount, genParamName, genParamValue, out HTuple simplifiedObjectModel3D);
			return simplifiedObjectModel3D;
		}
		public static void DistanceObjectModel3d (HTuple objectModel3DFrom, HTuple objectModel3DTo, HTuple pose, HTuple maxDistance, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.DistanceObjectModel3d(objectModel3DFrom, objectModel3DTo, pose, maxDistance, genParamName, genParamValue);
		}
		public static HTuple UnionObjectModel3d (HTuple objectModels3D, HTuple method)
		{
			HOperatorSet.UnionObjectModel3d(objectModels3D, method, out HTuple unionObjectModel3D);
			return unionObjectModel3D;
		}
		public static void SetObjectModel3dAttribMod (HTuple objectModel3D, HTuple attribName, HTuple attachExtAttribTo, HTuple attribValues)
		{
			HOperatorSet.SetObjectModel3dAttribMod(objectModel3D, attribName, attachExtAttribTo, attribValues);
		}
		public static HTuple SetObjectModel3dAttrib (HTuple objectModel3D, HTuple attribName, HTuple attachExtAttribTo, HTuple attribValues)
		{
			HOperatorSet.SetObjectModel3dAttrib(objectModel3D, attribName, attachExtAttribTo, attribValues, out HTuple objectModel3DOut);
			return objectModel3DOut;
		}
		public static HTuple GenEmptyObjectModel3d ()
		{
			HOperatorSet.GenEmptyObjectModel3d(out HTuple emptyObjectModel3D);
			return emptyObjectModel3D;
		}
		public static HTuple SampleObjectModel3d (HTuple objectModel3D, HTuple method, HTuple sampleDistance, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SampleObjectModel3d(objectModel3D, method, sampleDistance, genParamName, genParamValue, out HTuple sampledObjectModel3D);
			return sampledObjectModel3D;
		}
		public static (HTuple homMats3DOut, HTuple scores) RegisterObjectModel3dGlobal (HTuple objectModels3D, HTuple homMats3D, HTuple from, HTuple to, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.RegisterObjectModel3dGlobal(objectModels3D, homMats3D, from, to, genParamName, genParamValue, out HTuple homMats3DOut, out HTuple scores);
			return (homMats3DOut,scores);
		}
		public static (HTuple pose, HTuple score) RegisterObjectModel3dPair (HTuple objectModel3D1, HTuple objectModel3D2, HTuple method, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.RegisterObjectModel3dPair(objectModel3D1, objectModel3D2, method, genParamName, genParamValue, out HTuple pose, out HTuple score);
			return (pose,score);
		}
		public static HTuple GenObjectModel3dFromPoints (HTuple x, HTuple y, HTuple z)
		{
			HOperatorSet.GenObjectModel3dFromPoints(x, y, z, out HTuple objectModel3D);
			return objectModel3D;
		}
		public static HTuple GenBoxObjectModel3d (HTuple pose, HTuple lengthX, HTuple lengthY, HTuple lengthZ)
		{
			HOperatorSet.GenBoxObjectModel3d(pose, lengthX, lengthY, lengthZ, out HTuple objectModel3D);
			return objectModel3D;
		}
		public static HTuple GenPlaneObjectModel3d (HTuple pose, HTuple XExtent, HTuple YExtent)
		{
			HOperatorSet.GenPlaneObjectModel3d(pose, XExtent, YExtent, out HTuple objectModel3D);
			return objectModel3D;
		}
		public static HTuple GenSphereObjectModel3dCenter (HTuple x, HTuple y, HTuple z, HTuple radius)
		{
			HOperatorSet.GenSphereObjectModel3dCenter(x, y, z, radius, out HTuple objectModel3D);
			return objectModel3D;
		}
		public static HTuple GenSphereObjectModel3d (HTuple pose, HTuple radius)
		{
			HOperatorSet.GenSphereObjectModel3d(pose, radius, out HTuple objectModel3D);
			return objectModel3D;
		}
		public static HTuple GenCylinderObjectModel3d (HTuple pose, HTuple radius, HTuple minExtent, HTuple maxExtent)
		{
			HOperatorSet.GenCylinderObjectModel3d(pose, radius, minExtent, maxExtent, out HTuple objectModel3D);
			return objectModel3D;
		}
		public static (HTuple pose, HTuple length1, HTuple length2, HTuple length3) SmallestBoundingBoxObjectModel3d (HTuple objectModel3D, HTuple type)
		{
			HOperatorSet.SmallestBoundingBoxObjectModel3d(objectModel3D, type, out HTuple pose, out HTuple length1, out HTuple length2, out HTuple length3);
			return (pose,length1,length2,length3);
		}
		public static (HTuple centerPoint, HTuple radius) SmallestSphereObjectModel3d (HTuple objectModel3D)
		{
			HOperatorSet.SmallestSphereObjectModel3d(objectModel3D, out HTuple centerPoint, out HTuple radius);
			return (centerPoint,radius);
		}
		public static HTuple IntersectPlaneObjectModel3d (HTuple objectModel3D, HTuple plane)
		{
			HOperatorSet.IntersectPlaneObjectModel3d(objectModel3D, plane, out HTuple objectModel3DIntersection);
			return objectModel3DIntersection;
		}
		public static HTuple ConvexHullObjectModel3d (HTuple objectModel3D)
		{
			HOperatorSet.ConvexHullObjectModel3d(objectModel3D, out HTuple objectModel3DConvexHull);
			return objectModel3DConvexHull;
		}
		public static HTuple SelectObjectModel3d (HTuple objectModel3D, HTuple feature, HTuple operation, HTuple minValue, HTuple maxValue)
		{
			HOperatorSet.SelectObjectModel3d(objectModel3D, feature, operation, minValue, maxValue, out HTuple objectModel3DSelected);
			return objectModel3DSelected;
		}
		public static HTuple AreaObjectModel3d (HTuple objectModel3D)
		{
			HOperatorSet.AreaObjectModel3d(objectModel3D, out HTuple area);
			return area;
		}
		public static HTuple MaxDiameterObjectModel3d (HTuple objectModel3D)
		{
			HOperatorSet.MaxDiameterObjectModel3d(objectModel3D, out HTuple diameter);
			return diameter;
		}
		public static HTuple MomentsObjectModel3d (HTuple objectModel3D, HTuple momentsToCalculate)
		{
			HOperatorSet.MomentsObjectModel3d(objectModel3D, momentsToCalculate, out HTuple moments);
			return moments;
		}
		public static HTuple VolumeObjectModel3dRelativeToPlane (HTuple objectModel3D, HTuple plane, HTuple mode, HTuple useFaceOrientation)
		{
			HOperatorSet.VolumeObjectModel3dRelativeToPlane(objectModel3D, plane, mode, useFaceOrientation, out HTuple volume);
			return volume;
		}
		public static HTuple ReduceObjectModel3dByView (HObject region, HTuple objectModel3D, HTuple camParam, HTuple pose)
		{
			HOperatorSet.ReduceObjectModel3dByView(region, objectModel3D, camParam, pose, out HTuple objectModel3DReduced);
			return objectModel3DReduced;
		}
		public static HTuple ConnectionObjectModel3d (HTuple objectModel3D, HTuple feature, HTuple value)
		{
			HOperatorSet.ConnectionObjectModel3d(objectModel3D, feature, value, out HTuple objectModel3DConnected);
			return objectModel3DConnected;
		}
		public static HTuple SelectPointsObjectModel3d (HTuple objectModel3D, HTuple attrib, HTuple minValue, HTuple maxValue)
		{
			HOperatorSet.SelectPointsObjectModel3d(objectModel3D, attrib, minValue, maxValue, out HTuple objectModel3DThresholded);
			return objectModel3DThresholded;
		}
		public static HTuple GetDispObjectModel3dInfo (HTuple windowHandle, HTuple row, HTuple column, HTuple information)
		{
			HOperatorSet.GetDispObjectModel3dInfo(windowHandle, row, column, information, out HTuple value);
			return value;
		}
		public static HObject RenderObjectModel3d (HTuple objectModel3D, HTuple camParam, HTuple pose, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.RenderObjectModel3d(out HObject image, objectModel3D, camParam, pose, genParamName, genParamValue);
			return image;
		}
		public static void DispObjectModel3d (HTuple windowHandle, HTuple objectModel3D, HTuple camParam, HTuple pose, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.DispObjectModel3d(windowHandle, objectModel3D, camParam, pose, genParamName, genParamValue);
		}
		public static HTuple CopyObjectModel3d (HTuple objectModel3D, HTuple attributes)
		{
			HOperatorSet.CopyObjectModel3d(objectModel3D, attributes, out HTuple copiedObjectModel3D);
			return copiedObjectModel3D;
		}
		public static void PrepareObjectModel3d (HTuple objectModel3D, HTuple purpose, HTuple overwriteData, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.PrepareObjectModel3d(objectModel3D, purpose, overwriteData, genParamName, genParamValue);
		}
		public static (HObject x, HObject y, HObject z) ObjectModel3dToXyz (HTuple objectModel3D, HTuple type, HTuple camParam, HTuple pose)
		{
			HOperatorSet.ObjectModel3dToXyz(out HObject x, out HObject y, out HObject z, objectModel3D, type, camParam, pose);
			return (x,y,z);
		}
		public static HTuple XyzToObjectModel3d (HObject x, HObject y, HObject z)
		{
			HOperatorSet.XyzToObjectModel3d(x, y, z, out HTuple objectModel3D);
			return objectModel3D;
		}
		public static HTuple GetObjectModel3dParams (HTuple objectModel3D, HTuple genParamName)
		{
			HOperatorSet.GetObjectModel3dParams(objectModel3D, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static HObject ProjectObjectModel3d (HTuple objectModel3D, HTuple camParam, HTuple pose, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.ProjectObjectModel3d(out HObject modelContours, objectModel3D, camParam, pose, genParamName, genParamValue);
			return modelContours;
		}
		public static HTuple RigidTransObjectModel3d (HTuple objectModel3D, HTuple pose)
		{
			HOperatorSet.RigidTransObjectModel3d(objectModel3D, pose, out HTuple objectModel3DRigidTrans);
			return objectModel3DRigidTrans;
		}
		public static HTuple ProjectiveTransObjectModel3d (HTuple objectModel3D, HTuple homMat3D)
		{
			HOperatorSet.ProjectiveTransObjectModel3d(objectModel3D, homMat3D, out HTuple objectModel3DProjectiveTrans);
			return objectModel3DProjectiveTrans;
		}
		public static HTuple AffineTransObjectModel3d (HTuple objectModel3D, HTuple homMat3D)
		{
			HOperatorSet.AffineTransObjectModel3d(objectModel3D, homMat3D, out HTuple objectModel3DAffineTrans);
			return objectModel3DAffineTrans;
		}
		public static void ClearAllObjectModel3d ()
		{
			HOperatorSet.ClearAllObjectModel3d();
		}
		public static void ClearObjectModel3d (HTuple objectModel3D)
		{
			HOperatorSet.ClearObjectModel3d(objectModel3D);
		}
		public static HTuple SerializeObjectModel3d (HTuple objectModel3D)
		{
			HOperatorSet.SerializeObjectModel3d(objectModel3D, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple DeserializeObjectModel3d (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeObjectModel3d(serializedItemHandle, out HTuple objectModel3D);
			return objectModel3D;
		}
		public static void WriteObjectModel3d (HTuple objectModel3D, HTuple fileType, HTuple fileName, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.WriteObjectModel3d(objectModel3D, fileType, fileName, genParamName, genParamValue);
		}
		public static (HTuple objectModel3D, HTuple status) ReadObjectModel3d (HTuple fileName, HTuple scale, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.ReadObjectModel3d(fileName, scale, genParamName, genParamValue, out HTuple objectModel3D, out HTuple status);
			return (objectModel3D,status);
		}
		public static (HTuple dimension, HTuple model, HTuple measurement, HTuple prediction) ReadKalman (HTuple fileName)
		{
			HOperatorSet.ReadKalman(fileName, out HTuple dimension, out HTuple model, out HTuple measurement, out HTuple prediction);
			return (dimension,model,measurement,prediction);
		}
		public static (HTuple dimensionOut, HTuple modelOut, HTuple measurementOut) UpdateKalman (HTuple fileName, HTuple dimensionIn, HTuple modelIn, HTuple measurementIn)
		{
			HOperatorSet.UpdateKalman(fileName, dimensionIn, modelIn, measurementIn, out HTuple dimensionOut, out HTuple modelOut, out HTuple measurementOut);
			return (dimensionOut,modelOut,measurementOut);
		}
		public static (HTuple predictionOut, HTuple estimate) FilterKalman (HTuple dimension, HTuple model, HTuple measurement, HTuple predictionIn)
		{
			HOperatorSet.FilterKalman(dimension, model, measurement, predictionIn, out HTuple predictionOut, out HTuple estimate);
			return (predictionOut,estimate);
		}
		public static HTuple QueryOperatorInfo ()
		{
			HOperatorSet.QueryOperatorInfo(out HTuple slots);
			return slots;
		}
		public static HTuple QueryParamInfo ()
		{
			HOperatorSet.QueryParamInfo(out HTuple slots);
			return slots;
		}
		public static HTuple GetOperatorName (HTuple pattern)
		{
			HOperatorSet.GetOperatorName(pattern, out HTuple operatorNames);
			return operatorNames;
		}
		public static (HTuple inpCtrlParType, HTuple outpCtrlParType) GetParamTypes (HTuple operatorName)
		{
			HOperatorSet.GetParamTypes(operatorName, out HTuple inpCtrlParType, out HTuple outpCtrlParType);
			return (inpCtrlParType,outpCtrlParType);
		}
		public static (HTuple CName, HTuple inpObjPar, HTuple outpObjPar, HTuple inpCtrlPar, HTuple outpCtrlPar, HTuple type) GetParamNum (HTuple operatorName)
		{
			HOperatorSet.GetParamNum(operatorName, out HTuple CName, out HTuple inpObjPar, out HTuple outpObjPar, out HTuple inpCtrlPar, out HTuple outpCtrlPar, out HTuple type);
			return (CName,inpObjPar,outpObjPar,inpCtrlPar,outpCtrlPar,type);
		}
		public static (HTuple inpObjPar, HTuple outpObjPar, HTuple inpCtrlPar, HTuple outpCtrlPar) GetParamNames (HTuple operatorName)
		{
			HOperatorSet.GetParamNames(operatorName, out HTuple inpObjPar, out HTuple outpObjPar, out HTuple inpCtrlPar, out HTuple outpCtrlPar);
			return (inpObjPar,outpObjPar,inpCtrlPar,outpCtrlPar);
		}
		public static HTuple GetOperatorInfo (HTuple operatorName, HTuple slot)
		{
			HOperatorSet.GetOperatorInfo(operatorName, slot, out HTuple information);
			return information;
		}
		public static HTuple GetParamInfo (HTuple operatorName, HTuple paramName, HTuple slot)
		{
			HOperatorSet.GetParamInfo(operatorName, paramName, slot, out HTuple information);
			return information;
		}
		public static HTuple SearchOperator (HTuple keyword)
		{
			HOperatorSet.SearchOperator(keyword, out HTuple operatorNames);
			return operatorNames;
		}
		public static HTuple GetKeywords (HTuple operatorName)
		{
			HOperatorSet.GetKeywords(operatorName, out HTuple keywords);
			return keywords;
		}
		public static HTuple GetChapterInfo (HTuple chapter)
		{
			HOperatorSet.GetChapterInfo(chapter, out HTuple info);
			return info;
		}
		public static HObject ChannelsToImage (HObject images)
		{
			HOperatorSet.ChannelsToImage(images, out HObject multiChannelImage);
			return multiChannelImage;
		}
		public static HObject ImageToChannels (HObject multiChannelImage)
		{
			HOperatorSet.ImageToChannels(multiChannelImage, out HObject images);
			return images;
		}
		public static HObject Compose7 (HObject image1, HObject image2, HObject image3, HObject image4, HObject image5, HObject image6, HObject image7)
		{
			HOperatorSet.Compose7(image1, image2, image3, image4, image5, image6, image7, out HObject multiChannelImage);
			return multiChannelImage;
		}
		public static HObject Compose6 (HObject image1, HObject image2, HObject image3, HObject image4, HObject image5, HObject image6)
		{
			HOperatorSet.Compose6(image1, image2, image3, image4, image5, image6, out HObject multiChannelImage);
			return multiChannelImage;
		}
		public static HObject Compose5 (HObject image1, HObject image2, HObject image3, HObject image4, HObject image5)
		{
			HOperatorSet.Compose5(image1, image2, image3, image4, image5, out HObject multiChannelImage);
			return multiChannelImage;
		}
		public static HObject Compose4 (HObject image1, HObject image2, HObject image3, HObject image4)
		{
			HOperatorSet.Compose4(image1, image2, image3, image4, out HObject multiChannelImage);
			return multiChannelImage;
		}
		public static HObject Compose3 (HObject image1, HObject image2, HObject image3)
		{
			HOperatorSet.Compose3(image1, image2, image3, out HObject multiChannelImage);
			return multiChannelImage;
		}
		public static HObject Compose2 (HObject image1, HObject image2)
		{
			HOperatorSet.Compose2(image1, image2, out HObject multiChannelImage);
			return multiChannelImage;
		}
		public static (HObject image1, HObject image2, HObject image3, HObject image4, HObject image5, HObject image6, HObject image7) Decompose7 (HObject multiChannelImage)
		{
			HOperatorSet.Decompose7(multiChannelImage, out HObject image1, out HObject image2, out HObject image3, out HObject image4, out HObject image5, out HObject image6, out HObject image7);
			return (image1,image2,image3,image4,image5,image6,image7);
		}
		public static (HObject image1, HObject image2, HObject image3, HObject image4, HObject image5, HObject image6) Decompose6 (HObject multiChannelImage)
		{
			HOperatorSet.Decompose6(multiChannelImage, out HObject image1, out HObject image2, out HObject image3, out HObject image4, out HObject image5, out HObject image6);
			return (image1,image2,image3,image4,image5,image6);
		}
		public static (HObject image1, HObject image2, HObject image3, HObject image4, HObject image5) Decompose5 (HObject multiChannelImage)
		{
			HOperatorSet.Decompose5(multiChannelImage, out HObject image1, out HObject image2, out HObject image3, out HObject image4, out HObject image5);
			return (image1,image2,image3,image4,image5);
		}
		public static (HObject image1, HObject image2, HObject image3, HObject image4) Decompose4 (HObject multiChannelImage)
		{
			HOperatorSet.Decompose4(multiChannelImage, out HObject image1, out HObject image2, out HObject image3, out HObject image4);
			return (image1,image2,image3,image4);
		}
		public static (HObject image1, HObject image2, HObject image3) Decompose3 (HObject multiChannelImage)
		{
			HOperatorSet.Decompose3(multiChannelImage, out HObject image1, out HObject image2, out HObject image3);
			return (image1,image2,image3);
		}
		public static (HObject image1, HObject image2) Decompose2 (HObject multiChannelImage)
		{
			HOperatorSet.Decompose2(multiChannelImage, out HObject image1, out HObject image2);
			return (image1,image2);
		}
		public static HTuple CountChannels (HObject multiChannelImage)
		{
			HOperatorSet.CountChannels(multiChannelImage, out HTuple channels);
			return channels;
		}
		public static HObject AppendChannel (HObject multiChannelImage, HObject image)
		{
			HOperatorSet.AppendChannel(multiChannelImage, image, out HObject imageExtended);
			return imageExtended;
		}
		public static HObject AccessChannel (HObject multiChannelImage, HTuple channel)
		{
			HOperatorSet.AccessChannel(multiChannelImage, out HObject image, channel);
			return image;
		}
		public static HObject TileImagesOffset (HObject images, HTuple offsetRow, HTuple offsetCol, HTuple row1, HTuple col1, HTuple row2, HTuple col2, HTuple width, HTuple height)
		{
			HOperatorSet.TileImagesOffset(images, out HObject tiledImage, offsetRow, offsetCol, row1, col1, row2, col2, width, height);
			return tiledImage;
		}
		public static HObject TileImages (HObject images, HTuple numColumns, HTuple tileOrder)
		{
			HOperatorSet.TileImages(images, out HObject tiledImage, numColumns, tileOrder);
			return tiledImage;
		}
		public static HObject TileChannels (HObject image, HTuple numColumns, HTuple tileOrder)
		{
			HOperatorSet.TileChannels(image, out HObject tiledImage, numColumns, tileOrder);
			return tiledImage;
		}
		public static HObject CropDomain (HObject image)
		{
			HOperatorSet.CropDomain(image, out HObject imagePart);
			return imagePart;
		}
		public static HObject CropRectangle1 (HObject image, HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.CropRectangle1(image, out HObject imagePart, row1, column1, row2, column2);
			return imagePart;
		}
		public static HObject CropPart (HObject image, HTuple row, HTuple column, HTuple width, HTuple height)
		{
			HOperatorSet.CropPart(image, out HObject imagePart, row, column, width, height);
			return imagePart;
		}
		public static HObject ChangeFormat (HObject image, HTuple width, HTuple height)
		{
			HOperatorSet.ChangeFormat(image, out HObject imagePart, width, height);
			return imagePart;
		}
		public static HObject ChangeDomain (HObject image, HObject newDomain)
		{
			HOperatorSet.ChangeDomain(image, newDomain, out HObject imageNew);
			return imageNew;
		}
		public static HObject AddChannels (HObject regions, HObject image)
		{
			HOperatorSet.AddChannels(regions, image, out HObject grayRegions);
			return grayRegions;
		}
		public static HObject Rectangle1Domain (HObject image, HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.Rectangle1Domain(image, out HObject imageReduced, row1, column1, row2, column2);
			return imageReduced;
		}
		public static HObject ReduceDomain (HObject image, HObject region)
		{
			HOperatorSet.ReduceDomain(image, region, out HObject imageReduced);
			return imageReduced;
		}
		public static HObject FullDomain (HObject image)
		{
			HOperatorSet.FullDomain(image, out HObject imageFull);
			return imageFull;
		}
		public static HObject GetDomain (HObject image)
		{
			HOperatorSet.GetDomain(image, out HObject domain);
			return domain;
		}
		public static HObject HoughCircles (HObject regionIn, HTuple radius, HTuple percent, HTuple mode)
		{
			HOperatorSet.HoughCircles(regionIn, out HObject regionOut, radius, percent, mode);
			return regionOut;
		}
		public static HObject HoughCircleTrans (HObject region, HTuple radius)
		{
			HOperatorSet.HoughCircleTrans(region, out HObject houghImage, radius);
			return houghImage;
		}
		public static (HObject houghImage, HObject lines, HTuple angle, HTuple dist) HoughLinesDir (HObject imageDir, HTuple directionUncertainty, HTuple angleResolution, HTuple smoothing, HTuple filterSize, HTuple threshold, HTuple angleGap, HTuple distGap, HTuple genLines)
		{
			HOperatorSet.HoughLinesDir(imageDir, out HObject houghImage, out HObject lines, directionUncertainty, angleResolution, smoothing, filterSize, threshold, angleGap, distGap, genLines, out HTuple angle, out HTuple dist);
			return (houghImage,lines,angle,dist);
		}
		public static void ClearMatrix (HTuple matrixID)
		{
			HOperatorSet.ClearMatrix(matrixID);
		}
		public static HTuple CreateMatrix (HTuple rows, HTuple columns, HTuple value)
		{
			HOperatorSet.CreateMatrix(rows, columns, value, out HTuple matrixID);
			return matrixID;
		}
		public static void ClearAllSampleIdentifiers ()
		{
			HOperatorSet.ClearAllSampleIdentifiers();
		}
		public static void ClearSampleIdentifier (HTuple sampleIdentifier)
		{
			HOperatorSet.ClearSampleIdentifier(sampleIdentifier);
		}
		public static HTuple DeserializeSampleIdentifier (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeSampleIdentifier(serializedItemHandle, out HTuple sampleIdentifier);
			return sampleIdentifier;
		}
		public static HTuple ReadSampleIdentifier (HTuple fileName)
		{
			HOperatorSet.ReadSampleIdentifier(fileName, out HTuple sampleIdentifier);
			return sampleIdentifier;
		}
		public static HTuple SerializeSampleIdentifier (HTuple sampleIdentifier)
		{
			HOperatorSet.SerializeSampleIdentifier(sampleIdentifier, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static void WriteSampleIdentifier (HTuple sampleIdentifier, HTuple fileName)
		{
			HOperatorSet.WriteSampleIdentifier(sampleIdentifier, fileName);
		}
		public static (HTuple objectIdx, HTuple rating) ApplySampleIdentifier (HObject image, HTuple sampleIdentifier, HTuple numResults, HTuple ratingThreshold, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.ApplySampleIdentifier(image, sampleIdentifier, numResults, ratingThreshold, genParamName, genParamValue, out HTuple objectIdx, out HTuple rating);
			return (objectIdx,rating);
		}
		public static HTuple GetSampleIdentifierParam (HTuple sampleIdentifier, HTuple genParamName)
		{
			HOperatorSet.GetSampleIdentifierParam(sampleIdentifier, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetSampleIdentifierParam (HTuple sampleIdentifier, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetSampleIdentifierParam(sampleIdentifier, genParamName, genParamValue);
		}
		public static HTuple GetSampleIdentifierObjectInfo (HTuple sampleIdentifier, HTuple objectIdx, HTuple infoName)
		{
			HOperatorSet.GetSampleIdentifierObjectInfo(sampleIdentifier, objectIdx, infoName, out HTuple infoValue);
			return infoValue;
		}
		public static void SetSampleIdentifierObjectInfo (HTuple sampleIdentifier, HTuple objectIdx, HTuple infoName, HTuple infoValue)
		{
			HOperatorSet.SetSampleIdentifierObjectInfo(sampleIdentifier, objectIdx, infoName, infoValue);
		}
		public static void RemoveSampleIdentifierTrainingData (HTuple sampleIdentifier, HTuple objectIdx, HTuple objectSampleIdx)
		{
			HOperatorSet.RemoveSampleIdentifierTrainingData(sampleIdentifier, objectIdx, objectSampleIdx);
		}
		public static void RemoveSampleIdentifierPreparationData (HTuple sampleIdentifier, HTuple objectIdx, HTuple objectSampleIdx)
		{
			HOperatorSet.RemoveSampleIdentifierPreparationData(sampleIdentifier, objectIdx, objectSampleIdx);
		}
		public static void TrainSampleIdentifier (HTuple sampleIdentifier, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.TrainSampleIdentifier(sampleIdentifier, genParamName, genParamValue);
		}
		public static HTuple AddSampleIdentifierTrainingData (HObject sampleImage, HTuple sampleIdentifier, HTuple objectIdx, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.AddSampleIdentifierTrainingData(sampleImage, sampleIdentifier, objectIdx, genParamName, genParamValue, out HTuple objectSampleIdx);
			return objectSampleIdx;
		}
		public static void PrepareSampleIdentifier (HTuple sampleIdentifier, HTuple removePreparationData, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.PrepareSampleIdentifier(sampleIdentifier, removePreparationData, genParamName, genParamValue);
		}
		public static HTuple AddSampleIdentifierPreparationData (HObject sampleImage, HTuple sampleIdentifier, HTuple objectIdx, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.AddSampleIdentifierPreparationData(sampleImage, sampleIdentifier, objectIdx, genParamName, genParamValue, out HTuple objectSampleIdx);
			return objectSampleIdx;
		}
		public static HTuple CreateSampleIdentifier (HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateSampleIdentifier(genParamName, genParamValue, out HTuple sampleIdentifier);
			return sampleIdentifier;
		}
		public static HTuple DeserializeShapeModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeShapeModel(serializedItemHandle, out HTuple modelID);
			return modelID;
		}
		public static HTuple ReadShapeModel (HTuple fileName)
		{
			HOperatorSet.ReadShapeModel(fileName, out HTuple modelID);
			return modelID;
		}
		public static HTuple SerializeShapeModel (HTuple modelID)
		{
			HOperatorSet.SerializeShapeModel(modelID, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static void WriteShapeModel (HTuple modelID, HTuple fileName)
		{
			HOperatorSet.WriteShapeModel(modelID, fileName);
		}
		public static void ClearAllShapeModels ()
		{
			HOperatorSet.ClearAllShapeModels();
		}
		public static void ClearShapeModel (HTuple modelID)
		{
			HOperatorSet.ClearShapeModel(modelID);
		}
		public static HObject GetShapeModelContours (HTuple modelID, HTuple level)
		{
			HOperatorSet.GetShapeModelContours(out HObject modelContours, modelID, level);
			return modelContours;
		}
		public static (HTuple parameterName, HTuple parameterValue) DetermineShapeModelParams (HObject template, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple scaleMin, HTuple scaleMax, HTuple optimization, HTuple metric, HTuple contrast, HTuple minContrast, HTuple parameters)
		{
			HOperatorSet.DetermineShapeModelParams(template, numLevels, angleStart, angleExtent, scaleMin, scaleMax, optimization, metric, contrast, minContrast, parameters, out HTuple parameterName, out HTuple parameterValue);
			return (parameterName,parameterValue);
		}
		public static (HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple angleStep, HTuple scaleMin, HTuple scaleMax, HTuple scaleStep, HTuple metric, HTuple minContrast) GetShapeModelParams (HTuple modelID)
		{
			HOperatorSet.GetShapeModelParams(modelID, out HTuple numLevels, out HTuple angleStart, out HTuple angleExtent, out HTuple angleStep, out HTuple scaleMin, out HTuple scaleMax, out HTuple scaleStep, out HTuple metric, out HTuple minContrast);
			return (numLevels,angleStart,angleExtent,angleStep,scaleMin,scaleMax,scaleStep,metric,minContrast);
		}
		public static (HTuple row, HTuple column) GetShapeModelOrigin (HTuple modelID)
		{
			HOperatorSet.GetShapeModelOrigin(modelID, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static void SetShapeModelOrigin (HTuple modelID, HTuple row, HTuple column)
		{
			HOperatorSet.SetShapeModelOrigin(modelID, row, column);
		}
		public static (HTuple row, HTuple column, HTuple angle, HTuple scaleR, HTuple scaleC, HTuple score, HTuple model) FindAnisoShapeModels (HObject image, HTuple modelIDs, HTuple angleStart, HTuple angleExtent, HTuple scaleRMin, HTuple scaleRMax, HTuple scaleCMin, HTuple scaleCMax, HTuple minScore, HTuple numMatches, HTuple maxOverlap, HTuple subPixel, HTuple numLevels, HTuple greediness)
		{
			HOperatorSet.FindAnisoShapeModels(image, modelIDs, angleStart, angleExtent, scaleRMin, scaleRMax, scaleCMin, scaleCMax, minScore, numMatches, maxOverlap, subPixel, numLevels, greediness, out HTuple row, out HTuple column, out HTuple angle, out HTuple scaleR, out HTuple scaleC, out HTuple score, out HTuple model);
			return (row,column,angle,scaleR,scaleC,score,model);
		}
		public static (HTuple row, HTuple column, HTuple angle, HTuple scale, HTuple score, HTuple model) FindScaledShapeModels (HObject image, HTuple modelIDs, HTuple angleStart, HTuple angleExtent, HTuple scaleMin, HTuple scaleMax, HTuple minScore, HTuple numMatches, HTuple maxOverlap, HTuple subPixel, HTuple numLevels, HTuple greediness)
		{
			HOperatorSet.FindScaledShapeModels(image, modelIDs, angleStart, angleExtent, scaleMin, scaleMax, minScore, numMatches, maxOverlap, subPixel, numLevels, greediness, out HTuple row, out HTuple column, out HTuple angle, out HTuple scale, out HTuple score, out HTuple model);
			return (row,column,angle,scale,score,model);
		}
		public static (HTuple row, HTuple column, HTuple angle, HTuple score, HTuple model) FindShapeModels (HObject image, HTuple modelIDs, HTuple angleStart, HTuple angleExtent, HTuple minScore, HTuple numMatches, HTuple maxOverlap, HTuple subPixel, HTuple numLevels, HTuple greediness)
		{
			HOperatorSet.FindShapeModels(image, modelIDs, angleStart, angleExtent, minScore, numMatches, maxOverlap, subPixel, numLevels, greediness, out HTuple row, out HTuple column, out HTuple angle, out HTuple score, out HTuple model);
			return (row,column,angle,score,model);
		}
		public static (HTuple row, HTuple column, HTuple angle, HTuple scaleR, HTuple scaleC, HTuple score) FindAnisoShapeModel (HObject image, HTuple modelID, HTuple angleStart, HTuple angleExtent, HTuple scaleRMin, HTuple scaleRMax, HTuple scaleCMin, HTuple scaleCMax, HTuple minScore, HTuple numMatches, HTuple maxOverlap, HTuple subPixel, HTuple numLevels, HTuple greediness)
		{
			HOperatorSet.FindAnisoShapeModel(image, modelID, angleStart, angleExtent, scaleRMin, scaleRMax, scaleCMin, scaleCMax, minScore, numMatches, maxOverlap, subPixel, numLevels, greediness, out HTuple row, out HTuple column, out HTuple angle, out HTuple scaleR, out HTuple scaleC, out HTuple score);
			return (row,column,angle,scaleR,scaleC,score);
		}
		public static (HTuple row, HTuple column, HTuple angle, HTuple scale, HTuple score) FindScaledShapeModel (HObject image, HTuple modelID, HTuple angleStart, HTuple angleExtent, HTuple scaleMin, HTuple scaleMax, HTuple minScore, HTuple numMatches, HTuple maxOverlap, HTuple subPixel, HTuple numLevels, HTuple greediness)
		{
			HOperatorSet.FindScaledShapeModel(image, modelID, angleStart, angleExtent, scaleMin, scaleMax, minScore, numMatches, maxOverlap, subPixel, numLevels, greediness, out HTuple row, out HTuple column, out HTuple angle, out HTuple scale, out HTuple score);
			return (row,column,angle,scale,score);
		}
		public static (HTuple row, HTuple column, HTuple angle, HTuple score) FindShapeModel (HObject image, HTuple modelID, HTuple angleStart, HTuple angleExtent, HTuple minScore, HTuple numMatches, HTuple maxOverlap, HTuple subPixel, HTuple numLevels, HTuple greediness)
		{
			HOperatorSet.FindShapeModel(image, modelID, angleStart, angleExtent, minScore, numMatches, maxOverlap, subPixel, numLevels, greediness, out HTuple row, out HTuple column, out HTuple angle, out HTuple score);
			return (row,column,angle,score);
		}
		public static void SetShapeModelMetric (HObject image, HTuple modelID, HTuple homMat2D, HTuple metric)
		{
			HOperatorSet.SetShapeModelMetric(image, modelID, homMat2D, metric);
		}
		public static void SetShapeModelParam (HTuple modelID, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetShapeModelParam(modelID, genParamName, genParamValue);
		}
		public static HTuple CreateAnisoShapeModelXld (HObject contours, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple angleStep, HTuple scaleRMin, HTuple scaleRMax, HTuple scaleRStep, HTuple scaleCMin, HTuple scaleCMax, HTuple scaleCStep, HTuple optimization, HTuple metric, HTuple minContrast)
		{
			HOperatorSet.CreateAnisoShapeModelXld(contours, numLevels, angleStart, angleExtent, angleStep, scaleRMin, scaleRMax, scaleRStep, scaleCMin, scaleCMax, scaleCStep, optimization, metric, minContrast, out HTuple modelID);
			return modelID;
		}
		public static HTuple CreateScaledShapeModelXld (HObject contours, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple angleStep, HTuple scaleMin, HTuple scaleMax, HTuple scaleStep, HTuple optimization, HTuple metric, HTuple minContrast)
		{
			HOperatorSet.CreateScaledShapeModelXld(contours, numLevels, angleStart, angleExtent, angleStep, scaleMin, scaleMax, scaleStep, optimization, metric, minContrast, out HTuple modelID);
			return modelID;
		}
		public static HTuple CreateShapeModelXld (HObject contours, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple angleStep, HTuple optimization, HTuple metric, HTuple minContrast)
		{
			HOperatorSet.CreateShapeModelXld(contours, numLevels, angleStart, angleExtent, angleStep, optimization, metric, minContrast, out HTuple modelID);
			return modelID;
		}
		public static HTuple CreateAnisoShapeModel (HObject template, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple angleStep, HTuple scaleRMin, HTuple scaleRMax, HTuple scaleRStep, HTuple scaleCMin, HTuple scaleCMax, HTuple scaleCStep, HTuple optimization, HTuple metric, HTuple contrast, HTuple minContrast)
		{
			HOperatorSet.CreateAnisoShapeModel(template, numLevels, angleStart, angleExtent, angleStep, scaleRMin, scaleRMax, scaleRStep, scaleCMin, scaleCMax, scaleCStep, optimization, metric, contrast, minContrast, out HTuple modelID);
			return modelID;
		}
		public static HTuple CreateScaledShapeModel (HObject template, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple angleStep, HTuple scaleMin, HTuple scaleMax, HTuple scaleStep, HTuple optimization, HTuple metric, HTuple contrast, HTuple minContrast)
		{
			HOperatorSet.CreateScaledShapeModel(template, numLevels, angleStart, angleExtent, angleStep, scaleMin, scaleMax, scaleStep, optimization, metric, contrast, minContrast, out HTuple modelID);
			return modelID;
		}
		public static HTuple CreateShapeModel (HObject template, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple angleStep, HTuple optimization, HTuple metric, HTuple contrast, HTuple minContrast)
		{
			HOperatorSet.CreateShapeModel(template, numLevels, angleStart, angleExtent, angleStep, optimization, metric, contrast, minContrast, out HTuple modelID);
			return modelID;
		}
		public static (HObject modelImages, HObject modelRegions) InspectShapeModel (HObject image, HTuple numLevels, HTuple contrast)
		{
			HOperatorSet.InspectShapeModel(image, out HObject modelImages, out HObject modelRegions, numLevels, contrast);
			return (modelImages,modelRegions);
		}
		public static void ClearAllDescriptorModels ()
		{
			HOperatorSet.ClearAllDescriptorModels();
		}
		public static void ClearDescriptorModel (HTuple modelID)
		{
			HOperatorSet.ClearDescriptorModel(modelID);
		}
		public static HTuple DeserializeDescriptorModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeDescriptorModel(serializedItemHandle, out HTuple modelID);
			return modelID;
		}
		public static HTuple SerializeDescriptorModel (HTuple modelID)
		{
			HOperatorSet.SerializeDescriptorModel(modelID, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadDescriptorModel (HTuple fileName)
		{
			HOperatorSet.ReadDescriptorModel(fileName, out HTuple modelID);
			return modelID;
		}
		public static void WriteDescriptorModel (HTuple modelID, HTuple fileName)
		{
			HOperatorSet.WriteDescriptorModel(modelID, fileName);
		}
		public static (HTuple pose, HTuple score) FindCalibDescriptorModel (HObject image, HTuple modelID, HTuple detectorParamName, HTuple detectorParamValue, HTuple descriptorParamName, HTuple descriptorParamValue, HTuple minScore, HTuple numMatches, HTuple camParam, HTuple scoreType)
		{
			HOperatorSet.FindCalibDescriptorModel(image, modelID, detectorParamName, detectorParamValue, descriptorParamName, descriptorParamValue, minScore, numMatches, camParam, scoreType, out HTuple pose, out HTuple score);
			return (pose,score);
		}
		public static (HTuple homMat2D, HTuple score) FindUncalibDescriptorModel (HObject image, HTuple modelID, HTuple detectorParamName, HTuple detectorParamValue, HTuple descriptorParamName, HTuple descriptorParamValue, HTuple minScore, HTuple numMatches, HTuple scoreType)
		{
			HOperatorSet.FindUncalibDescriptorModel(image, modelID, detectorParamName, detectorParamValue, descriptorParamName, descriptorParamValue, minScore, numMatches, scoreType, out HTuple homMat2D, out HTuple score);
			return (homMat2D,score);
		}
		public static (HTuple row, HTuple column) GetDescriptorModelPoints (HTuple modelID, HTuple set, HTuple subset)
		{
			HOperatorSet.GetDescriptorModelPoints(modelID, set, subset, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static (HTuple detectorType, HTuple detectorParamName, HTuple detectorParamValue, HTuple descriptorParamName, HTuple descriptorParamValue) GetDescriptorModelParams (HTuple modelID)
		{
			HOperatorSet.GetDescriptorModelParams(modelID, out HTuple detectorType, out HTuple detectorParamName, out HTuple detectorParamValue, out HTuple descriptorParamName, out HTuple descriptorParamValue);
			return (detectorType,detectorParamName,detectorParamValue,descriptorParamName,descriptorParamValue);
		}
		public static HTuple CreateCalibDescriptorModel (HObject template, HTuple camParam, HTuple referencePose, HTuple detectorType, HTuple detectorParamName, HTuple detectorParamValue, HTuple descriptorParamName, HTuple descriptorParamValue, HTuple seed)
		{
			HOperatorSet.CreateCalibDescriptorModel(template, camParam, referencePose, detectorType, detectorParamName, detectorParamValue, descriptorParamName, descriptorParamValue, seed, out HTuple modelID);
			return modelID;
		}
		public static HTuple CreateUncalibDescriptorModel (HObject template, HTuple detectorType, HTuple detectorParamName, HTuple detectorParamValue, HTuple descriptorParamName, HTuple descriptorParamValue, HTuple seed)
		{
			HOperatorSet.CreateUncalibDescriptorModel(template, detectorType, detectorParamName, detectorParamValue, descriptorParamName, descriptorParamValue, seed, out HTuple modelID);
			return modelID;
		}
		public static HTuple GetDescriptorModelResults (HTuple modelID, HTuple objectID, HTuple resultNames)
		{
			HOperatorSet.GetDescriptorModelResults(modelID, objectID, resultNames, out HTuple results);
			return results;
		}
		public static (HTuple row, HTuple column) GetDescriptorModelOrigin (HTuple modelID)
		{
			HOperatorSet.GetDescriptorModelOrigin(modelID, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static void SetDescriptorModelOrigin (HTuple modelID, HTuple row, HTuple column)
		{
			HOperatorSet.SetDescriptorModelOrigin(modelID, row, column);
		}
		public static (HTuple row, HTuple column) GetDeformableModelOrigin (HTuple modelID)
		{
			HOperatorSet.GetDeformableModelOrigin(modelID, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static void SetDeformableModelOrigin (HTuple modelID, HTuple row, HTuple column)
		{
			HOperatorSet.SetDeformableModelOrigin(modelID, row, column);
		}
		public static void SetDeformableModelParam (HTuple modelID, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetDeformableModelParam(modelID, genParamName, genParamValue);
		}
		public static HTuple GetDeformableModelParams (HTuple modelID, HTuple genParamName)
		{
			HOperatorSet.GetDeformableModelParams(modelID, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static HObject GetDeformableModelContours (HTuple modelID, HTuple level)
		{
			HOperatorSet.GetDeformableModelContours(out HObject modelContours, modelID, level);
			return modelContours;
		}
		public static (HTuple parameterName, HTuple parameterValue) DetermineDeformableModelParams (HObject template, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple scaleMin, HTuple scaleMax, HTuple optimization, HTuple metric, HTuple contrast, HTuple minContrast, HTuple genParamName, HTuple genParamValue, HTuple parameters)
		{
			HOperatorSet.DetermineDeformableModelParams(template, numLevels, angleStart, angleExtent, scaleMin, scaleMax, optimization, metric, contrast, minContrast, genParamName, genParamValue, parameters, out HTuple parameterName, out HTuple parameterValue);
			return (parameterName,parameterValue);
		}
		public static HTuple DeserializeDeformableModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeDeformableModel(serializedItemHandle, out HTuple modelID);
			return modelID;
		}
		public static HTuple SerializeDeformableModel (HTuple modelID)
		{
			HOperatorSet.SerializeDeformableModel(modelID, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadDeformableModel (HTuple fileName)
		{
			HOperatorSet.ReadDeformableModel(fileName, out HTuple modelID);
			return modelID;
		}
		public static void WriteDeformableModel (HTuple modelID, HTuple fileName)
		{
			HOperatorSet.WriteDeformableModel(modelID, fileName);
		}
		public static void ClearAllDeformableModels ()
		{
			HOperatorSet.ClearAllDeformableModels();
		}
		public static void ClearDeformableModel (HTuple modelID)
		{
			HOperatorSet.ClearDeformableModel(modelID);
		}
		public static (HObject imageRectified, HObject vectorField, HObject deformedContours, HTuple score, HTuple row, HTuple column) FindLocalDeformableModel (HObject image, HTuple modelID, HTuple angleStart, HTuple angleExtent, HTuple scaleRMin, HTuple scaleRMax, HTuple scaleCMin, HTuple scaleCMax, HTuple minScore, HTuple numMatches, HTuple maxOverlap, HTuple numLevels, HTuple greediness, HTuple resultType, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.FindLocalDeformableModel(image, out HObject imageRectified, out HObject vectorField, out HObject deformedContours, modelID, angleStart, angleExtent, scaleRMin, scaleRMax, scaleCMin, scaleCMax, minScore, numMatches, maxOverlap, numLevels, greediness, resultType, genParamName, genParamValue, out HTuple score, out HTuple row, out HTuple column);
			return (imageRectified,vectorField,deformedContours,score,row,column);
		}
		public static (HTuple pose, HTuple covPose, HTuple score) FindPlanarCalibDeformableModel (HObject image, HTuple modelID, HTuple angleStart, HTuple angleExtent, HTuple scaleRMin, HTuple scaleRMax, HTuple scaleCMin, HTuple scaleCMax, HTuple minScore, HTuple numMatches, HTuple maxOverlap, HTuple numLevels, HTuple greediness, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.FindPlanarCalibDeformableModel(image, modelID, angleStart, angleExtent, scaleRMin, scaleRMax, scaleCMin, scaleCMax, minScore, numMatches, maxOverlap, numLevels, greediness, genParamName, genParamValue, out HTuple pose, out HTuple covPose, out HTuple score);
			return (pose,covPose,score);
		}
		public static (HTuple homMat2D, HTuple score) FindPlanarUncalibDeformableModel (HObject image, HTuple modelID, HTuple angleStart, HTuple angleExtent, HTuple scaleRMin, HTuple scaleRMax, HTuple scaleCMin, HTuple scaleCMax, HTuple minScore, HTuple numMatches, HTuple maxOverlap, HTuple numLevels, HTuple greediness, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.FindPlanarUncalibDeformableModel(image, modelID, angleStart, angleExtent, scaleRMin, scaleRMax, scaleCMin, scaleCMax, minScore, numMatches, maxOverlap, numLevels, greediness, genParamName, genParamValue, out HTuple homMat2D, out HTuple score);
			return (homMat2D,score);
		}
		public static void SetLocalDeformableModelMetric (HObject image, HObject vectorField, HTuple modelID, HTuple metric)
		{
			HOperatorSet.SetLocalDeformableModelMetric(image, vectorField, modelID, metric);
		}
		public static void SetPlanarCalibDeformableModelMetric (HObject image, HTuple modelID, HTuple pose, HTuple metric)
		{
			HOperatorSet.SetPlanarCalibDeformableModelMetric(image, modelID, pose, metric);
		}
		public static void SetPlanarUncalibDeformableModelMetric (HObject image, HTuple modelID, HTuple homMat2D, HTuple metric)
		{
			HOperatorSet.SetPlanarUncalibDeformableModelMetric(image, modelID, homMat2D, metric);
		}
		public static HTuple CreateLocalDeformableModelXld (HObject contours, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple angleStep, HTuple scaleRMin, HTuple scaleRMax, HTuple scaleRStep, HTuple scaleCMin, HTuple scaleCMax, HTuple scaleCStep, HTuple optimization, HTuple metric, HTuple minContrast, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateLocalDeformableModelXld(contours, numLevels, angleStart, angleExtent, angleStep, scaleRMin, scaleRMax, scaleRStep, scaleCMin, scaleCMax, scaleCStep, optimization, metric, minContrast, genParamName, genParamValue, out HTuple modelID);
			return modelID;
		}
		public static HTuple CreatePlanarCalibDeformableModelXld (HObject contours, HTuple camParam, HTuple referencePose, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple angleStep, HTuple scaleRMin, HTuple scaleRMax, HTuple scaleRStep, HTuple scaleCMin, HTuple scaleCMax, HTuple scaleCStep, HTuple optimization, HTuple metric, HTuple minContrast, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreatePlanarCalibDeformableModelXld(contours, camParam, referencePose, numLevels, angleStart, angleExtent, angleStep, scaleRMin, scaleRMax, scaleRStep, scaleCMin, scaleCMax, scaleCStep, optimization, metric, minContrast, genParamName, genParamValue, out HTuple modelID);
			return modelID;
		}
		public static HTuple CreatePlanarUncalibDeformableModelXld (HObject contours, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple angleStep, HTuple scaleRMin, HTuple scaleRMax, HTuple scaleRStep, HTuple scaleCMin, HTuple scaleCMax, HTuple scaleCStep, HTuple optimization, HTuple metric, HTuple minContrast, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreatePlanarUncalibDeformableModelXld(contours, numLevels, angleStart, angleExtent, angleStep, scaleRMin, scaleRMax, scaleRStep, scaleCMin, scaleCMax, scaleCStep, optimization, metric, minContrast, genParamName, genParamValue, out HTuple modelID);
			return modelID;
		}
		public static HTuple CreateLocalDeformableModel (HObject template, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple angleStep, HTuple scaleRMin, HTuple scaleRMax, HTuple scaleRStep, HTuple scaleCMin, HTuple scaleCMax, HTuple scaleCStep, HTuple optimization, HTuple metric, HTuple contrast, HTuple minContrast, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateLocalDeformableModel(template, numLevels, angleStart, angleExtent, angleStep, scaleRMin, scaleRMax, scaleRStep, scaleCMin, scaleCMax, scaleCStep, optimization, metric, contrast, minContrast, genParamName, genParamValue, out HTuple modelID);
			return modelID;
		}
		public static HTuple CreatePlanarCalibDeformableModel (HObject template, HTuple camParam, HTuple referencePose, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple angleStep, HTuple scaleRMin, HTuple scaleRMax, HTuple scaleRStep, HTuple scaleCMin, HTuple scaleCMax, HTuple scaleCStep, HTuple optimization, HTuple metric, HTuple contrast, HTuple minContrast, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreatePlanarCalibDeformableModel(template, camParam, referencePose, numLevels, angleStart, angleExtent, angleStep, scaleRMin, scaleRMax, scaleRStep, scaleCMin, scaleCMax, scaleCStep, optimization, metric, contrast, minContrast, genParamName, genParamValue, out HTuple modelID);
			return modelID;
		}
		public static HTuple CreatePlanarUncalibDeformableModel (HObject template, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple angleStep, HTuple scaleRMin, HTuple scaleRMax, HTuple scaleRStep, HTuple scaleCMin, HTuple scaleCMax, HTuple scaleCStep, HTuple optimization, HTuple metric, HTuple contrast, HTuple minContrast, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreatePlanarUncalibDeformableModel(template, numLevels, angleStart, angleExtent, angleStep, scaleRMin, scaleRMax, scaleRStep, scaleCMin, scaleCMax, scaleCStep, optimization, metric, contrast, minContrast, genParamName, genParamValue, out HTuple modelID);
			return modelID;
		}
		public static void ClearAllNccModels ()
		{
			HOperatorSet.ClearAllNccModels();
		}
		public static void ClearNccModel (HTuple modelID)
		{
			HOperatorSet.ClearNccModel(modelID);
		}
		public static HTuple DeserializeNccModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeNccModel(serializedItemHandle, out HTuple modelID);
			return modelID;
		}
		public static HTuple SerializeNccModel (HTuple modelID)
		{
			HOperatorSet.SerializeNccModel(modelID, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadNccModel (HTuple fileName)
		{
			HOperatorSet.ReadNccModel(fileName, out HTuple modelID);
			return modelID;
		}
		public static void WriteNccModel (HTuple modelID, HTuple fileName)
		{
			HOperatorSet.WriteNccModel(modelID, fileName);
		}
		public static (HTuple parameterName, HTuple parameterValue) DetermineNccModelParams (HObject template, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple metric, HTuple parameters)
		{
			HOperatorSet.DetermineNccModelParams(template, numLevels, angleStart, angleExtent, metric, parameters, out HTuple parameterName, out HTuple parameterValue);
			return (parameterName,parameterValue);
		}
		public static (HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple angleStep, HTuple metric) GetNccModelParams (HTuple modelID)
		{
			HOperatorSet.GetNccModelParams(modelID, out HTuple numLevels, out HTuple angleStart, out HTuple angleExtent, out HTuple angleStep, out HTuple metric);
			return (numLevels,angleStart,angleExtent,angleStep,metric);
		}
		public static (HTuple row, HTuple column) GetNccModelOrigin (HTuple modelID)
		{
			HOperatorSet.GetNccModelOrigin(modelID, out HTuple row, out HTuple column);
			return (row,column);
		}
		public static void SetNccModelOrigin (HTuple modelID, HTuple row, HTuple column)
		{
			HOperatorSet.SetNccModelOrigin(modelID, row, column);
		}
		public static (HTuple row, HTuple column, HTuple angle, HTuple score) FindNccModel (HObject image, HTuple modelID, HTuple angleStart, HTuple angleExtent, HTuple minScore, HTuple numMatches, HTuple maxOverlap, HTuple subPixel, HTuple numLevels)
		{
			HOperatorSet.FindNccModel(image, modelID, angleStart, angleExtent, minScore, numMatches, maxOverlap, subPixel, numLevels, out HTuple row, out HTuple column, out HTuple angle, out HTuple score);
			return (row,column,angle,score);
		}
		public static void SetNccModelParam (HTuple modelID, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetNccModelParam(modelID, genParamName, genParamValue);
		}
		public static HTuple CreateNccModel (HObject template, HTuple numLevels, HTuple angleStart, HTuple angleExtent, HTuple angleStep, HTuple metric)
		{
			HOperatorSet.CreateNccModel(template, numLevels, angleStart, angleExtent, angleStep, metric, out HTuple modelID);
			return modelID;
		}
		public static (HObject foundComponents, HTuple rowCompInst, HTuple columnCompInst, HTuple angleCompInst, HTuple scoreCompInst) GetFoundComponentModel (HTuple componentModelID, HTuple modelStart, HTuple modelEnd, HTuple rowComp, HTuple columnComp, HTuple angleComp, HTuple scoreComp, HTuple modelComp, HTuple modelMatch, HTuple markOrientation)
		{
			HOperatorSet.GetFoundComponentModel(out HObject foundComponents, componentModelID, modelStart, modelEnd, rowComp, columnComp, angleComp, scoreComp, modelComp, modelMatch, markOrientation, out HTuple rowCompInst, out HTuple columnCompInst, out HTuple angleCompInst, out HTuple scoreCompInst);
			return (foundComponents,rowCompInst,columnCompInst,angleCompInst,scoreCompInst);
		}
		public static (HTuple modelStart, HTuple modelEnd, HTuple score, HTuple rowComp, HTuple columnComp, HTuple angleComp, HTuple scoreComp, HTuple modelComp) FindComponentModel (HObject image, HTuple componentModelID, HTuple rootComponent, HTuple angleStartRoot, HTuple angleExtentRoot, HTuple minScore, HTuple numMatches, HTuple maxOverlap, HTuple ifRootNotFound, HTuple ifComponentNotFound, HTuple posePrediction, HTuple minScoreComp, HTuple subPixelComp, HTuple numLevelsComp, HTuple greedinessComp)
		{
			HOperatorSet.FindComponentModel(image, componentModelID, rootComponent, angleStartRoot, angleExtentRoot, minScore, numMatches, maxOverlap, ifRootNotFound, ifComponentNotFound, posePrediction, minScoreComp, subPixelComp, numLevelsComp, greedinessComp, out HTuple modelStart, out HTuple modelEnd, out HTuple score, out HTuple rowComp, out HTuple columnComp, out HTuple angleComp, out HTuple scoreComp, out HTuple modelComp);
			return (modelStart,modelEnd,score,rowComp,columnComp,angleComp,scoreComp,modelComp);
		}
		public static void ClearAllComponentModels ()
		{
			HOperatorSet.ClearAllComponentModels();
		}
		public static void ClearComponentModel (HTuple componentModelID)
		{
			HOperatorSet.ClearComponentModel(componentModelID);
		}
		public static (HObject tree, HObject relations, HTuple startNode, HTuple endNode, HTuple row, HTuple column, HTuple phi, HTuple length1, HTuple length2, HTuple angleStart, HTuple angleExtent) GetComponentModelTree (HTuple componentModelID, HTuple rootComponent, HTuple image)
		{
			HOperatorSet.GetComponentModelTree(out HObject tree, out HObject relations, componentModelID, rootComponent, image, out HTuple startNode, out HTuple endNode, out HTuple row, out HTuple column, out HTuple phi, out HTuple length1, out HTuple length2, out HTuple angleStart, out HTuple angleExtent);
			return (tree,relations,startNode,endNode,row,column,phi,length1,length2,angleStart,angleExtent);
		}
		public static (HTuple minScoreComp, HTuple rootRanking, HTuple shapeModelIDs) GetComponentModelParams (HTuple componentModelID)
		{
			HOperatorSet.GetComponentModelParams(componentModelID, out HTuple minScoreComp, out HTuple rootRanking, out HTuple shapeModelIDs);
			return (minScoreComp,rootRanking,shapeModelIDs);
		}
		public static HTuple DeserializeComponentModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeComponentModel(serializedItemHandle, out HTuple componentModelID);
			return componentModelID;
		}
		public static HTuple SerializeComponentModel (HTuple componentModelID)
		{
			HOperatorSet.SerializeComponentModel(componentModelID, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadComponentModel (HTuple fileName)
		{
			HOperatorSet.ReadComponentModel(fileName, out HTuple componentModelID);
			return componentModelID;
		}
		public static void WriteComponentModel (HTuple componentModelID, HTuple fileName)
		{
			HOperatorSet.WriteComponentModel(componentModelID, fileName);
		}
		public static (HTuple componentModelID, HTuple rootRanking) CreateComponentModel (HObject modelImage, HObject componentRegions, HTuple variationRow, HTuple variationColumn, HTuple variationAngle, HTuple angleStart, HTuple angleExtent, HTuple contrastLowComp, HTuple contrastHighComp, HTuple minSizeComp, HTuple minContrastComp, HTuple minScoreComp, HTuple numLevelsComp, HTuple angleStepComp, HTuple optimizationComp, HTuple metricComp, HTuple pregenerationComp)
		{
			HOperatorSet.CreateComponentModel(modelImage, componentRegions, variationRow, variationColumn, variationAngle, angleStart, angleExtent, contrastLowComp, contrastHighComp, minSizeComp, minContrastComp, minScoreComp, numLevelsComp, angleStepComp, optimizationComp, metricComp, pregenerationComp, out HTuple componentModelID, out HTuple rootRanking);
			return (componentModelID,rootRanking);
		}
		public static (HTuple componentModelID, HTuple rootRanking) CreateTrainedComponentModel (HTuple componentTrainingID, HTuple angleStart, HTuple angleExtent, HTuple minContrastComp, HTuple minScoreComp, HTuple numLevelsComp, HTuple angleStepComp, HTuple optimizationComp, HTuple metricComp, HTuple pregenerationComp)
		{
			HOperatorSet.CreateTrainedComponentModel(componentTrainingID, angleStart, angleExtent, minContrastComp, minScoreComp, numLevelsComp, angleStepComp, optimizationComp, metricComp, pregenerationComp, out HTuple componentModelID, out HTuple rootRanking);
			return (componentModelID,rootRanking);
		}
		public static void ClearAllTrainingComponents ()
		{
			HOperatorSet.ClearAllTrainingComponents();
		}
		public static void ClearTrainingComponents (HTuple componentTrainingID)
		{
			HOperatorSet.ClearTrainingComponents(componentTrainingID);
		}
		public static (HObject relations, HTuple row, HTuple column, HTuple phi, HTuple length1, HTuple length2, HTuple angleStart, HTuple angleExtent) GetComponentRelations (HTuple componentTrainingID, HTuple referenceComponent, HTuple image)
		{
			HOperatorSet.GetComponentRelations(out HObject relations, componentTrainingID, referenceComponent, image, out HTuple row, out HTuple column, out HTuple phi, out HTuple length1, out HTuple length2, out HTuple angleStart, out HTuple angleExtent);
			return (relations,row,column,phi,length1,length2,angleStart,angleExtent);
		}
		public static (HObject trainingComponents, HTuple row, HTuple column, HTuple angle, HTuple score) GetTrainingComponents (HTuple componentTrainingID, HTuple components, HTuple image, HTuple markOrientation)
		{
			HOperatorSet.GetTrainingComponents(out HObject trainingComponents, componentTrainingID, components, image, markOrientation, out HTuple row, out HTuple column, out HTuple angle, out HTuple score);
			return (trainingComponents,row,column,angle,score);
		}
		public static void ModifyComponentRelations (HTuple componentTrainingID, HTuple referenceComponent, HTuple toleranceComponent, HTuple positionTolerance, HTuple angleTolerance)
		{
			HOperatorSet.ModifyComponentRelations(componentTrainingID, referenceComponent, toleranceComponent, positionTolerance, angleTolerance);
		}
		public static HTuple DeserializeTrainingComponents (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeTrainingComponents(serializedItemHandle, out HTuple componentTrainingID);
			return componentTrainingID;
		}
		public static HTuple SerializeTrainingComponents (HTuple componentTrainingID)
		{
			HOperatorSet.SerializeTrainingComponents(componentTrainingID, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadTrainingComponents (HTuple fileName)
		{
			HOperatorSet.ReadTrainingComponents(fileName, out HTuple componentTrainingID);
			return componentTrainingID;
		}
		public static void WriteTrainingComponents (HTuple componentTrainingID, HTuple fileName)
		{
			HOperatorSet.WriteTrainingComponents(componentTrainingID, fileName);
		}
		public static HObject ClusterModelComponents (HObject trainingImages, HTuple componentTrainingID, HTuple ambiguityCriterion, HTuple maxContourOverlap, HTuple clusterThreshold)
		{
			HOperatorSet.ClusterModelComponents(trainingImages, out HObject modelComponents, componentTrainingID, ambiguityCriterion, maxContourOverlap, clusterThreshold);
			return modelComponents;
		}
		public static HObject InspectClusteredComponents (HTuple componentTrainingID, HTuple ambiguityCriterion, HTuple maxContourOverlap, HTuple clusterThreshold)
		{
			HOperatorSet.InspectClusteredComponents(out HObject modelComponents, componentTrainingID, ambiguityCriterion, maxContourOverlap, clusterThreshold);
			return modelComponents;
		}
		public static (HObject modelComponents, HTuple componentTrainingID) TrainModelComponents (HObject modelImage, HObject initialComponents, HObject trainingImages, HTuple contrastLow, HTuple contrastHigh, HTuple minSize, HTuple minScore, HTuple searchRowTol, HTuple searchColumnTol, HTuple searchAngleTol, HTuple trainingEmphasis, HTuple ambiguityCriterion, HTuple maxContourOverlap, HTuple clusterThreshold)
		{
			HOperatorSet.TrainModelComponents(modelImage, initialComponents, trainingImages, out HObject modelComponents, contrastLow, contrastHigh, minSize, minScore, searchRowTol, searchColumnTol, searchAngleTol, trainingEmphasis, ambiguityCriterion, maxContourOverlap, clusterThreshold, out HTuple componentTrainingID);
			return (modelComponents,componentTrainingID);
		}
		public static HObject GenInitialComponents (HObject modelImage, HTuple contrastLow, HTuple contrastHigh, HTuple minSize, HTuple mode, HTuple genericName, HTuple genericValue)
		{
			HOperatorSet.GenInitialComponents(modelImage, out HObject initialComponents, contrastLow, contrastHigh, minSize, mode, genericName, genericValue);
			return initialComponents;
		}
		public static HTuple GetDeformableSurfaceMatchingResult (HTuple deformableSurfaceMatchingResult, HTuple resultName, HTuple resultIndex)
		{
			HOperatorSet.GetDeformableSurfaceMatchingResult(deformableSurfaceMatchingResult, resultName, resultIndex, out HTuple resultValue);
			return resultValue;
		}
		public static void ClearDeformableSurfaceMatchingResult (HTuple deformableSurfaceMatchingResult)
		{
			HOperatorSet.ClearDeformableSurfaceMatchingResult(deformableSurfaceMatchingResult);
		}
		public static void ClearDeformableSurfaceModel (HTuple deformableSurfaceModel)
		{
			HOperatorSet.ClearDeformableSurfaceModel(deformableSurfaceModel);
		}
		public static HTuple DeserializeDeformableSurfaceModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeDeformableSurfaceModel(serializedItemHandle, out HTuple deformableSurfaceModel);
			return deformableSurfaceModel;
		}
		public static HTuple SerializeDeformableSurfaceModel (HTuple deformableSurfaceModel)
		{
			HOperatorSet.SerializeDeformableSurfaceModel(deformableSurfaceModel, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HObject ErosionSeq (HObject region, HTuple golayElement, HTuple iterations)
		{
			HOperatorSet.ErosionSeq(region, out HObject regionErosion, golayElement, iterations);
			return regionErosion;
		}
		public static HObject ErosionGolay (HObject region, HTuple golayElement, HTuple iterations, HTuple rotation)
		{
			HOperatorSet.ErosionGolay(region, out HObject regionErosion, golayElement, iterations, rotation);
			return regionErosion;
		}
		public static HObject ErosionRectangle1 (HObject region, HTuple width, HTuple height)
		{
			HOperatorSet.ErosionRectangle1(region, out HObject regionErosion, width, height);
			return regionErosion;
		}
		public static HObject ErosionCircle (HObject region, HTuple radius)
		{
			HOperatorSet.ErosionCircle(region, out HObject regionErosion, radius);
			return regionErosion;
		}
		public static HObject Erosion2 (HObject region, HObject structElement, HTuple row, HTuple column, HTuple iterations)
		{
			HOperatorSet.Erosion2(region, structElement, out HObject regionErosion, row, column, iterations);
			return regionErosion;
		}
		public static HObject Erosion1 (HObject region, HObject structElement, HTuple iterations)
		{
			HOperatorSet.Erosion1(region, structElement, out HObject regionErosion, iterations);
			return regionErosion;
		}
		public static HObject DilationSeq (HObject region, HTuple golayElement, HTuple iterations)
		{
			HOperatorSet.DilationSeq(region, out HObject regionDilation, golayElement, iterations);
			return regionDilation;
		}
		public static HObject DilationGolay (HObject region, HTuple golayElement, HTuple iterations, HTuple rotation)
		{
			HOperatorSet.DilationGolay(region, out HObject regionDilation, golayElement, iterations, rotation);
			return regionDilation;
		}
		public static HObject DilationRectangle1 (HObject region, HTuple width, HTuple height)
		{
			HOperatorSet.DilationRectangle1(region, out HObject regionDilation, width, height);
			return regionDilation;
		}
		public static HObject DilationCircle (HObject region, HTuple radius)
		{
			HOperatorSet.DilationCircle(region, out HObject regionDilation, radius);
			return regionDilation;
		}
		public static HObject Dilation2 (HObject region, HObject structElement, HTuple row, HTuple column, HTuple iterations)
		{
			HOperatorSet.Dilation2(region, structElement, out HObject regionDilation, row, column, iterations);
			return regionDilation;
		}
		public static HObject Dilation1 (HObject region, HObject structElement, HTuple iterations)
		{
			HOperatorSet.Dilation1(region, structElement, out HObject regionDilation, iterations);
			return regionDilation;
		}
		public static HObject GrayBothat (HObject image, HObject SE)
		{
			HOperatorSet.GrayBothat(image, SE, out HObject imageBotHat);
			return imageBotHat;
		}
		public static HObject GrayTophat (HObject image, HObject SE)
		{
			HOperatorSet.GrayTophat(image, SE, out HObject imageTopHat);
			return imageTopHat;
		}
		public static HObject GrayClosing (HObject image, HObject SE)
		{
			HOperatorSet.GrayClosing(image, SE, out HObject imageClosing);
			return imageClosing;
		}
		public static HObject GrayOpening (HObject image, HObject SE)
		{
			HOperatorSet.GrayOpening(image, SE, out HObject imageOpening);
			return imageOpening;
		}
		public static HObject GrayDilation (HObject image, HObject SE)
		{
			HOperatorSet.GrayDilation(image, SE, out HObject imageDilation);
			return imageDilation;
		}
		public static HObject GrayErosion (HObject image, HObject SE)
		{
			HOperatorSet.GrayErosion(image, SE, out HObject imageErosion);
			return imageErosion;
		}
		public static HObject ReadGraySe (HTuple fileName)
		{
			HOperatorSet.ReadGraySe(out HObject SE, fileName);
			return SE;
		}
		public static HObject GenDiscSe (HTuple type, HTuple width, HTuple height, HTuple smax)
		{
			HOperatorSet.GenDiscSe(out HObject SE, type, width, height, smax);
			return SE;
		}
		public static HObject GetMetrologyObjectModelContour (HTuple metrologyHandle, HTuple index, HTuple resolution)
		{
			HOperatorSet.GetMetrologyObjectModelContour(out HObject contour, metrologyHandle, index, resolution);
			return contour;
		}
		public static HObject GetMetrologyObjectResultContour (HTuple metrologyHandle, HTuple index, HTuple instance, HTuple resolution)
		{
			HOperatorSet.GetMetrologyObjectResultContour(out HObject contour, metrologyHandle, index, instance, resolution);
			return contour;
		}
		public static void AlignMetrologyModel (HTuple metrologyHandle, HTuple row, HTuple column, HTuple angle)
		{
			HOperatorSet.AlignMetrologyModel(metrologyHandle, row, column, angle);
		}
		public static HTuple AddMetrologyObjectGeneric (HTuple metrologyHandle, HTuple shape, HTuple shapeParam, HTuple measureLength1, HTuple measureLength2, HTuple measureSigma, HTuple measureThreshold, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.AddMetrologyObjectGeneric(metrologyHandle, shape, shapeParam, measureLength1, measureLength2, measureSigma, measureThreshold, genParamName, genParamValue, out HTuple index);
			return index;
		}
		public static HTuple GetMetrologyModelParam (HTuple metrologyHandle, HTuple genParamName)
		{
			HOperatorSet.GetMetrologyModelParam(metrologyHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetMetrologyModelParam (HTuple metrologyHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetMetrologyModelParam(metrologyHandle, genParamName, genParamValue);
		}
		public static HTuple DeserializeMetrologyModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeMetrologyModel(serializedItemHandle, out HTuple metrologyHandle);
			return metrologyHandle;
		}
		public static HTuple SerializeMetrologyModel (HTuple metrologyHandle)
		{
			HOperatorSet.SerializeMetrologyModel(metrologyHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static void TransformMetrologyObject (HTuple metrologyHandle, HTuple index, HTuple row, HTuple column, HTuple phi, HTuple mode)
		{
			HOperatorSet.TransformMetrologyObject(metrologyHandle, index, row, column, phi, mode);
		}
		public static void WriteMetrologyModel (HTuple metrologyHandle, HTuple fileName)
		{
			HOperatorSet.WriteMetrologyModel(metrologyHandle, fileName);
		}
		public static HTuple ReadMetrologyModel (HTuple fileName)
		{
			HOperatorSet.ReadMetrologyModel(fileName, out HTuple metrologyHandle);
			return metrologyHandle;
		}
		public static HTuple CopyMetrologyModel (HTuple metrologyHandle, HTuple index)
		{
			HOperatorSet.CopyMetrologyModel(metrologyHandle, index, out HTuple copiedMetrologyHandle);
			return copiedMetrologyHandle;
		}
		public static HTuple CopyMetrologyObject (HTuple metrologyHandle, HTuple index)
		{
			HOperatorSet.CopyMetrologyObject(metrologyHandle, index, out HTuple copiedIndices);
			return copiedIndices;
		}
		public static HTuple GetMetrologyObjectNumInstances (HTuple metrologyHandle, HTuple index)
		{
			HOperatorSet.GetMetrologyObjectNumInstances(metrologyHandle, index, out HTuple numInstances);
			return numInstances;
		}
		public static HTuple GetMetrologyObjectResult (HTuple metrologyHandle, HTuple index, HTuple instance, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.GetMetrologyObjectResult(metrologyHandle, index, instance, genParamName, genParamValue, out HTuple parameter);
			return parameter;
		}
		public static (HObject contours, HTuple row, HTuple column) GetMetrologyObjectMeasures (HTuple metrologyHandle, HTuple index, HTuple transition)
		{
			HOperatorSet.GetMetrologyObjectMeasures(out HObject contours, metrologyHandle, index, transition, out HTuple row, out HTuple column);
			return (contours,row,column);
		}
		public static void ApplyMetrologyModel (HObject image, HTuple metrologyHandle)
		{
			HOperatorSet.ApplyMetrologyModel(image, metrologyHandle);
		}
		public static HTuple GetMetrologyObjectIndices (HTuple metrologyHandle)
		{
			HOperatorSet.GetMetrologyObjectIndices(metrologyHandle, out HTuple indices);
			return indices;
		}
		public static void ResetMetrologyObjectFuzzyParam (HTuple metrologyHandle, HTuple index)
		{
			HOperatorSet.ResetMetrologyObjectFuzzyParam(metrologyHandle, index);
		}
		public static void ResetMetrologyObjectParam (HTuple metrologyHandle, HTuple index)
		{
			HOperatorSet.ResetMetrologyObjectParam(metrologyHandle, index);
		}
		public static HTuple GetMetrologyObjectFuzzyParam (HTuple metrologyHandle, HTuple index, HTuple genParamName)
		{
			HOperatorSet.GetMetrologyObjectFuzzyParam(metrologyHandle, index, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static HTuple GetMetrologyObjectParam (HTuple metrologyHandle, HTuple index, HTuple genParamName)
		{
			HOperatorSet.GetMetrologyObjectParam(metrologyHandle, index, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetMetrologyObjectFuzzyParam (HTuple metrologyHandle, HTuple index, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetMetrologyObjectFuzzyParam(metrologyHandle, index, genParamName, genParamValue);
		}
		public static void SetMetrologyObjectParam (HTuple metrologyHandle, HTuple index, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetMetrologyObjectParam(metrologyHandle, index, genParamName, genParamValue);
		}
		public static HTuple AddMetrologyObjectRectangle2Measure (HTuple metrologyHandle, HTuple row, HTuple column, HTuple phi, HTuple length1, HTuple length2, HTuple measureLength1, HTuple measureLength2, HTuple measureSigma, HTuple measureThreshold, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.AddMetrologyObjectRectangle2Measure(metrologyHandle, row, column, phi, length1, length2, measureLength1, measureLength2, measureSigma, measureThreshold, genParamName, genParamValue, out HTuple index);
			return index;
		}
		public static HTuple AddMetrologyObjectLineMeasure (HTuple metrologyHandle, HTuple rowBegin, HTuple columnBegin, HTuple rowEnd, HTuple columnEnd, HTuple measureLength1, HTuple measureLength2, HTuple measureSigma, HTuple measureThreshold, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.AddMetrologyObjectLineMeasure(metrologyHandle, rowBegin, columnBegin, rowEnd, columnEnd, measureLength1, measureLength2, measureSigma, measureThreshold, genParamName, genParamValue, out HTuple index);
			return index;
		}
		public static HTuple AddMetrologyObjectEllipseMeasure (HTuple metrologyHandle, HTuple row, HTuple column, HTuple phi, HTuple radius1, HTuple radius2, HTuple measureLength1, HTuple measureLength2, HTuple measureSigma, HTuple measureThreshold, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.AddMetrologyObjectEllipseMeasure(metrologyHandle, row, column, phi, radius1, radius2, measureLength1, measureLength2, measureSigma, measureThreshold, genParamName, genParamValue, out HTuple index);
			return index;
		}
		public static HTuple AddMetrologyObjectCircleMeasure (HTuple metrologyHandle, HTuple row, HTuple column, HTuple radius, HTuple measureLength1, HTuple measureLength2, HTuple measureSigma, HTuple measureThreshold, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.AddMetrologyObjectCircleMeasure(metrologyHandle, row, column, radius, measureLength1, measureLength2, measureSigma, measureThreshold, genParamName, genParamValue, out HTuple index);
			return index;
		}
		public static void ClearAllMetrologyModels ()
		{
			HOperatorSet.ClearAllMetrologyModels();
		}
		public static void ClearMetrologyModel (HTuple metrologyHandle)
		{
			HOperatorSet.ClearMetrologyModel(metrologyHandle);
		}
		public static void ClearMetrologyObject (HTuple metrologyHandle, HTuple index)
		{
			HOperatorSet.ClearMetrologyObject(metrologyHandle, index);
		}
		public static void SetMetrologyModelImageSize (HTuple metrologyHandle, HTuple width, HTuple height)
		{
			HOperatorSet.SetMetrologyModelImageSize(metrologyHandle, width, height);
		}
		public static HTuple CreateMetrologyModel ()
		{
			HOperatorSet.CreateMetrologyModel(out HTuple metrologyHandle);
			return metrologyHandle;
		}
		public static HTuple SerializeMeasure (HTuple measureHandle)
		{
			HOperatorSet.SerializeMeasure(measureHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple DeserializeMeasure (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeMeasure(serializedItemHandle, out HTuple measureHandle);
			return measureHandle;
		}
		public static void WriteMeasure (HTuple measureHandle, HTuple fileName)
		{
			HOperatorSet.WriteMeasure(measureHandle, fileName);
		}
		public static HTuple ReadMeasure (HTuple fileName)
		{
			HOperatorSet.ReadMeasure(fileName, out HTuple measureHandle);
			return measureHandle;
		}
		public static (HTuple rowThresh, HTuple columnThresh, HTuple distance) MeasureThresh (HObject image, HTuple measureHandle, HTuple sigma, HTuple threshold, HTuple select)
		{
			HOperatorSet.MeasureThresh(image, measureHandle, sigma, threshold, select, out HTuple rowThresh, out HTuple columnThresh, out HTuple distance);
			return (rowThresh,columnThresh,distance);
		}
		public static void CloseAllMeasures ()
		{
			HOperatorSet.CloseAllMeasures();
		}
		public static void CloseMeasure (HTuple measureHandle)
		{
			HOperatorSet.CloseMeasure(measureHandle);
		}
		public static HTuple MeasureProjection (HObject image, HTuple measureHandle)
		{
			HOperatorSet.MeasureProjection(image, measureHandle, out HTuple grayValues);
			return grayValues;
		}
		public static void ResetFuzzyMeasure (HTuple measureHandle, HTuple setType)
		{
			HOperatorSet.ResetFuzzyMeasure(measureHandle, setType);
		}
		public static void SetFuzzyMeasureNormPair (HTuple measureHandle, HTuple pairSize, HTuple setType, HTuple function)
		{
			HOperatorSet.SetFuzzyMeasureNormPair(measureHandle, pairSize, setType, function);
		}
		public static void SetFuzzyMeasure (HTuple measureHandle, HTuple setType, HTuple function)
		{
			HOperatorSet.SetFuzzyMeasure(measureHandle, setType, function);
		}
		public static (HTuple rowEdgeFirst, HTuple columnEdgeFirst, HTuple amplitudeFirst, HTuple rowEdgeSecond, HTuple columnEdgeSecond, HTuple amplitudeSecond, HTuple rowPairCenter, HTuple columnPairCenter, HTuple fuzzyScore, HTuple intraDistance) FuzzyMeasurePairing (HObject image, HTuple measureHandle, HTuple sigma, HTuple ampThresh, HTuple fuzzyThresh, HTuple transition, HTuple pairing, HTuple numPairs)
		{
			HOperatorSet.FuzzyMeasurePairing(image, measureHandle, sigma, ampThresh, fuzzyThresh, transition, pairing, numPairs, out HTuple rowEdgeFirst, out HTuple columnEdgeFirst, out HTuple amplitudeFirst, out HTuple rowEdgeSecond, out HTuple columnEdgeSecond, out HTuple amplitudeSecond, out HTuple rowPairCenter, out HTuple columnPairCenter, out HTuple fuzzyScore, out HTuple intraDistance);
			return (rowEdgeFirst,columnEdgeFirst,amplitudeFirst,rowEdgeSecond,columnEdgeSecond,amplitudeSecond,rowPairCenter,columnPairCenter,fuzzyScore,intraDistance);
		}
		public static (HTuple rowEdgeFirst, HTuple columnEdgeFirst, HTuple amplitudeFirst, HTuple rowEdgeSecond, HTuple columnEdgeSecond, HTuple amplitudeSecond, HTuple rowEdgeCenter, HTuple columnEdgeCenter, HTuple fuzzyScore, HTuple intraDistance, HTuple interDistance) FuzzyMeasurePairs (HObject image, HTuple measureHandle, HTuple sigma, HTuple ampThresh, HTuple fuzzyThresh, HTuple transition)
		{
			HOperatorSet.FuzzyMeasurePairs(image, measureHandle, sigma, ampThresh, fuzzyThresh, transition, out HTuple rowEdgeFirst, out HTuple columnEdgeFirst, out HTuple amplitudeFirst, out HTuple rowEdgeSecond, out HTuple columnEdgeSecond, out HTuple amplitudeSecond, out HTuple rowEdgeCenter, out HTuple columnEdgeCenter, out HTuple fuzzyScore, out HTuple intraDistance, out HTuple interDistance);
			return (rowEdgeFirst,columnEdgeFirst,amplitudeFirst,rowEdgeSecond,columnEdgeSecond,amplitudeSecond,rowEdgeCenter,columnEdgeCenter,fuzzyScore,intraDistance,interDistance);
		}
		public static (HTuple rowEdge, HTuple columnEdge, HTuple amplitude, HTuple fuzzyScore, HTuple distance) FuzzyMeasurePos (HObject image, HTuple measureHandle, HTuple sigma, HTuple ampThresh, HTuple fuzzyThresh, HTuple transition)
		{
			HOperatorSet.FuzzyMeasurePos(image, measureHandle, sigma, ampThresh, fuzzyThresh, transition, out HTuple rowEdge, out HTuple columnEdge, out HTuple amplitude, out HTuple fuzzyScore, out HTuple distance);
			return (rowEdge,columnEdge,amplitude,fuzzyScore,distance);
		}
		public static (HTuple rowEdgeFirst, HTuple columnEdgeFirst, HTuple amplitudeFirst, HTuple rowEdgeSecond, HTuple columnEdgeSecond, HTuple amplitudeSecond, HTuple intraDistance, HTuple interDistance) MeasurePairs (HObject image, HTuple measureHandle, HTuple sigma, HTuple threshold, HTuple transition, HTuple select)
		{
			HOperatorSet.MeasurePairs(image, measureHandle, sigma, threshold, transition, select, out HTuple rowEdgeFirst, out HTuple columnEdgeFirst, out HTuple amplitudeFirst, out HTuple rowEdgeSecond, out HTuple columnEdgeSecond, out HTuple amplitudeSecond, out HTuple intraDistance, out HTuple interDistance);
			return (rowEdgeFirst,columnEdgeFirst,amplitudeFirst,rowEdgeSecond,columnEdgeSecond,amplitudeSecond,intraDistance,interDistance);
		}
		public static (HTuple rowEdge, HTuple columnEdge, HTuple amplitude, HTuple distance) MeasurePos (HObject image, HTuple measureHandle, HTuple sigma, HTuple threshold, HTuple transition, HTuple select)
		{
			HOperatorSet.MeasurePos(image, measureHandle, sigma, threshold, transition, select, out HTuple rowEdge, out HTuple columnEdge, out HTuple amplitude, out HTuple distance);
			return (rowEdge,columnEdge,amplitude,distance);
		}
		public static void TranslateMeasure (HTuple measureHandle, HTuple row, HTuple column)
		{
			HOperatorSet.TranslateMeasure(measureHandle, row, column);
		}
		public static HTuple GenMeasureArc (HTuple centerRow, HTuple centerCol, HTuple radius, HTuple angleStart, HTuple angleExtent, HTuple annulusRadius, HTuple width, HTuple height, HTuple interpolation)
		{
			HOperatorSet.GenMeasureArc(centerRow, centerCol, radius, angleStart, angleExtent, annulusRadius, width, height, interpolation, out HTuple measureHandle);
			return measureHandle;
		}
		public static HTuple GenMeasureRectangle2 (HTuple row, HTuple column, HTuple phi, HTuple length1, HTuple length2, HTuple width, HTuple height, HTuple interpolation)
		{
			HOperatorSet.GenMeasureRectangle2(row, column, phi, length1, length2, width, height, interpolation, out HTuple measureHandle);
			return measureHandle;
		}
		public static HTuple DeserializeMatrix (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeMatrix(serializedItemHandle, out HTuple matrixID);
			return matrixID;
		}
		public static HTuple SerializeMatrix (HTuple matrixID)
		{
			HOperatorSet.SerializeMatrix(matrixID, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadMatrix (HTuple fileName)
		{
			HOperatorSet.ReadMatrix(fileName, out HTuple matrixID);
			return matrixID;
		}
		public static void WriteMatrix (HTuple matrixID, HTuple fileFormat, HTuple fileName)
		{
			HOperatorSet.WriteMatrix(matrixID, fileFormat, fileName);
		}
		public static (HTuple matrixOrthogonalID, HTuple matrixTriangularID) OrthogonalDecomposeMatrix (HTuple matrixID, HTuple decompositionType, HTuple outputMatricesType, HTuple computeOrthogonal)
		{
			HOperatorSet.OrthogonalDecomposeMatrix(matrixID, decompositionType, outputMatricesType, computeOrthogonal, out HTuple matrixOrthogonalID, out HTuple matrixTriangularID);
			return (matrixOrthogonalID,matrixTriangularID);
		}
		public static (HTuple matrix1ID, HTuple matrix2ID) DecomposeMatrix (HTuple matrixID, HTuple matrixType)
		{
			HOperatorSet.DecomposeMatrix(matrixID, matrixType, out HTuple matrix1ID, out HTuple matrix2ID);
			return (matrix1ID,matrix2ID);
		}
		public static (HTuple matrixUID, HTuple matrixSID, HTuple matrixVID) SvdMatrix (HTuple matrixID, HTuple SVDType, HTuple computeSingularVectors)
		{
			HOperatorSet.SvdMatrix(matrixID, SVDType, computeSingularVectors, out HTuple matrixUID, out HTuple matrixSID, out HTuple matrixVID);
			return (matrixUID,matrixSID,matrixVID);
		}
		public static (HTuple eigenvaluesRealID, HTuple eigenvaluesImagID, HTuple eigenvectorsRealID, HTuple eigenvectorsImagID) GeneralizedEigenvaluesGeneralMatrix (HTuple matrixAID, HTuple matrixBID, HTuple computeEigenvectors)
		{
			HOperatorSet.GeneralizedEigenvaluesGeneralMatrix(matrixAID, matrixBID, computeEigenvectors, out HTuple eigenvaluesRealID, out HTuple eigenvaluesImagID, out HTuple eigenvectorsRealID, out HTuple eigenvectorsImagID);
			return (eigenvaluesRealID,eigenvaluesImagID,eigenvectorsRealID,eigenvectorsImagID);
		}
		public static (HTuple eigenvaluesID, HTuple eigenvectorsID) GeneralizedEigenvaluesSymmetricMatrix (HTuple matrixAID, HTuple matrixBID, HTuple computeEigenvectors)
		{
			HOperatorSet.GeneralizedEigenvaluesSymmetricMatrix(matrixAID, matrixBID, computeEigenvectors, out HTuple eigenvaluesID, out HTuple eigenvectorsID);
			return (eigenvaluesID,eigenvectorsID);
		}
		public static (HTuple eigenvaluesRealID, HTuple eigenvaluesImagID, HTuple eigenvectorsRealID, HTuple eigenvectorsImagID) EigenvaluesGeneralMatrix (HTuple matrixID, HTuple computeEigenvectors)
		{
			HOperatorSet.EigenvaluesGeneralMatrix(matrixID, computeEigenvectors, out HTuple eigenvaluesRealID, out HTuple eigenvaluesImagID, out HTuple eigenvectorsRealID, out HTuple eigenvectorsImagID);
			return (eigenvaluesRealID,eigenvaluesImagID,eigenvectorsRealID,eigenvectorsImagID);
		}
		public static (HTuple eigenvaluesID, HTuple eigenvectorsID) EigenvaluesSymmetricMatrix (HTuple matrixID, HTuple computeEigenvectors)
		{
			HOperatorSet.EigenvaluesSymmetricMatrix(matrixID, computeEigenvectors, out HTuple eigenvaluesID, out HTuple eigenvectorsID);
			return (eigenvaluesID,eigenvectorsID);
		}
		public static HTuple SolveMatrix (HTuple matrixLHSID, HTuple matrixLHSType, HTuple epsilon, HTuple matrixRHSID)
		{
			HOperatorSet.SolveMatrix(matrixLHSID, matrixLHSType, epsilon, matrixRHSID, out HTuple matrixResultID);
			return matrixResultID;
		}
		public static HTuple DeterminantMatrix (HTuple matrixID, HTuple matrixType)
		{
			HOperatorSet.DeterminantMatrix(matrixID, matrixType, out HTuple value);
			return value;
		}
		public static void InvertMatrixMod (HTuple matrixID, HTuple matrixType, HTuple epsilon)
		{
			HOperatorSet.InvertMatrixMod(matrixID, matrixType, epsilon);
		}
		public static HTuple InvertMatrix (HTuple matrixID, HTuple matrixType, HTuple epsilon)
		{
			HOperatorSet.InvertMatrix(matrixID, matrixType, epsilon, out HTuple matrixInvID);
			return matrixInvID;
		}
		public static void TransposeMatrixMod (HTuple matrixID)
		{
			HOperatorSet.TransposeMatrixMod(matrixID);
		}
		public static HTuple TransposeMatrix (HTuple matrixID)
		{
			HOperatorSet.TransposeMatrix(matrixID, out HTuple matrixTransposedID);
			return matrixTransposedID;
		}
		public static HTuple MaxMatrix (HTuple matrixID, HTuple maxType)
		{
			HOperatorSet.MaxMatrix(matrixID, maxType, out HTuple matrixMaxID);
			return matrixMaxID;
		}
		public static HTuple MinMatrix (HTuple matrixID, HTuple minType)
		{
			HOperatorSet.MinMatrix(matrixID, minType, out HTuple matrixMinID);
			return matrixMinID;
		}
		public static void PowMatrixMod (HTuple matrixID, HTuple matrixType, HTuple power)
		{
			HOperatorSet.PowMatrixMod(matrixID, matrixType, power);
		}
		public static HTuple PowMatrix (HTuple matrixID, HTuple matrixType, HTuple power)
		{
			HOperatorSet.PowMatrix(matrixID, matrixType, power, out HTuple matrixPowID);
			return matrixPowID;
		}
		public static void PowElementMatrixMod (HTuple matrixID, HTuple matrixExpID)
		{
			HOperatorSet.PowElementMatrixMod(matrixID, matrixExpID);
		}
		public static HTuple PowElementMatrix (HTuple matrixID, HTuple matrixExpID)
		{
			HOperatorSet.PowElementMatrix(matrixID, matrixExpID, out HTuple matrixPowID);
			return matrixPowID;
		}
		public static void PowScalarElementMatrixMod (HTuple matrixID, HTuple power)
		{
			HOperatorSet.PowScalarElementMatrixMod(matrixID, power);
		}
		public static HTuple PowScalarElementMatrix (HTuple matrixID, HTuple power)
		{
			HOperatorSet.PowScalarElementMatrix(matrixID, power, out HTuple matrixPowID);
			return matrixPowID;
		}
		public static void SqrtMatrixMod (HTuple matrixID)
		{
			HOperatorSet.SqrtMatrixMod(matrixID);
		}
		public static HTuple SqrtMatrix (HTuple matrixID)
		{
			HOperatorSet.SqrtMatrix(matrixID, out HTuple matrixSqrtID);
			return matrixSqrtID;
		}
		public static void AbsMatrixMod (HTuple matrixID)
		{
			HOperatorSet.AbsMatrixMod(matrixID);
		}
		public static HTuple AbsMatrix (HTuple matrixID)
		{
			HOperatorSet.AbsMatrix(matrixID, out HTuple matrixAbsID);
			return matrixAbsID;
		}
		public static HTuple NormMatrix (HTuple matrixID, HTuple normType)
		{
			HOperatorSet.NormMatrix(matrixID, normType, out HTuple value);
			return value;
		}
		public static HTuple MeanMatrix (HTuple matrixID, HTuple meanType)
		{
			HOperatorSet.MeanMatrix(matrixID, meanType, out HTuple matrixMeanID);
			return matrixMeanID;
		}
		public static HTuple SumMatrix (HTuple matrixID, HTuple sumType)
		{
			HOperatorSet.SumMatrix(matrixID, sumType, out HTuple matrixSumID);
			return matrixSumID;
		}
		public static void DivElementMatrixMod (HTuple matrixAID, HTuple matrixBID)
		{
			HOperatorSet.DivElementMatrixMod(matrixAID, matrixBID);
		}
		public static HTuple DivElementMatrix (HTuple matrixAID, HTuple matrixBID)
		{
			HOperatorSet.DivElementMatrix(matrixAID, matrixBID, out HTuple matrixDivID);
			return matrixDivID;
		}
		public static void MultElementMatrixMod (HTuple matrixAID, HTuple matrixBID)
		{
			HOperatorSet.MultElementMatrixMod(matrixAID, matrixBID);
		}
		public static HTuple MultElementMatrix (HTuple matrixAID, HTuple matrixBID)
		{
			HOperatorSet.MultElementMatrix(matrixAID, matrixBID, out HTuple matrixMultID);
			return matrixMultID;
		}
		public static void ScaleMatrixMod (HTuple matrixID, HTuple factor)
		{
			HOperatorSet.ScaleMatrixMod(matrixID, factor);
		}
		public static HTuple ScaleMatrix (HTuple matrixID, HTuple factor)
		{
			HOperatorSet.ScaleMatrix(matrixID, factor, out HTuple matrixScaledID);
			return matrixScaledID;
		}
		public static void SubMatrixMod (HTuple matrixAID, HTuple matrixBID)
		{
			HOperatorSet.SubMatrixMod(matrixAID, matrixBID);
		}
		public static HTuple SubMatrix (HTuple matrixAID, HTuple matrixBID)
		{
			HOperatorSet.SubMatrix(matrixAID, matrixBID, out HTuple matrixSubID);
			return matrixSubID;
		}
		public static void AddMatrixMod (HTuple matrixAID, HTuple matrixBID)
		{
			HOperatorSet.AddMatrixMod(matrixAID, matrixBID);
		}
		public static HTuple AddMatrix (HTuple matrixAID, HTuple matrixBID)
		{
			HOperatorSet.AddMatrix(matrixAID, matrixBID, out HTuple matrixSumID);
			return matrixSumID;
		}
		public static void MultMatrixMod (HTuple matrixAID, HTuple matrixBID, HTuple multType)
		{
			HOperatorSet.MultMatrixMod(matrixAID, matrixBID, multType);
		}
		public static HTuple MultMatrix (HTuple matrixAID, HTuple matrixBID, HTuple multType)
		{
			HOperatorSet.MultMatrix(matrixAID, matrixBID, multType, out HTuple matrixMultID);
			return matrixMultID;
		}
		public static (HTuple rows, HTuple columns) GetSizeMatrix (HTuple matrixID)
		{
			HOperatorSet.GetSizeMatrix(matrixID, out HTuple rows, out HTuple columns);
			return (rows,columns);
		}
		public static HTuple RepeatMatrix (HTuple matrixID, HTuple rows, HTuple columns)
		{
			HOperatorSet.RepeatMatrix(matrixID, rows, columns, out HTuple matrixRepeatedID);
			return matrixRepeatedID;
		}
		public static HTuple CopyMatrix (HTuple matrixID)
		{
			HOperatorSet.CopyMatrix(matrixID, out HTuple matrixCopyID);
			return matrixCopyID;
		}
		public static void SetDiagonalMatrix (HTuple matrixID, HTuple vectorID, HTuple diagonal)
		{
			HOperatorSet.SetDiagonalMatrix(matrixID, vectorID, diagonal);
		}
		public static HTuple GetDiagonalMatrix (HTuple matrixID, HTuple diagonal)
		{
			HOperatorSet.GetDiagonalMatrix(matrixID, diagonal, out HTuple vectorID);
			return vectorID;
		}
		public static void SetSubMatrix (HTuple matrixID, HTuple matrixSubID, HTuple row, HTuple column)
		{
			HOperatorSet.SetSubMatrix(matrixID, matrixSubID, row, column);
		}
		public static HTuple GetSubMatrix (HTuple matrixID, HTuple row, HTuple column, HTuple rowsSub, HTuple columnsSub)
		{
			HOperatorSet.GetSubMatrix(matrixID, row, column, rowsSub, columnsSub, out HTuple matrixSubID);
			return matrixSubID;
		}
		public static void SetFullMatrix (HTuple matrixID, HTuple values)
		{
			HOperatorSet.SetFullMatrix(matrixID, values);
		}
		public static HTuple GetFullMatrix (HTuple matrixID)
		{
			HOperatorSet.GetFullMatrix(matrixID, out HTuple values);
			return values;
		}
		public static void SetValueMatrix (HTuple matrixID, HTuple row, HTuple column, HTuple value)
		{
			HOperatorSet.SetValueMatrix(matrixID, row, column, value);
		}
		public static HTuple GetValueMatrix (HTuple matrixID, HTuple row, HTuple column)
		{
			HOperatorSet.GetValueMatrix(matrixID, row, column, out HTuple value);
			return value;
		}
		public static void ClearAllMatrices ()
		{
			HOperatorSet.ClearAllMatrices();
		}
		public static HTuple DeserializeOcv (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeOcv(serializedItemHandle, out HTuple OCVHandle);
			return OCVHandle;
		}
		public static HTuple SerializeOcv (HTuple OCVHandle)
		{
			HOperatorSet.SerializeOcv(OCVHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadOcv (HTuple fileName)
		{
			HOperatorSet.ReadOcv(fileName, out HTuple OCVHandle);
			return OCVHandle;
		}
		public static void WriteOcv (HTuple OCVHandle, HTuple fileName)
		{
			HOperatorSet.WriteOcv(OCVHandle, fileName);
		}
		public static void CloseAllOcvs ()
		{
			HOperatorSet.CloseAllOcvs();
		}
		public static void CloseOcv (HTuple OCVHandle)
		{
			HOperatorSet.CloseOcv(OCVHandle);
		}
		public static HTuple CreateOcvProj (HTuple patternNames)
		{
			HOperatorSet.CreateOcvProj(patternNames, out HTuple OCVHandle);
			return OCVHandle;
		}
		public static (HTuple classVal, HTuple confidence, HTuple word, HTuple score) DoOcrWordKnn (HObject character, HObject image, HTuple OCRHandle, HTuple expression, HTuple numAlternatives, HTuple numCorrections)
		{
			HOperatorSet.DoOcrWordKnn(character, image, OCRHandle, expression, numAlternatives, numCorrections, out HTuple classVal, out HTuple confidence, out HTuple word, out HTuple score);
			return (classVal,confidence,word,score);
		}
		public static HTuple DeserializeOcrClassKnn (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeOcrClassKnn(serializedItemHandle, out HTuple OCRHandle);
			return OCRHandle;
		}
		public static HTuple SerializeOcrClassKnn (HTuple OCRHandle)
		{
			HOperatorSet.SerializeOcrClassKnn(OCRHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadOcrClassKnn (HTuple fileName)
		{
			HOperatorSet.ReadOcrClassKnn(fileName, out HTuple OCRHandle);
			return OCRHandle;
		}
		public static void WriteOcrClassKnn (HTuple OCRHandle, HTuple fileName)
		{
			HOperatorSet.WriteOcrClassKnn(OCRHandle, fileName);
		}
		public static void ClearAllOcrClassKnn ()
		{
			HOperatorSet.ClearAllOcrClassKnn();
		}
		public static void ClearOcrClassKnn (HTuple OCRHandle)
		{
			HOperatorSet.ClearOcrClassKnn(OCRHandle);
		}
		public static HTuple CreateOcrClassKnn (HTuple widthCharacter, HTuple heightCharacter, HTuple interpolation, HTuple features, HTuple characters, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateOcrClassKnn(widthCharacter, heightCharacter, interpolation, features, characters, genParamName, genParamValue, out HTuple OCRHandle);
			return OCRHandle;
		}
		public static void TrainfOcrClassKnn (HTuple OCRHandle, HTuple trainingFile, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.TrainfOcrClassKnn(OCRHandle, trainingFile, genParamName, genParamValue);
		}
		public static HTuple GetFeaturesOcrClassKnn (HObject character, HTuple OCRHandle, HTuple transform)
		{
			HOperatorSet.GetFeaturesOcrClassKnn(character, OCRHandle, transform, out HTuple features);
			return features;
		}
		public static (HTuple widthCharacter, HTuple heightCharacter, HTuple interpolation, HTuple features, HTuple characters, HTuple preprocessing, HTuple numTrees) GetParamsOcrClassKnn (HTuple OCRHandle)
		{
			HOperatorSet.GetParamsOcrClassKnn(OCRHandle, out HTuple widthCharacter, out HTuple heightCharacter, out HTuple interpolation, out HTuple features, out HTuple characters, out HTuple preprocessing, out HTuple numTrees);
			return (widthCharacter,heightCharacter,interpolation,features,characters,preprocessing,numTrees);
		}
		public static (HTuple classVal, HTuple confidence) DoOcrMultiClassKnn (HObject character, HObject image, HTuple OCRHandle)
		{
			HOperatorSet.DoOcrMultiClassKnn(character, image, OCRHandle, out HTuple classVal, out HTuple confidence);
			return (classVal,confidence);
		}
		public static (HTuple classVal, HTuple confidence) DoOcrSingleClassKnn (HObject character, HObject image, HTuple OCRHandle, HTuple numClasses, HTuple numNeighbors)
		{
			HOperatorSet.DoOcrSingleClassKnn(character, image, OCRHandle, numClasses, numNeighbors, out HTuple classVal, out HTuple confidence);
			return (classVal,confidence);
		}
		public static (HTuple OCRHandle, HTuple featureSet, HTuple score) SelectFeatureSetTrainfKnn (HTuple trainingFile, HTuple featureList, HTuple selectionMethod, HTuple width, HTuple height, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SelectFeatureSetTrainfKnn(trainingFile, featureList, selectionMethod, width, height, genParamName, genParamValue, out HTuple OCRHandle, out HTuple featureSet, out HTuple score);
			return (OCRHandle,featureSet,score);
		}
		public static (HTuple OCRHandle, HTuple featureSet, HTuple score) SelectFeatureSetTrainfMlpProtected (HTuple trainingFile, HTuple password, HTuple featureList, HTuple selectionMethod, HTuple width, HTuple height, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SelectFeatureSetTrainfMlpProtected(trainingFile, password, featureList, selectionMethod, width, height, genParamName, genParamValue, out HTuple OCRHandle, out HTuple featureSet, out HTuple score);
			return (OCRHandle,featureSet,score);
		}
		public static (HTuple OCRHandle, HTuple featureSet, HTuple score) SelectFeatureSetTrainfMlp (HTuple trainingFile, HTuple featureList, HTuple selectionMethod, HTuple width, HTuple height, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SelectFeatureSetTrainfMlp(trainingFile, featureList, selectionMethod, width, height, genParamName, genParamValue, out HTuple OCRHandle, out HTuple featureSet, out HTuple score);
			return (OCRHandle,featureSet,score);
		}
		public static (HTuple OCRHandle, HTuple featureSet, HTuple score) SelectFeatureSetTrainfSvmProtected (HTuple trainingFile, HTuple password, HTuple featureList, HTuple selectionMethod, HTuple width, HTuple height, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SelectFeatureSetTrainfSvmProtected(trainingFile, password, featureList, selectionMethod, width, height, genParamName, genParamValue, out HTuple OCRHandle, out HTuple featureSet, out HTuple score);
			return (OCRHandle,featureSet,score);
		}
		public static (HTuple OCRHandle, HTuple featureSet, HTuple score) SelectFeatureSetTrainfSvm (HTuple trainingFile, HTuple featureList, HTuple selectionMethod, HTuple width, HTuple height, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SelectFeatureSetTrainfSvm(trainingFile, featureList, selectionMethod, width, height, genParamName, genParamValue, out HTuple OCRHandle, out HTuple featureSet, out HTuple score);
			return (OCRHandle,featureSet,score);
		}
		public static void ClearAllLexica ()
		{
			HOperatorSet.ClearAllLexica();
		}
		public static void ClearLexicon (HTuple lexiconHandle)
		{
			HOperatorSet.ClearLexicon(lexiconHandle);
		}
		public static (HTuple suggestion, HTuple numCorrections) SuggestLexicon (HTuple lexiconHandle, HTuple word)
		{
			HOperatorSet.SuggestLexicon(lexiconHandle, word, out HTuple suggestion, out HTuple numCorrections);
			return (suggestion,numCorrections);
		}
		public static HTuple LookupLexicon (HTuple lexiconHandle, HTuple word)
		{
			HOperatorSet.LookupLexicon(lexiconHandle, word, out HTuple found);
			return found;
		}
		public static HTuple InspectLexicon (HTuple lexiconHandle)
		{
			HOperatorSet.InspectLexicon(lexiconHandle, out HTuple words);
			return words;
		}
		public static HTuple ImportLexicon (HTuple name, HTuple fileName)
		{
			HOperatorSet.ImportLexicon(name, fileName, out HTuple lexiconHandle);
			return lexiconHandle;
		}
		public static HTuple CreateLexicon (HTuple name, HTuple words)
		{
			HOperatorSet.CreateLexicon(name, words, out HTuple lexiconHandle);
			return lexiconHandle;
		}
		public static void ClearAllOcrClassSvm ()
		{
			HOperatorSet.ClearAllOcrClassSvm();
		}
		public static void ClearOcrClassSvm (HTuple OCRHandle)
		{
			HOperatorSet.ClearOcrClassSvm(OCRHandle);
		}
		public static HTuple DeserializeOcrClassSvm (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeOcrClassSvm(serializedItemHandle, out HTuple OCRHandle);
			return OCRHandle;
		}
		public static HTuple SerializeOcrClassSvm (HTuple OCRHandle)
		{
			HOperatorSet.SerializeOcrClassSvm(OCRHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadOcrClassSvm (HTuple fileName)
		{
			HOperatorSet.ReadOcrClassSvm(fileName, out HTuple OCRHandle);
			return OCRHandle;
		}
		public static void WriteOcrClassSvm (HTuple OCRHandle, HTuple fileName)
		{
			HOperatorSet.WriteOcrClassSvm(OCRHandle, fileName);
		}
		public static HTuple GetFeaturesOcrClassSvm (HObject character, HTuple OCRHandle, HTuple transform)
		{
			HOperatorSet.GetFeaturesOcrClassSvm(character, OCRHandle, transform, out HTuple features);
			return features;
		}
		public static (HTuple classVal, HTuple word, HTuple score) DoOcrWordSvm (HObject character, HObject image, HTuple OCRHandle, HTuple expression, HTuple numAlternatives, HTuple numCorrections)
		{
			HOperatorSet.DoOcrWordSvm(character, image, OCRHandle, expression, numAlternatives, numCorrections, out HTuple classVal, out HTuple word, out HTuple score);
			return (classVal,word,score);
		}
		public static HTuple DoOcrMultiClassSvm (HObject character, HObject image, HTuple OCRHandle)
		{
			HOperatorSet.DoOcrMultiClassSvm(character, image, OCRHandle, out HTuple classVal);
			return classVal;
		}
		public static HTuple DoOcrSingleClassSvm (HObject character, HObject image, HTuple OCRHandle, HTuple num)
		{
			HOperatorSet.DoOcrSingleClassSvm(character, image, OCRHandle, num, out HTuple classVal);
			return classVal;
		}
		public static HTuple ReduceOcrClassSvm (HTuple OCRHandle, HTuple method, HTuple minRemainingSV, HTuple maxError)
		{
			HOperatorSet.ReduceOcrClassSvm(OCRHandle, method, minRemainingSV, maxError, out HTuple OCRHandleReduced);
			return OCRHandleReduced;
		}
		public static void TrainfOcrClassSvmProtected (HTuple OCRHandle, HTuple trainingFile, HTuple password, HTuple epsilon, HTuple trainMode)
		{
			HOperatorSet.TrainfOcrClassSvmProtected(OCRHandle, trainingFile, password, epsilon, trainMode);
		}
		public static void TrainfOcrClassSvm (HTuple OCRHandle, HTuple trainingFile, HTuple epsilon, HTuple trainMode)
		{
			HOperatorSet.TrainfOcrClassSvm(OCRHandle, trainingFile, epsilon, trainMode);
		}
		public static (HTuple informationCont, HTuple cumInformationCont) GetPrepInfoOcrClassSvm (HTuple OCRHandle, HTuple trainingFile, HTuple preprocessing)
		{
			HOperatorSet.GetPrepInfoOcrClassSvm(OCRHandle, trainingFile, preprocessing, out HTuple informationCont, out HTuple cumInformationCont);
			return (informationCont,cumInformationCont);
		}
		public static (HTuple numSupportVectors, HTuple numSVPerSVM) GetSupportVectorNumOcrClassSvm (HTuple OCRHandle)
		{
			HOperatorSet.GetSupportVectorNumOcrClassSvm(OCRHandle, out HTuple numSupportVectors, out HTuple numSVPerSVM);
			return (numSupportVectors,numSVPerSVM);
		}
		public static HTuple GetSupportVectorOcrClassSvm (HTuple OCRHandle, HTuple indexSupportVector)
		{
			HOperatorSet.GetSupportVectorOcrClassSvm(OCRHandle, indexSupportVector, out HTuple index);
			return index;
		}
		public static (HTuple widthCharacter, HTuple heightCharacter, HTuple interpolation, HTuple features, HTuple characters, HTuple kernelType, HTuple kernelParam, HTuple nu, HTuple mode, HTuple preprocessing, HTuple numComponents) GetParamsOcrClassSvm (HTuple OCRHandle)
		{
			HOperatorSet.GetParamsOcrClassSvm(OCRHandle, out HTuple widthCharacter, out HTuple heightCharacter, out HTuple interpolation, out HTuple features, out HTuple characters, out HTuple kernelType, out HTuple kernelParam, out HTuple nu, out HTuple mode, out HTuple preprocessing, out HTuple numComponents);
			return (widthCharacter,heightCharacter,interpolation,features,characters,kernelType,kernelParam,nu,mode,preprocessing,numComponents);
		}
		public static HTuple CreateOcrClassSvm (HTuple widthCharacter, HTuple heightCharacter, HTuple interpolation, HTuple features, HTuple characters, HTuple kernelType, HTuple kernelParam, HTuple nu, HTuple mode, HTuple preprocessing, HTuple numComponents)
		{
			HOperatorSet.CreateOcrClassSvm(widthCharacter, heightCharacter, interpolation, features, characters, kernelType, kernelParam, nu, mode, preprocessing, numComponents, out HTuple OCRHandle);
			return OCRHandle;
		}
		public static void ClearAllOcrClassMlp ()
		{
			HOperatorSet.ClearAllOcrClassMlp();
		}
		public static void ClearOcrClassMlp (HTuple OCRHandle)
		{
			HOperatorSet.ClearOcrClassMlp(OCRHandle);
		}
		public static HTuple DeserializeOcrClassMlp (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeOcrClassMlp(serializedItemHandle, out HTuple OCRHandle);
			return OCRHandle;
		}
		public static HTuple SerializeOcrClassMlp (HTuple OCRHandle)
		{
			HOperatorSet.SerializeOcrClassMlp(OCRHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadOcrClassMlp (HTuple fileName)
		{
			HOperatorSet.ReadOcrClassMlp(fileName, out HTuple OCRHandle);
			return OCRHandle;
		}
		public static void WriteOcrClassMlp (HTuple OCRHandle, HTuple fileName)
		{
			HOperatorSet.WriteOcrClassMlp(OCRHandle, fileName);
		}
		public static HTuple GetFeaturesOcrClassMlp (HObject character, HTuple OCRHandle, HTuple transform)
		{
			HOperatorSet.GetFeaturesOcrClassMlp(character, OCRHandle, transform, out HTuple features);
			return features;
		}
		public static (HTuple classVal, HTuple confidence, HTuple word, HTuple score) DoOcrWordMlp (HObject character, HObject image, HTuple OCRHandle, HTuple expression, HTuple numAlternatives, HTuple numCorrections)
		{
			HOperatorSet.DoOcrWordMlp(character, image, OCRHandle, expression, numAlternatives, numCorrections, out HTuple classVal, out HTuple confidence, out HTuple word, out HTuple score);
			return (classVal,confidence,word,score);
		}
		public static (HTuple classVal, HTuple confidence) DoOcrMultiClassMlp (HObject character, HObject image, HTuple OCRHandle)
		{
			HOperatorSet.DoOcrMultiClassMlp(character, image, OCRHandle, out HTuple classVal, out HTuple confidence);
			return (classVal,confidence);
		}
		public static (HTuple classVal, HTuple confidence) DoOcrSingleClassMlp (HObject character, HObject image, HTuple OCRHandle, HTuple num)
		{
			HOperatorSet.DoOcrSingleClassMlp(character, image, OCRHandle, num, out HTuple classVal, out HTuple confidence);
			return (classVal,confidence);
		}
		public static (HTuple error, HTuple errorLog) TrainfOcrClassMlpProtected (HTuple OCRHandle, HTuple trainingFile, HTuple password, HTuple maxIterations, HTuple weightTolerance, HTuple errorTolerance)
		{
			HOperatorSet.TrainfOcrClassMlpProtected(OCRHandle, trainingFile, password, maxIterations, weightTolerance, errorTolerance, out HTuple error, out HTuple errorLog);
			return (error,errorLog);
		}
		public static (HTuple error, HTuple errorLog) TrainfOcrClassMlp (HTuple OCRHandle, HTuple trainingFile, HTuple maxIterations, HTuple weightTolerance, HTuple errorTolerance)
		{
			HOperatorSet.TrainfOcrClassMlp(OCRHandle, trainingFile, maxIterations, weightTolerance, errorTolerance, out HTuple error, out HTuple errorLog);
			return (error,errorLog);
		}
		public static (HTuple informationCont, HTuple cumInformationCont) GetPrepInfoOcrClassMlp (HTuple OCRHandle, HTuple trainingFile, HTuple preprocessing)
		{
			HOperatorSet.GetPrepInfoOcrClassMlp(OCRHandle, trainingFile, preprocessing, out HTuple informationCont, out HTuple cumInformationCont);
			return (informationCont,cumInformationCont);
		}
		public static HTuple GetRejectionParamsOcrClassMlp (HTuple OCRHandle, HTuple genParamName)
		{
			HOperatorSet.GetRejectionParamsOcrClassMlp(OCRHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetRejectionParamsOcrClassMlp (HTuple OCRHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetRejectionParamsOcrClassMlp(OCRHandle, genParamName, genParamValue);
		}
		public static HTuple GetRegularizationParamsOcrClassMlp (HTuple OCRHandle, HTuple genParamName)
		{
			HOperatorSet.GetRegularizationParamsOcrClassMlp(OCRHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetRegularizationParamsOcrClassMlp (HTuple OCRHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetRegularizationParamsOcrClassMlp(OCRHandle, genParamName, genParamValue);
		}
		public static (HTuple widthCharacter, HTuple heightCharacter, HTuple interpolation, HTuple features, HTuple characters, HTuple numHidden, HTuple preprocessing, HTuple numComponents) GetParamsOcrClassMlp (HTuple OCRHandle)
		{
			HOperatorSet.GetParamsOcrClassMlp(OCRHandle, out HTuple widthCharacter, out HTuple heightCharacter, out HTuple interpolation, out HTuple features, out HTuple characters, out HTuple numHidden, out HTuple preprocessing, out HTuple numComponents);
			return (widthCharacter,heightCharacter,interpolation,features,characters,numHidden,preprocessing,numComponents);
		}
		public static HTuple CreateOcrClassMlp (HTuple widthCharacter, HTuple heightCharacter, HTuple interpolation, HTuple features, HTuple characters, HTuple numHidden, HTuple preprocessing, HTuple numComponents, HTuple randSeed)
		{
			HOperatorSet.CreateOcrClassMlp(widthCharacter, heightCharacter, interpolation, features, characters, numHidden, preprocessing, numComponents, randSeed, out HTuple OCRHandle);
			return OCRHandle;
		}
		public static HTuple SerializeOcr (HTuple ocrHandle)
		{
			HOperatorSet.SerializeOcr(ocrHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple DeserializeOcr (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeOcr(serializedItemHandle, out HTuple ocrHandle);
			return ocrHandle;
		}
		public static void WriteOcr (HTuple ocrHandle, HTuple fileName)
		{
			HOperatorSet.WriteOcr(ocrHandle, fileName);
		}
		public static HTuple ReadOcr (HTuple fileName)
		{
			HOperatorSet.ReadOcr(fileName, out HTuple ocrHandle);
			return ocrHandle;
		}
		public static (HTuple classes, HTuple confidences) DoOcrSingle (HObject character, HObject image, HTuple ocrHandle)
		{
			HOperatorSet.DoOcrSingle(character, image, ocrHandle, out HTuple classes, out HTuple confidences);
			return (classes,confidences);
		}
		public static (HTuple classVal, HTuple confidence) DoOcrMulti (HObject character, HObject image, HTuple ocrHandle)
		{
			HOperatorSet.DoOcrMulti(character, image, ocrHandle, out HTuple classVal, out HTuple confidence);
			return (classVal,confidence);
		}
		public static (HTuple widthPattern, HTuple heightPattern, HTuple interpolation, HTuple widthMaxChar, HTuple heightMaxChar, HTuple features, HTuple characters) InfoOcrClassBox (HTuple ocrHandle)
		{
			HOperatorSet.InfoOcrClassBox(ocrHandle, out HTuple widthPattern, out HTuple heightPattern, out HTuple interpolation, out HTuple widthMaxChar, out HTuple heightMaxChar, out HTuple features, out HTuple characters);
			return (widthPattern,heightPattern,interpolation,widthMaxChar,heightMaxChar,features,characters);
		}
		public static HTuple CreateOcrClassBox (HTuple widthPattern, HTuple heightPattern, HTuple interpolation, HTuple features, HTuple character)
		{
			HOperatorSet.CreateOcrClassBox(widthPattern, heightPattern, interpolation, features, character, out HTuple ocrHandle);
			return ocrHandle;
		}
		public static HTuple TraindOcrClassBox (HObject character, HObject image, HTuple ocrHandle, HTuple classVal)
		{
			HOperatorSet.TraindOcrClassBox(character, image, ocrHandle, classVal, out HTuple avgConfidence);
			return avgConfidence;
		}
		public static HTuple TrainfOcrClassBox (HTuple ocrHandle, HTuple trainingFile)
		{
			HOperatorSet.TrainfOcrClassBox(ocrHandle, trainingFile, out HTuple avgConfidence);
			return avgConfidence;
		}
		public static void ProtectOcrTrainf (HTuple trainingFile, HTuple password, HTuple trainingFileProtected)
		{
			HOperatorSet.ProtectOcrTrainf(trainingFile, password, trainingFileProtected);
		}
		public static void WriteOcrTrainf (HObject character, HObject image, HTuple classVal, HTuple trainingFile)
		{
			HOperatorSet.WriteOcrTrainf(character, image, classVal, trainingFile);
		}
		public static void OcrChangeChar (HTuple ocrHandle, HTuple character)
		{
			HOperatorSet.OcrChangeChar(ocrHandle, character);
		}
		public static void CloseOcr (HTuple ocrHandle)
		{
			HOperatorSet.CloseOcr(ocrHandle);
		}
		public static HObject SortRegion (HObject regions, HTuple sortMode, HTuple order, HTuple rowOrCol)
		{
			HOperatorSet.SortRegion(regions, out HObject sortedRegions, sortMode, order, rowOrCol);
			return sortedRegions;
		}
		public static void CloseAllOcrs ()
		{
			HOperatorSet.CloseAllOcrs();
		}
		public static HTuple TestdOcrClassBox (HObject character, HObject image, HTuple ocrHandle, HTuple classVal)
		{
			HOperatorSet.TestdOcrClassBox(character, image, ocrHandle, classVal, out HTuple confidence);
			return confidence;
		}
		public static HObject CropDomainRel (HObject image, HTuple top, HTuple left, HTuple bottom, HTuple right)
		{
			HOperatorSet.CropDomainRel(image, out HObject imagePart, top, left, bottom, right);
			return imagePart;
		}
		public static HTuple OcrGetFeatures (HObject character, HTuple ocrHandle)
		{
			HOperatorSet.OcrGetFeatures(character, ocrHandle, out HTuple featureVector);
			return featureVector;
		}
		public static void ConcatOcrTrainf (HTuple singleFiles, HTuple composedFile)
		{
			HOperatorSet.ConcatOcrTrainf(singleFiles, composedFile);
		}
		public static void WriteOcrTrainfImage (HObject character, HTuple classVal, HTuple trainingFile)
		{
			HOperatorSet.WriteOcrTrainfImage(character, classVal, trainingFile);
		}
		public static void AppendOcrTrainf (HObject character, HObject image, HTuple classVal, HTuple trainingFile)
		{
			HOperatorSet.AppendOcrTrainf(character, image, classVal, trainingFile);
		}
		public static (HTuple characterNames, HTuple characterCount) ReadOcrTrainfNamesProtected (HTuple trainingFile, HTuple password)
		{
			HOperatorSet.ReadOcrTrainfNamesProtected(trainingFile, password, out HTuple characterNames, out HTuple characterCount);
			return (characterNames,characterCount);
		}
		public static (HTuple characterNames, HTuple characterCount) ReadOcrTrainfNames (HTuple trainingFile)
		{
			HOperatorSet.ReadOcrTrainfNames(trainingFile, out HTuple characterNames, out HTuple characterCount);
			return (characterNames,characterCount);
		}
		public static (HObject characters, HTuple foundNames) ReadOcrTrainfSelect (HTuple trainingFile, HTuple searchNames)
		{
			HOperatorSet.ReadOcrTrainfSelect(out HObject characters, trainingFile, searchNames, out HTuple foundNames);
			return (characters,foundNames);
		}
		public static (HObject characters, HTuple characterNames) ReadOcrTrainf (HTuple trainingFile)
		{
			HOperatorSet.ReadOcrTrainf(out HObject characters, trainingFile, out HTuple characterNames);
			return (characters,characterNames);
		}
		public static HObject Pruning (HObject region, HTuple length)
		{
			HOperatorSet.Pruning(region, out HObject regionPrune, length);
			return regionPrune;
		}
		public static HObject Boundary (HObject region, HTuple boundaryType)
		{
			HOperatorSet.Boundary(region, out HObject regionBorder, boundaryType);
			return regionBorder;
		}
		public static HObject Fitting (HObject region, HObject structElements)
		{
			HOperatorSet.Fitting(region, structElements, out HObject regionFitted);
			return regionFitted;
		}
		public static HObject GenStructElements (HTuple type, HTuple row, HTuple column)
		{
			HOperatorSet.GenStructElements(out HObject structElements, type, row, column);
			return structElements;
		}
		public static HObject TransposeRegion (HObject region, HTuple row, HTuple column)
		{
			HOperatorSet.TransposeRegion(region, out HObject transposed, row, column);
			return transposed;
		}
		public static HObject ThinningSeq (HObject region, HTuple golayElement, HTuple iterations)
		{
			HOperatorSet.ThinningSeq(region, out HObject regionThin, golayElement, iterations);
			return regionThin;
		}
		public static HObject ThinningGolay (HObject region, HTuple golayElement, HTuple rotation)
		{
			HOperatorSet.ThinningGolay(region, out HObject regionThin, golayElement, rotation);
			return regionThin;
		}
		public static HObject Thinning (HObject region, HObject structElement1, HObject structElement2, HTuple row, HTuple column, HTuple iterations)
		{
			HOperatorSet.Thinning(region, structElement1, structElement2, out HObject regionThin, row, column, iterations);
			return regionThin;
		}
		public static HObject ThickeningSeq (HObject region, HTuple golayElement, HTuple iterations)
		{
			HOperatorSet.ThickeningSeq(region, out HObject regionThick, golayElement, iterations);
			return regionThick;
		}
		public static HObject ThickeningGolay (HObject region, HTuple golayElement, HTuple rotation)
		{
			HOperatorSet.ThickeningGolay(region, out HObject regionThick, golayElement, rotation);
			return regionThick;
		}
		public static HObject Thickening (HObject region, HObject structElement1, HObject structElement2, HTuple row, HTuple column, HTuple iterations)
		{
			HOperatorSet.Thickening(region, structElement1, structElement2, out HObject regionThick, row, column, iterations);
			return regionThick;
		}
		public static HObject HitOrMissSeq (HObject region, HTuple golayElement)
		{
			HOperatorSet.HitOrMissSeq(region, out HObject regionHitMiss, golayElement);
			return regionHitMiss;
		}
		public static HObject HitOrMissGolay (HObject region, HTuple golayElement, HTuple rotation)
		{
			HOperatorSet.HitOrMissGolay(region, out HObject regionHitMiss, golayElement, rotation);
			return regionHitMiss;
		}
		public static HObject HitOrMiss (HObject region, HObject structElement1, HObject structElement2, HTuple row, HTuple column)
		{
			HOperatorSet.HitOrMiss(region, structElement1, structElement2, out HObject regionHitMiss, row, column);
			return regionHitMiss;
		}
		public static (HObject structElement1, HObject structElement2) GolayElements (HTuple golayElement, HTuple rotation, HTuple row, HTuple column)
		{
			HOperatorSet.GolayElements(out HObject structElement1, out HObject structElement2, golayElement, rotation, row, column);
			return (structElement1,structElement2);
		}
		public static HObject MorphSkiz (HObject region, HTuple iterations1, HTuple iterations2)
		{
			HOperatorSet.MorphSkiz(region, out HObject regionSkiz, iterations1, iterations2);
			return regionSkiz;
		}
		public static HObject MorphSkeleton (HObject region)
		{
			HOperatorSet.MorphSkeleton(region, out HObject regionSkeleton);
			return regionSkeleton;
		}
		public static HObject MorphHat (HObject region, HObject structElement)
		{
			HOperatorSet.MorphHat(region, structElement, out HObject regionMorphHat);
			return regionMorphHat;
		}
		public static HObject BottomHat (HObject region, HObject structElement)
		{
			HOperatorSet.BottomHat(region, structElement, out HObject regionBottomHat);
			return regionBottomHat;
		}
		public static HObject TopHat (HObject region, HObject structElement)
		{
			HOperatorSet.TopHat(region, structElement, out HObject regionTopHat);
			return regionTopHat;
		}
		public static HObject MinkowskiSub2 (HObject region, HObject structElement, HTuple row, HTuple column, HTuple iterations)
		{
			HOperatorSet.MinkowskiSub2(region, structElement, out HObject regionMinkSub, row, column, iterations);
			return regionMinkSub;
		}
		public static HObject MinkowskiSub1 (HObject region, HObject structElement, HTuple iterations)
		{
			HOperatorSet.MinkowskiSub1(region, structElement, out HObject regionMinkSub, iterations);
			return regionMinkSub;
		}
		public static HObject MinkowskiAdd2 (HObject region, HObject structElement, HTuple row, HTuple column, HTuple iterations)
		{
			HOperatorSet.MinkowskiAdd2(region, structElement, out HObject regionMinkAdd, row, column, iterations);
			return regionMinkAdd;
		}
		public static HObject MinkowskiAdd1 (HObject region, HObject structElement, HTuple iterations)
		{
			HOperatorSet.MinkowskiAdd1(region, structElement, out HObject regionMinkAdd, iterations);
			return regionMinkAdd;
		}
		public static HObject ClosingRectangle1 (HObject region, HTuple width, HTuple height)
		{
			HOperatorSet.ClosingRectangle1(region, out HObject regionClosing, width, height);
			return regionClosing;
		}
		public static HObject ClosingGolay (HObject region, HTuple golayElement, HTuple rotation)
		{
			HOperatorSet.ClosingGolay(region, out HObject regionClosing, golayElement, rotation);
			return regionClosing;
		}
		public static HObject ClosingCircle (HObject region, HTuple radius)
		{
			HOperatorSet.ClosingCircle(region, out HObject regionClosing, radius);
			return regionClosing;
		}
		public static HObject Closing (HObject region, HObject structElement)
		{
			HOperatorSet.Closing(region, structElement, out HObject regionClosing);
			return regionClosing;
		}
		public static HObject OpeningSeg (HObject region, HObject structElement)
		{
			HOperatorSet.OpeningSeg(region, structElement, out HObject regionOpening);
			return regionOpening;
		}
		public static HObject OpeningGolay (HObject region, HTuple golayElement, HTuple rotation)
		{
			HOperatorSet.OpeningGolay(region, out HObject regionOpening, golayElement, rotation);
			return regionOpening;
		}
		public static HObject OpeningRectangle1 (HObject region, HTuple width, HTuple height)
		{
			HOperatorSet.OpeningRectangle1(region, out HObject regionOpening, width, height);
			return regionOpening;
		}
		public static HObject OpeningCircle (HObject region, HTuple radius)
		{
			HOperatorSet.OpeningCircle(region, out HObject regionOpening, radius);
			return regionOpening;
		}
		public static HObject Opening (HObject region, HObject structElement)
		{
			HOperatorSet.Opening(region, structElement, out HObject regionOpening);
			return regionOpening;
		}
		public static HObject SplitSkeletonRegion (HObject skeletonRegion, HTuple maxDistance)
		{
			HOperatorSet.SplitSkeletonRegion(skeletonRegion, out HObject regionLines, maxDistance);
			return regionLines;
		}
		public static HObject GenRegionHisto (HTuple histogram, HTuple row, HTuple column, HTuple scale)
		{
			HOperatorSet.GenRegionHisto(out HObject region, histogram, row, column, scale);
			return region;
		}
		public static HObject EliminateRuns (HObject region, HTuple elimShorter, HTuple elimLonger)
		{
			HOperatorSet.EliminateRuns(region, out HObject regionClipped, elimShorter, elimLonger);
			return regionClipped;
		}
		public static HTuple SurfaceNormalsObjectModel3d (HTuple objectModel3D, HTuple method, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SurfaceNormalsObjectModel3d(objectModel3D, method, genParamName, genParamValue, out HTuple objectModel3DNormals);
			return objectModel3DNormals;
		}
		public static HTuple SmoothObjectModel3d (HTuple objectModel3D, HTuple method, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SmoothObjectModel3d(objectModel3D, method, genParamName, genParamValue, out HTuple smoothObjectModel3D);
			return smoothObjectModel3D;
		}
		public static (HTuple triangulatedObjectModel3D, HTuple information) TriangulateObjectModel3d (HTuple objectModel3D, HTuple method, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.TriangulateObjectModel3d(objectModel3D, method, genParamName, genParamValue, out HTuple triangulatedObjectModel3D, out HTuple information);
			return (triangulatedObjectModel3D,information);
		}
		public static void ClearAllStereoModels ()
		{
			HOperatorSet.ClearAllStereoModels();
		}
		public static void ClearStereoModel (HTuple stereoModelID)
		{
			HOperatorSet.ClearStereoModel(stereoModelID);
		}
		public static (HTuple x, HTuple y, HTuple z, HTuple covWP, HTuple pointIdxOut) ReconstructPointsStereo (HTuple stereoModelID, HTuple row, HTuple column, HTuple covIP, HTuple cameraIdx, HTuple pointIdx)
		{
			HOperatorSet.ReconstructPointsStereo(stereoModelID, row, column, covIP, cameraIdx, pointIdx, out HTuple x, out HTuple y, out HTuple z, out HTuple covWP, out HTuple pointIdxOut);
			return (x,y,z,covWP,pointIdxOut);
		}
		public static HTuple ReconstructSurfaceStereo (HObject images, HTuple stereoModelID)
		{
			HOperatorSet.ReconstructSurfaceStereo(images, stereoModelID, out HTuple objectModel3D);
			return objectModel3D;
		}
		public static HObject GetStereoModelObject (HTuple stereoModelID, HTuple pairIndex, HTuple objectName)
		{
			HOperatorSet.GetStereoModelObject(out HObject objectVal, stereoModelID, pairIndex, objectName);
			return objectVal;
		}
		public static (HTuple from, HTuple to) GetStereoModelImagePairs (HTuple stereoModelID)
		{
			HOperatorSet.GetStereoModelImagePairs(stereoModelID, out HTuple from, out HTuple to);
			return (from,to);
		}
		public static void SetStereoModelImagePairs (HTuple stereoModelID, HTuple from, HTuple to)
		{
			HOperatorSet.SetStereoModelImagePairs(stereoModelID, from, to);
		}
		public static HTuple GetStereoModelParam (HTuple stereoModelID, HTuple genParamName)
		{
			HOperatorSet.GetStereoModelParam(stereoModelID, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetStereoModelParam (HTuple stereoModelID, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetStereoModelParam(stereoModelID, genParamName, genParamValue);
		}
		public static HTuple CreateStereoModel (HTuple cameraSetupModelID, HTuple method, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateStereoModel(cameraSetupModelID, method, genParamName, genParamValue, out HTuple stereoModelID);
			return stereoModelID;
		}
		public static HTuple GetMessageQueueParam (HTuple queueHandle, HTuple genParamName)
		{
			HOperatorSet.GetMessageQueueParam(queueHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetMessageQueueParam (HTuple queueHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetMessageQueueParam(queueHandle, genParamName, genParamValue);
		}
		public static HTuple DequeueMessage (HTuple queueHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.DequeueMessage(queueHandle, genParamName, genParamValue, out HTuple messageHandle);
			return messageHandle;
		}
		public static void EnqueueMessage (HTuple queueHandle, HTuple messageHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.EnqueueMessage(queueHandle, messageHandle, genParamName, genParamValue);
		}
		public static void ClearMessageQueue (HTuple queueHandle)
		{
			HOperatorSet.ClearMessageQueue(queueHandle);
		}
		public static HTuple CreateMessageQueue ()
		{
			HOperatorSet.CreateMessageQueue(out HTuple queueHandle);
			return queueHandle;
		}
		public static HTuple GetMessageParam (HTuple messageHandle, HTuple genParamName, HTuple key)
		{
			HOperatorSet.GetMessageParam(messageHandle, genParamName, key, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetMessageParam (HTuple messageHandle, HTuple genParamName, HTuple key, HTuple genParamValue)
		{
			HOperatorSet.SetMessageParam(messageHandle, genParamName, key, genParamValue);
		}
		public static HObject GetMessageObj (HTuple messageHandle, HTuple key)
		{
			HOperatorSet.GetMessageObj(out HObject objectData, messageHandle, key);
			return objectData;
		}
		public static void SetMessageObj (HObject objectData, HTuple messageHandle, HTuple key)
		{
			HOperatorSet.SetMessageObj(objectData, messageHandle, key);
		}
		public static HTuple GetMessageTuple (HTuple messageHandle, HTuple key)
		{
			HOperatorSet.GetMessageTuple(messageHandle, key, out HTuple tupleData);
			return tupleData;
		}
		public static void SetMessageTuple (HTuple messageHandle, HTuple key, HTuple tupleData)
		{
			HOperatorSet.SetMessageTuple(messageHandle, key, tupleData);
		}
		public static void ClearMessage (HTuple messageHandle)
		{
			HOperatorSet.ClearMessage(messageHandle);
		}
		public static HTuple CreateMessage ()
		{
			HOperatorSet.CreateMessage(out HTuple messageHandle);
			return messageHandle;
		}
		public static void ClearAllConditions ()
		{
			HOperatorSet.ClearAllConditions();
		}
		public static void ClearCondition (HTuple conditionHandle)
		{
			HOperatorSet.ClearCondition(conditionHandle);
		}
		public static void BroadcastCondition (HTuple conditionHandle)
		{
			HOperatorSet.BroadcastCondition(conditionHandle);
		}
		public static void SignalCondition (HTuple conditionHandle)
		{
			HOperatorSet.SignalCondition(conditionHandle);
		}
		public static void TimedWaitCondition (HTuple conditionHandle, HTuple mutexHandle, HTuple timeout)
		{
			HOperatorSet.TimedWaitCondition(conditionHandle, mutexHandle, timeout);
		}
		public static void WaitCondition (HTuple conditionHandle, HTuple mutexHandle)
		{
			HOperatorSet.WaitCondition(conditionHandle, mutexHandle);
		}
		public static HTuple CreateCondition (HTuple attribName, HTuple attribValue)
		{
			HOperatorSet.CreateCondition(attribName, attribValue, out HTuple conditionHandle);
			return conditionHandle;
		}
		public static void ClearAllBarriers ()
		{
			HOperatorSet.ClearAllBarriers();
		}
		public static void ClearBarrier (HTuple barrierHandle)
		{
			HOperatorSet.ClearBarrier(barrierHandle);
		}
		public static void WaitBarrier (HTuple barrierHandle)
		{
			HOperatorSet.WaitBarrier(barrierHandle);
		}
		public static HTuple CreateBarrier (HTuple attribName, HTuple attribValue, HTuple teamSize)
		{
			HOperatorSet.CreateBarrier(attribName, attribValue, teamSize, out HTuple barrierHandle);
			return barrierHandle;
		}
		public static void ClearAllEvents ()
		{
			HOperatorSet.ClearAllEvents();
		}
		public static void ClearEvent (HTuple eventHandle)
		{
			HOperatorSet.ClearEvent(eventHandle);
		}
		public static void SignalEvent (HTuple eventHandle)
		{
			HOperatorSet.SignalEvent(eventHandle);
		}
		public static HTuple TryWaitEvent (HTuple eventHandle)
		{
			HOperatorSet.TryWaitEvent(eventHandle, out HTuple busy);
			return busy;
		}
		public static void WaitEvent (HTuple eventHandle)
		{
			HOperatorSet.WaitEvent(eventHandle);
		}
		public static HTuple CreateEvent (HTuple attribName, HTuple attribValue)
		{
			HOperatorSet.CreateEvent(attribName, attribValue, out HTuple eventHandle);
			return eventHandle;
		}
		public static void ClearAllMutexes ()
		{
			HOperatorSet.ClearAllMutexes();
		}
		public static void ClearMutex (HTuple mutexHandle)
		{
			HOperatorSet.ClearMutex(mutexHandle);
		}
		public static void UnlockMutex (HTuple mutexHandle)
		{
			HOperatorSet.UnlockMutex(mutexHandle);
		}
		public static HTuple TryLockMutex (HTuple mutexHandle)
		{
			HOperatorSet.TryLockMutex(mutexHandle, out HTuple busy);
			return busy;
		}
		public static void LockMutex (HTuple mutexHandle)
		{
			HOperatorSet.LockMutex(mutexHandle);
		}
		public static HTuple CreateMutex (HTuple attribName, HTuple attribValue)
		{
			HOperatorSet.CreateMutex(attribName, attribValue, out HTuple mutexHandle);
			return mutexHandle;
		}
		public static (HTuple threadingClass, HTuple attribName, HTuple attribValue) GetThreadingAttrib (HTuple threadingHandle)
		{
			HOperatorSet.GetThreadingAttrib(threadingHandle, out HTuple threadingClass, out HTuple attribName, out HTuple attribValue);
			return (threadingClass,attribName,attribValue);
		}
		public static void SetAopInfo (HTuple operatorName, HTuple indexName, HTuple indexValue, HTuple infoName, HTuple infoValue)
		{
			HOperatorSet.SetAopInfo(operatorName, indexName, indexValue, infoName, infoValue);
		}
		public static HTuple GetAopInfo (HTuple operatorName, HTuple indexName, HTuple indexValue, HTuple infoName)
		{
			HOperatorSet.GetAopInfo(operatorName, indexName, indexValue, infoName, out HTuple infoValue);
			return infoValue;
		}
		public static (HTuple name, HTuple value) QueryAopInfo (HTuple operatorName, HTuple indexName, HTuple indexValue)
		{
			HOperatorSet.QueryAopInfo(operatorName, indexName, indexValue, out HTuple name, out HTuple value);
			return (name,value);
		}
		public static void OptimizeAop (HTuple operatorName, HTuple iconicType, HTuple fileName, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.OptimizeAop(operatorName, iconicType, fileName, genParamName, genParamValue);
		}
		public static void WriteAopKnowledge (HTuple fileName, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.WriteAopKnowledge(fileName, genParamName, genParamValue);
		}
		public static (HTuple attributes, HTuple operatorNames) ReadAopKnowledge (HTuple fileName, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.ReadAopKnowledge(fileName, genParamName, genParamValue, out HTuple attributes, out HTuple operatorNames);
			return (attributes,operatorNames);
		}
		public static HObject TestAccess (HObject objectVal, HTuple numReadChord, HTuple numCopyObj, HTuple writeChord)
		{
			HOperatorSet.TestAccess(objectVal, out HObject dummy, numReadChord, numCopyObj, writeChord);
			return dummy;
		}
		public static HObject ObjDiff (HObject objects, HObject objectsSub)
		{
			HOperatorSet.ObjDiff(objects, objectsSub, out HObject objectsDiff);
			return objectsDiff;
		}
		public static void SetGrayval (HObject image, HTuple row, HTuple column, HTuple grayval)
		{
			HOperatorSet.SetGrayval(image, row, column, grayval);
		}
		public static HObject PaintXld (HObject XLD, HObject image, HTuple grayval)
		{
			HOperatorSet.PaintXld(XLD, image, out HObject imageResult, grayval);
			return imageResult;
		}
		public static HObject PaintRegion (HObject region, HObject image, HTuple grayval, HTuple type)
		{
			HOperatorSet.PaintRegion(region, image, out HObject imageResult, grayval, type);
			return imageResult;
		}
		public static void OverpaintRegion (HObject image, HObject region, HTuple grayval, HTuple type)
		{
			HOperatorSet.OverpaintRegion(image, region, grayval, type);
		}
		public static HObject GenImageProto (HObject image, HTuple grayval)
		{
			HOperatorSet.GenImageProto(image, out HObject imageCleared, grayval);
			return imageCleared;
		}
		public static HObject PaintGray (HObject imageSource, HObject imageDestination)
		{
			HOperatorSet.PaintGray(imageSource, imageDestination, out HObject mixedImage);
			return mixedImage;
		}
		public static void OverpaintGray (HObject imageDestination, HObject imageSource)
		{
			HOperatorSet.OverpaintGray(imageDestination, imageSource);
		}
		public static HObject IntegerToObj (HTuple surrogateTuple)
		{
			HOperatorSet.IntegerToObj(out HObject objects, surrogateTuple);
			return objects;
		}
		public static HTuple ObjToInteger (HObject objects, HTuple index, HTuple number)
		{
			HOperatorSet.ObjToInteger(objects, index, number, out HTuple surrogateTuple);
			return surrogateTuple;
		}
		public static HObject CopyObj (HObject objects, HTuple index, HTuple numObj)
		{
			HOperatorSet.CopyObj(objects, out HObject objectsSelected, index, numObj);
			return objectsSelected;
		}
		public static HObject ConcatObj (HObject objects1, HObject objects2)
		{
			HOperatorSet.ConcatObj(objects1, objects2, out HObject objectsConcat);
			return objectsConcat;
		}
		public static void ClearObj (HObject objects)
		{
			HOperatorSet.ClearObj(objects);
		}
		public static HObject CopyImage (HObject image)
		{
			HOperatorSet.CopyImage(image, out HObject dupImage);
			return dupImage;
		}
		public static HObject SelectObj (HObject objects, HTuple index)
		{
			HOperatorSet.SelectObj(objects, out HObject objectSelected, index);
			return objectSelected;
		}
		public static HTuple CompareObj (HObject objects1, HObject objects2, HTuple epsilon)
		{
			HOperatorSet.CompareObj(objects1, objects2, epsilon, out HTuple isEqual);
			return isEqual;
		}
		public static HTuple TestSubsetRegion (HObject region1, HObject region2)
		{
			HOperatorSet.TestSubsetRegion(region1, region2, out HTuple isSubset);
			return isSubset;
		}
		public static HTuple TestEqualRegion (HObject regions1, HObject regions2)
		{
			HOperatorSet.TestEqualRegion(regions1, regions2, out HTuple isEqual);
			return isEqual;
		}
		public static HTuple TestEqualObj (HObject objects1, HObject objects2)
		{
			HOperatorSet.TestEqualObj(objects1, objects2, out HTuple isEqual);
			return isEqual;
		}
		public static HTuple CountObj (HObject objects)
		{
			HOperatorSet.CountObj(objects, out HTuple number);
			return number;
		}
		public static HTuple GetChannelInfo (HObject objectVal, HTuple request, HTuple channel)
		{
			HOperatorSet.GetChannelInfo(objectVal, request, channel, out HTuple information);
			return information;
		}
		public static HTuple GetObjClass (HObject objectVal)
		{
			HOperatorSet.GetObjClass(objectVal, out HTuple classVal);
			return classVal;
		}
		public static HObject GenImageInterleaved (HTuple pixelPointer, HTuple colorFormat, HTuple originalWidth, HTuple originalHeight, HTuple alignment, HTuple type, HTuple imageWidth, HTuple imageHeight, HTuple startRow, HTuple startColumn, HTuple bitsPerChannel, HTuple bitShift)
		{
			HOperatorSet.GenImageInterleaved(out HObject imageRGB, pixelPointer, colorFormat, originalWidth, originalHeight, alignment, type, imageWidth, imageHeight, startRow, startColumn, bitsPerChannel, bitShift);
			return imageRGB;
		}
		public static HObject GenRegionPolygonXld (HObject polygon, HTuple mode)
		{
			HOperatorSet.GenRegionPolygonXld(polygon, out HObject region, mode);
			return region;
		}
		public static HObject GenRegionContourXld (HObject contour, HTuple mode)
		{
			HOperatorSet.GenRegionContourXld(contour, out HObject region, mode);
			return region;
		}
		public static HObject GenRegionPolygonFilled (HTuple rows, HTuple columns)
		{
			HOperatorSet.GenRegionPolygonFilled(out HObject region, rows, columns);
			return region;
		}
		public static HObject GenRegionPolygon (HTuple rows, HTuple columns)
		{
			HOperatorSet.GenRegionPolygon(out HObject region, rows, columns);
			return region;
		}
		public static HObject GenRegionPoints (HTuple rows, HTuple columns)
		{
			HOperatorSet.GenRegionPoints(out HObject region, rows, columns);
			return region;
		}
		public static HObject GenRegionRuns (HTuple row, HTuple columnBegin, HTuple columnEnd)
		{
			HOperatorSet.GenRegionRuns(out HObject region, row, columnBegin, columnEnd);
			return region;
		}
		public static HObject GenRectangle2 (HTuple row, HTuple column, HTuple phi, HTuple length1, HTuple length2)
		{
			HOperatorSet.GenRectangle2(out HObject rectangle, row, column, phi, length1, length2);
			return rectangle;
		}
		public static HObject GenRectangle1 (HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.GenRectangle1(out HObject rectangle, row1, column1, row2, column2);
			return rectangle;
		}
		public static HObject GenRandomRegion (HTuple width, HTuple height)
		{
			HOperatorSet.GenRandomRegion(out HObject regionRandom, width, height);
			return regionRandom;
		}
		public static HObject GenImage3 (HTuple type, HTuple width, HTuple height, HTuple pixelPointerRed, HTuple pixelPointerGreen, HTuple pixelPointerBlue)
		{
			HOperatorSet.GenImage3(out HObject imageRGB, type, width, height, pixelPointerRed, pixelPointerGreen, pixelPointerBlue);
			return imageRGB;
		}
		public static HObject GenImage1 (HTuple type, HTuple width, HTuple height, HTuple pixelPointer)
		{
			HOperatorSet.GenImage1(out HObject image, type, width, height, pixelPointer);
			return image;
		}
		public static HObject GenImageConst (HTuple type, HTuple width, HTuple height)
		{
			HOperatorSet.GenImageConst(out HObject image, type, width, height);
			return image;
		}
		public static HObject GenEllipseSector (HTuple row, HTuple column, HTuple phi, HTuple radius1, HTuple radius2, HTuple startAngle, HTuple endAngle)
		{
			HOperatorSet.GenEllipseSector(out HObject ellipseSector, row, column, phi, radius1, radius2, startAngle, endAngle);
			return ellipseSector;
		}
		public static HObject GenEllipse (HTuple row, HTuple column, HTuple phi, HTuple radius1, HTuple radius2)
		{
			HOperatorSet.GenEllipse(out HObject ellipse, row, column, phi, radius1, radius2);
			return ellipse;
		}
		public static HObject GenCircleSector (HTuple row, HTuple column, HTuple radius, HTuple startAngle, HTuple endAngle)
		{
			HOperatorSet.GenCircleSector(out HObject circleSector, row, column, radius, startAngle, endAngle);
			return circleSector;
		}
		public static HObject GenCircle (HTuple row, HTuple column, HTuple radius)
		{
			HOperatorSet.GenCircle(out HObject circle, row, column, radius);
			return circle;
		}
		public static HObject GenCheckerRegion (HTuple widthRegion, HTuple heightRegion, HTuple widthPattern, HTuple heightPattern)
		{
			HOperatorSet.GenCheckerRegion(out HObject regionChecker, widthRegion, heightRegion, widthPattern, heightPattern);
			return regionChecker;
		}
		public static HObject GenGridRegion (HTuple rowSteps, HTuple columnSteps, HTuple type, HTuple width, HTuple height)
		{
			HOperatorSet.GenGridRegion(out HObject regionGrid, rowSteps, columnSteps, type, width, height);
			return regionGrid;
		}
		public static HObject GenRandomRegions (HTuple type, HTuple widthMin, HTuple widthMax, HTuple heightMin, HTuple heightMax, HTuple phiMin, HTuple phiMax, HTuple numRegions, HTuple width, HTuple height)
		{
			HOperatorSet.GenRandomRegions(out HObject regions, type, widthMin, widthMax, heightMin, heightMax, phiMin, phiMax, numRegions, width, height);
			return regions;
		}
		public static HObject GenRegionHline (HTuple orientation, HTuple distance)
		{
			HOperatorSet.GenRegionHline(out HObject regions, orientation, distance);
			return regions;
		}
		public static HObject GenRegionLine (HTuple beginRow, HTuple beginCol, HTuple endRow, HTuple endCol)
		{
			HOperatorSet.GenRegionLine(out HObject regionLines, beginRow, beginCol, endRow, endCol);
			return regionLines;
		}
		public static HObject GenEmptyObj ()
		{
			HOperatorSet.GenEmptyObj(out HObject emptyObject);
			return emptyObject;
		}
		public static HObject GenEmptyRegion ()
		{
			HOperatorSet.GenEmptyRegion(out HObject emptyRegion);
			return emptyRegion;
		}
		public static HObject GenImageGrayRamp (HTuple alpha, HTuple beta, HTuple mean, HTuple row, HTuple column, HTuple width, HTuple height)
		{
			HOperatorSet.GenImageGrayRamp(out HObject imageGrayRamp, alpha, beta, mean, row, column, width, height);
			return imageGrayRamp;
		}
		public static HObject GenImage3Extern (HTuple type, HTuple width, HTuple height, HTuple pointerRed, HTuple pointerGreen, HTuple pointerBlue, HTuple clearProc)
		{
			HOperatorSet.GenImage3Extern(out HObject image, type, width, height, pointerRed, pointerGreen, pointerBlue, clearProc);
			return image;
		}
		public static HObject GenImage1Extern (HTuple type, HTuple width, HTuple height, HTuple pixelPointer, HTuple clearProc)
		{
			HOperatorSet.GenImage1Extern(out HObject image, type, width, height, pixelPointer, clearProc);
			return image;
		}
		public static HObject GenImage1Rect (HTuple pixelPointer, HTuple width, HTuple height, HTuple verticalPitch, HTuple horizontalBitPitch, HTuple bitsPerPixel, HTuple doCopy, HTuple clearProc)
		{
			HOperatorSet.GenImage1Rect(out HObject image, pixelPointer, width, height, verticalPitch, horizontalBitPitch, bitsPerPixel, doCopy, clearProc);
			return image;
		}
		public static (HTuple pixelPointer, HTuple width, HTuple height, HTuple verticalPitch, HTuple horizontalBitPitch, HTuple bitsPerPixel) GetImagePointer1Rect (HObject image)
		{
			HOperatorSet.GetImagePointer1Rect(image, out HTuple pixelPointer, out HTuple width, out HTuple height, out HTuple verticalPitch, out HTuple horizontalBitPitch, out HTuple bitsPerPixel);
			return (pixelPointer,width,height,verticalPitch,horizontalBitPitch,bitsPerPixel);
		}
		public static (HTuple pointerRed, HTuple pointerGreen, HTuple pointerBlue, HTuple type, HTuple width, HTuple height) GetImagePointer3 (HObject imageRGB)
		{
			HOperatorSet.GetImagePointer3(imageRGB, out HTuple pointerRed, out HTuple pointerGreen, out HTuple pointerBlue, out HTuple type, out HTuple width, out HTuple height);
			return (pointerRed,pointerGreen,pointerBlue,type,width,height);
		}
		public static (HTuple pointer, HTuple type, HTuple width, HTuple height) GetImagePointer1 (HObject image)
		{
			HOperatorSet.GetImagePointer1(image, out HTuple pointer, out HTuple type, out HTuple width, out HTuple height);
			return (pointer,type,width,height);
		}
		public static HTuple GetImageType (HObject image)
		{
			HOperatorSet.GetImageType(image, out HTuple type);
			return type;
		}
		public static (HTuple width, HTuple height) GetImageSize (HObject image)
		{
			HOperatorSet.GetImageSize(image, out HTuple width, out HTuple height);
			return (width,height);
		}
		public static (HTuple MSecond, HTuple second, HTuple minute, HTuple hour, HTuple day, HTuple YDay, HTuple month, HTuple year) GetImageTime (HObject image)
		{
			HOperatorSet.GetImageTime(image, out HTuple MSecond, out HTuple second, out HTuple minute, out HTuple hour, out HTuple day, out HTuple YDay, out HTuple month, out HTuple year);
			return (MSecond,second,minute,hour,day,YDay,month,year);
		}
		public static HTuple GetGrayvalInterpolated (HObject image, HTuple row, HTuple column, HTuple interpolation)
		{
			HOperatorSet.GetGrayvalInterpolated(image, row, column, interpolation, out HTuple grayval);
			return grayval;
		}
		public static HTuple GetGrayval (HObject image, HTuple row, HTuple column)
		{
			HOperatorSet.GetGrayval(image, row, column, out HTuple grayval);
			return grayval;
		}
		public static (HTuple thickness, HTuple histogramm) GetRegionThickness (HObject region)
		{
			HOperatorSet.GetRegionThickness(region, out HTuple thickness, out HTuple histogramm);
			return (thickness,histogramm);
		}
		public static (HTuple rows, HTuple columns) GetRegionPolygon (HObject region, HTuple tolerance)
		{
			HOperatorSet.GetRegionPolygon(region, tolerance, out HTuple rows, out HTuple columns);
			return (rows,columns);
		}
		public static (HTuple rows, HTuple columns) GetRegionPoints (HObject region)
		{
			HOperatorSet.GetRegionPoints(region, out HTuple rows, out HTuple columns);
			return (rows,columns);
		}
		public static (HTuple rows, HTuple columns) GetRegionContour (HObject region)
		{
			HOperatorSet.GetRegionContour(region, out HTuple rows, out HTuple columns);
			return (rows,columns);
		}
		public static (HTuple row, HTuple columnBegin, HTuple columnEnd) GetRegionRuns (HObject region)
		{
			HOperatorSet.GetRegionRuns(region, out HTuple row, out HTuple columnBegin, out HTuple columnEnd);
			return (row,columnBegin,columnEnd);
		}
		public static (HTuple row, HTuple column, HTuple chain) GetRegionChain (HObject region)
		{
			HOperatorSet.GetRegionChain(region, out HTuple row, out HTuple column, out HTuple chain);
			return (row,column,chain);
		}
		public static (HTuple rows, HTuple columns) GetRegionConvex (HObject region)
		{
			HOperatorSet.GetRegionConvex(region, out HTuple rows, out HTuple columns);
			return (rows,columns);
		}
		public static HTuple DoOcvSimple (HObject pattern, HTuple OCVHandle, HTuple patternName, HTuple adaptPos, HTuple adaptSize, HTuple adaptAngle, HTuple adaptGray, HTuple threshold)
		{
			HOperatorSet.DoOcvSimple(pattern, OCVHandle, patternName, adaptPos, adaptSize, adaptAngle, adaptGray, threshold, out HTuple quality);
			return quality;
		}
		public static void TraindOcvProj (HObject pattern, HTuple OCVHandle, HTuple name, HTuple mode)
		{
			HOperatorSet.TraindOcvProj(pattern, OCVHandle, name, mode);
		}
		public static void MeasureProfileSheetOfLight (HObject profileImage, HTuple sheetOfLightModelID, HTuple movementPose)
		{
			HOperatorSet.MeasureProfileSheetOfLight(profileImage, sheetOfLightModelID, movementPose);
		}
		public static void SetSheetOfLightParam (HTuple sheetOfLightModelID, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetSheetOfLightParam(sheetOfLightModelID, genParamName, genParamValue);
		}
		public static HTuple GetSheetOfLightParam (HTuple sheetOfLightModelID, HTuple genParamName)
		{
			HOperatorSet.GetSheetOfLightParam(sheetOfLightModelID, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static HTuple QuerySheetOfLightParams (HTuple sheetOfLightModelID, HTuple queryName)
		{
			HOperatorSet.QuerySheetOfLightParams(sheetOfLightModelID, queryName, out HTuple genParamName);
			return genParamName;
		}
		public static void ResetSheetOfLightModel (HTuple sheetOfLightModelID)
		{
			HOperatorSet.ResetSheetOfLightModel(sheetOfLightModelID);
		}
		public static void ClearAllSheetOfLightModels ()
		{
			HOperatorSet.ClearAllSheetOfLightModels();
		}
		public static void ClearSheetOfLightModel (HTuple sheetOfLightModelID)
		{
			HOperatorSet.ClearSheetOfLightModel(sheetOfLightModelID);
		}
		public static HTuple CreateSheetOfLightModel (HObject profileRegion, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateSheetOfLightModel(profileRegion, genParamName, genParamValue, out HTuple sheetOfLightModelID);
			return sheetOfLightModelID;
		}
		public static HObject ShadeHeightField (HObject imageHeight, HTuple slant, HTuple tilt, HTuple albedo, HTuple ambient, HTuple shadows)
		{
			HOperatorSet.ShadeHeightField(imageHeight, out HObject imageShade, slant, tilt, albedo, ambient, shadows);
			return imageShade;
		}
		public static (HTuple albedo, HTuple ambient) EstimateAlAm (HObject image)
		{
			HOperatorSet.EstimateAlAm(image, out HTuple albedo, out HTuple ambient);
			return (albedo,ambient);
		}
		public static (HTuple slant, HTuple albedo) EstimateSlAlZc (HObject image)
		{
			HOperatorSet.EstimateSlAlZc(image, out HTuple slant, out HTuple albedo);
			return (slant,albedo);
		}
		public static (HTuple slant, HTuple albedo) EstimateSlAlLr (HObject image)
		{
			HOperatorSet.EstimateSlAlLr(image, out HTuple slant, out HTuple albedo);
			return (slant,albedo);
		}
		public static HTuple EstimateTiltZc (HObject image)
		{
			HOperatorSet.EstimateTiltZc(image, out HTuple tilt);
			return tilt;
		}
		public static HTuple EstimateTiltLr (HObject image)
		{
			HOperatorSet.EstimateTiltLr(image, out HTuple tilt);
			return tilt;
		}
		public static HObject ReconstructHeightFieldFromGradient (HObject gradient, HTuple reconstructionMethod, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.ReconstructHeightFieldFromGradient(gradient, out HObject heightField, reconstructionMethod, genParamName, genParamValue);
			return heightField;
		}
		public static (HObject heightField, HObject gradient, HObject albedo) PhotometricStereo (HObject images, HTuple slants, HTuple tilts, HTuple resultType, HTuple reconstructionMethod, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.PhotometricStereo(images, out HObject heightField, out HObject gradient, out HObject albedo, slants, tilts, resultType, reconstructionMethod, genParamName, genParamValue);
			return (heightField,gradient,albedo);
		}
		public static HObject SfsPentland (HObject image, HTuple slant, HTuple tilt, HTuple albedo, HTuple ambient)
		{
			HOperatorSet.SfsPentland(image, out HObject height, slant, tilt, albedo, ambient);
			return height;
		}
		public static HObject SfsOrigLr (HObject image, HTuple slant, HTuple tilt, HTuple albedo, HTuple ambient)
		{
			HOperatorSet.SfsOrigLr(image, out HObject height, slant, tilt, albedo, ambient);
			return height;
		}
		public static HObject SfsModLr (HObject image, HTuple slant, HTuple tilt, HTuple albedo, HTuple ambient)
		{
			HOperatorSet.SfsModLr(image, out HObject height, slant, tilt, albedo, ambient);
			return height;
		}
		public static HTuple ReceiveSerializedItem (HTuple socket)
		{
			HOperatorSet.ReceiveSerializedItem(socket, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static void SendSerializedItem (HTuple socket, HTuple serializedItemHandle)
		{
			HOperatorSet.SendSerializedItem(socket, serializedItemHandle);
		}
		public static void FwriteSerializedItem (HTuple fileHandle, HTuple serializedItemHandle)
		{
			HOperatorSet.FwriteSerializedItem(fileHandle, serializedItemHandle);
		}
		public static HTuple FreadSerializedItem (HTuple fileHandle)
		{
			HOperatorSet.FreadSerializedItem(fileHandle, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static void ClearAllSerializedItems ()
		{
			HOperatorSet.ClearAllSerializedItems();
		}
		public static void ClearSerializedItem (HTuple serializedItemHandle)
		{
			HOperatorSet.ClearSerializedItem(serializedItemHandle);
		}
		public static (HTuple pointer, HTuple size) GetSerializedItemPtr (HTuple serializedItemHandle)
		{
			HOperatorSet.GetSerializedItemPtr(serializedItemHandle, out HTuple pointer, out HTuple size);
			return (pointer,size);
		}
		public static HTuple CreateSerializedItemPtr (HTuple pointer, HTuple size, HTuple copy)
		{
			HOperatorSet.CreateSerializedItemPtr(pointer, size, copy, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple FitPrimitivesObjectModel3d (HTuple objectModel3D, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.FitPrimitivesObjectModel3d(objectModel3D, genParamName, genParamValue, out HTuple objectModel3DOut);
			return objectModel3DOut;
		}
		public static HTuple SegmentObjectModel3d (HTuple objectModel3D, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SegmentObjectModel3d(objectModel3D, genParamName, genParamValue, out HTuple objectModel3DOut);
			return objectModel3DOut;
		}
		public static void ClearAllTextResults ()
		{
			HOperatorSet.ClearAllTextResults();
		}
		public static void ClearTextResult (HTuple textResultID)
		{
			HOperatorSet.ClearTextResult(textResultID);
		}
		public static HObject GetTextObject (HTuple textResultID, HTuple resultName)
		{
			HOperatorSet.GetTextObject(out HObject characters, textResultID, resultName);
			return characters;
		}
		public static HTuple GetTextResult (HTuple textResultID, HTuple resultName)
		{
			HOperatorSet.GetTextResult(textResultID, resultName, out HTuple resultValue);
			return resultValue;
		}
		public static HTuple FindText (HObject image, HTuple textModel)
		{
			HOperatorSet.FindText(image, textModel, out HTuple textResultID);
			return textResultID;
		}
		public static HTuple GetTextModelParam (HTuple textModel, HTuple genParamName)
		{
			HOperatorSet.GetTextModelParam(textModel, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetTextModelParam (HTuple textModel, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetTextModelParam(textModel, genParamName, genParamValue);
		}
		public static void ClearAllTextModels ()
		{
			HOperatorSet.ClearAllTextModels();
		}
		public static void ClearTextModel (HTuple textModel)
		{
			HOperatorSet.ClearTextModel(textModel);
		}
		public static HTuple CreateTextModelReader (HTuple mode, HTuple OCRClassifier)
		{
			HOperatorSet.CreateTextModelReader(mode, OCRClassifier, out HTuple textModel);
			return textModel;
		}
		public static HTuple CreateTextModel ()
		{
			HOperatorSet.CreateTextModel(out HTuple textModel);
			return textModel;
		}
		public static HObject SelectCharacters (HObject region, HTuple dotPrint, HTuple strokeWidth, HTuple charWidth, HTuple charHeight, HTuple punctuation, HTuple diacriticMarks, HTuple partitionMethod, HTuple partitionLines, HTuple fragmentDistance, HTuple connectFragments, HTuple clutterSizeMax, HTuple stopAfter)
		{
			HOperatorSet.SelectCharacters(region, out HObject regionCharacters, dotPrint, strokeWidth, charWidth, charHeight, punctuation, diacriticMarks, partitionMethod, partitionLines, fragmentDistance, connectFragments, clutterSizeMax, stopAfter);
			return regionCharacters;
		}
		public static (HObject imageForeground, HObject regionForeground, HTuple usedThreshold) SegmentCharacters (HObject region, HObject image, HTuple method, HTuple eliminateLines, HTuple dotPrint, HTuple strokeWidth, HTuple charWidth, HTuple charHeight, HTuple thresholdOffset, HTuple contrast)
		{
			HOperatorSet.SegmentCharacters(region, image, out HObject imageForeground, out HObject regionForeground, method, eliminateLines, dotPrint, strokeWidth, charWidth, charHeight, thresholdOffset, contrast, out HTuple usedThreshold);
			return (imageForeground,regionForeground,usedThreshold);
		}
		public static HTuple TextLineSlant (HObject region, HObject image, HTuple charHeight, HTuple slantFrom, HTuple slantTo)
		{
			HOperatorSet.TextLineSlant(region, image, charHeight, slantFrom, slantTo, out HTuple slantAngle);
			return slantAngle;
		}
		public static HTuple TextLineOrientation (HObject region, HObject image, HTuple charHeight, HTuple orientationFrom, HTuple orientationTo)
		{
			HOperatorSet.TextLineOrientation(region, image, charHeight, orientationFrom, orientationTo, out HTuple orientationAngle);
			return orientationAngle;
		}
		public static HObject ClassifyImageClassLut (HObject image, HTuple classLUTHandle)
		{
			HOperatorSet.ClassifyImageClassLut(image, out HObject classRegions, classLUTHandle);
			return classRegions;
		}
		public static (HObject classRegions, HObject distanceImage) ClassifyImageClassKnn (HObject image, HTuple KNNHandle, HTuple rejectionThreshold)
		{
			HOperatorSet.ClassifyImageClassKnn(image, out HObject classRegions, out HObject distanceImage, KNNHandle, rejectionThreshold);
			return (classRegions,distanceImage);
		}
		public static void AddSamplesImageClassKnn (HObject image, HObject classRegions, HTuple KNNHandle)
		{
			HOperatorSet.AddSamplesImageClassKnn(image, classRegions, KNNHandle);
		}
		public static HObject ClassifyImageClassGmm (HObject image, HTuple GMMHandle, HTuple rejectionThreshold)
		{
			HOperatorSet.ClassifyImageClassGmm(image, out HObject classRegions, GMMHandle, rejectionThreshold);
			return classRegions;
		}
		public static void AddSamplesImageClassGmm (HObject image, HObject classRegions, HTuple GMMHandle, HTuple randomize)
		{
			HOperatorSet.AddSamplesImageClassGmm(image, classRegions, GMMHandle, randomize);
		}
		public static HObject ClassifyImageClassSvm (HObject image, HTuple SVMHandle)
		{
			HOperatorSet.ClassifyImageClassSvm(image, out HObject classRegions, SVMHandle);
			return classRegions;
		}
		public static void AddSamplesImageClassSvm (HObject image, HObject classRegions, HTuple SVMHandle)
		{
			HOperatorSet.AddSamplesImageClassSvm(image, classRegions, SVMHandle);
		}
		public static HObject ClassifyImageClassMlp (HObject image, HTuple MLPHandle, HTuple rejectionThreshold)
		{
			HOperatorSet.ClassifyImageClassMlp(image, out HObject classRegions, MLPHandle, rejectionThreshold);
			return classRegions;
		}
		public static void AddSamplesImageClassMlp (HObject image, HObject classRegions, HTuple MLPHandle)
		{
			HOperatorSet.AddSamplesImageClassMlp(image, classRegions, MLPHandle);
		}
		public static (HTuple radius, HTuple center, HTuple quality) LearnNdimNorm (HObject foreground, HObject background, HObject image, HTuple metric, HTuple distance, HTuple minNumberPercent)
		{
			HOperatorSet.LearnNdimNorm(foreground, background, image, metric, distance, minNumberPercent, out HTuple radius, out HTuple center, out HTuple quality);
			return (radius,center,quality);
		}
		public static void LearnNdimBox (HObject foreground, HObject background, HObject multiChannelImage, HTuple classifHandle)
		{
			HOperatorSet.LearnNdimBox(foreground, background, multiChannelImage, classifHandle);
		}
		public static HObject ClassNdimBox (HObject multiChannelImage, HTuple classifHandle)
		{
			HOperatorSet.ClassNdimBox(multiChannelImage, out HObject regions, classifHandle);
			return regions;
		}
		public static HObject ClassNdimNorm (HObject multiChannelImage, HTuple metric, HTuple singleMultiple, HTuple radius, HTuple center)
		{
			HOperatorSet.ClassNdimNorm(multiChannelImage, out HObject regions, metric, singleMultiple, radius, center);
			return regions;
		}
		public static HObject Class2dimSup (HObject imageCol, HObject imageRow, HObject featureSpace)
		{
			HOperatorSet.Class2dimSup(imageCol, imageRow, featureSpace, out HObject regionClass2Dim);
			return regionClass2Dim;
		}
		public static HObject Class2dimUnsup (HObject image1, HObject image2, HTuple threshold, HTuple numClasses)
		{
			HOperatorSet.Class2dimUnsup(image1, image2, out HObject classes, threshold, numClasses);
			return classes;
		}
		public static HObject CheckDifference (HObject image, HObject pattern, HTuple mode, HTuple diffLowerBound, HTuple diffUpperBound, HTuple grayOffset, HTuple addRow, HTuple addCol)
		{
			HOperatorSet.CheckDifference(image, pattern, out HObject selected, mode, diffLowerBound, diffUpperBound, grayOffset, addRow, addCol);
			return selected;
		}
		public static (HObject characters, HTuple threshold) CharThreshold (HObject image, HObject histoRegion, HTuple sigma, HTuple percent)
		{
			HOperatorSet.CharThreshold(image, histoRegion, out HObject characters, sigma, percent, out HTuple threshold);
			return (characters,threshold);
		}
		public static HObject LabelToRegion (HObject labelImage)
		{
			HOperatorSet.LabelToRegion(labelImage, out HObject regions);
			return regions;
		}
		public static HObject NonmaxSuppressionAmp (HObject imgAmp, HTuple mode)
		{
			HOperatorSet.NonmaxSuppressionAmp(imgAmp, out HObject imageResult, mode);
			return imageResult;
		}
		public static HObject NonmaxSuppressionDir (HObject imgAmp, HObject imgDir, HTuple mode)
		{
			HOperatorSet.NonmaxSuppressionDir(imgAmp, imgDir, out HObject imageResult, mode);
			return imageResult;
		}
		public static HObject HysteresisThreshold (HObject image, HTuple low, HTuple high, HTuple maxLength)
		{
			HOperatorSet.HysteresisThreshold(image, out HObject regionHysteresis, low, high, maxLength);
			return regionHysteresis;
		}
		public static (HObject region, HTuple usedThreshold) BinaryThreshold (HObject image, HTuple method, HTuple lightDark)
		{
			HOperatorSet.BinaryThreshold(image, out HObject region, method, lightDark, out HTuple usedThreshold);
			return (region,usedThreshold);
		}
		public static HObject LocalThreshold (HObject image, HTuple method, HTuple lightDark, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.LocalThreshold(image, out HObject region, method, lightDark, genParamName, genParamValue);
			return region;
		}
		public static HObject VarThreshold (HObject image, HTuple maskWidth, HTuple maskHeight, HTuple stdDevScale, HTuple absThreshold, HTuple lightDark)
		{
			HOperatorSet.VarThreshold(image, out HObject region, maskWidth, maskHeight, stdDevScale, absThreshold, lightDark);
			return region;
		}
		public static HObject DynThreshold (HObject origImage, HObject thresholdImage, HTuple offset, HTuple lightDark)
		{
			HOperatorSet.DynThreshold(origImage, thresholdImage, out HObject regionDynThresh, offset, lightDark);
			return regionDynThresh;
		}
		public static HObject Threshold (HObject image, HTuple minGray, HTuple maxGray)
		{
			HOperatorSet.Threshold(image, out HObject region, minGray, maxGray);
			return region;
		}
		public static HObject ThresholdSubPix (HObject image, HTuple threshold)
		{
			HOperatorSet.ThresholdSubPix(image, out HObject border, threshold);
			return border;
		}
		public static HObject RegiongrowingN (HObject multiChannelImage, HTuple metric, HTuple minTolerance, HTuple maxTolerance, HTuple minSize)
		{
			HOperatorSet.RegiongrowingN(multiChannelImage, out HObject regions, metric, minTolerance, maxTolerance, minSize);
			return regions;
		}
		public static HObject Regiongrowing (HObject image, HTuple row, HTuple column, HTuple tolerance, HTuple minSize)
		{
			HOperatorSet.Regiongrowing(image, out HObject regions, row, column, tolerance, minSize);
			return regions;
		}
		public static HObject RegiongrowingMean (HObject image, HTuple startRows, HTuple startColumns, HTuple tolerance, HTuple minSize)
		{
			HOperatorSet.RegiongrowingMean(image, out HObject regions, startRows, startColumns, tolerance, minSize);
			return regions;
		}
		public static HObject Pouring (HObject image, HTuple mode, HTuple minGray, HTuple maxGray)
		{
			HOperatorSet.Pouring(image, out HObject regions, mode, minGray, maxGray);
			return regions;
		}
		public static HObject WatershedsThreshold (HObject image, HTuple threshold)
		{
			HOperatorSet.WatershedsThreshold(image, out HObject basins, threshold);
			return basins;
		}
		public static (HObject basins, HObject watersheds) Watersheds (HObject image)
		{
			HOperatorSet.Watersheds(image, out HObject basins, out HObject watersheds);
			return (basins,watersheds);
		}
		public static HObject ZeroCrossing (HObject image)
		{
			HOperatorSet.ZeroCrossing(image, out HObject regionCrossing);
			return regionCrossing;
		}
		public static HObject ZeroCrossingSubPix (HObject image)
		{
			HOperatorSet.ZeroCrossingSubPix(image, out HObject zeroCrossings);
			return zeroCrossings;
		}
		public static HObject DualThreshold (HObject image, HTuple minSize, HTuple minGray, HTuple threshold)
		{
			HOperatorSet.DualThreshold(image, out HObject regionCrossings, minSize, minGray, threshold);
			return regionCrossings;
		}
		public static HObject ExpandLine (HObject image, HTuple coordinate, HTuple expandType, HTuple rowColumn, HTuple threshold)
		{
			HOperatorSet.ExpandLine(image, out HObject regionExpand, coordinate, expandType, rowColumn, threshold);
			return regionExpand;
		}
		public static HObject LocalMin (HObject image)
		{
			HOperatorSet.LocalMin(image, out HObject localMinima);
			return localMinima;
		}
		public static HObject Lowlands (HObject image)
		{
			HOperatorSet.Lowlands(image, out HObject lowlands);
			return lowlands;
		}
		public static HObject LowlandsCenter (HObject image)
		{
			HOperatorSet.LowlandsCenter(image, out HObject lowlands);
			return lowlands;
		}
		public static HObject LocalMax (HObject image)
		{
			HOperatorSet.LocalMax(image, out HObject localMaxima);
			return localMaxima;
		}
		public static HObject Plateaus (HObject image)
		{
			HOperatorSet.Plateaus(image, out HObject plateaus);
			return plateaus;
		}
		public static HObject PlateausCenter (HObject image)
		{
			HOperatorSet.PlateausCenter(image, out HObject plateaus);
			return plateaus;
		}
		public static (HTuple minThresh, HTuple maxThresh) HistoToThresh (HTuple histogramm, HTuple sigma)
		{
			HOperatorSet.HistoToThresh(histogramm, sigma, out HTuple minThresh, out HTuple maxThresh);
			return (minThresh,maxThresh);
		}
		public static HObject AutoThreshold (HObject image, HTuple sigma)
		{
			HOperatorSet.AutoThreshold(image, out HObject regions, sigma);
			return regions;
		}
		public static HObject BinThreshold (HObject image)
		{
			HOperatorSet.BinThreshold(image, out HObject region);
			return region;
		}
		public static HObject FastThreshold (HObject image, HTuple minGray, HTuple maxGray, HTuple minSize)
		{
			HOperatorSet.FastThreshold(image, out HObject region, minGray, maxGray, minSize);
			return region;
		}
		public static HObject PolarTransRegionInv (HObject polarRegion, HTuple row, HTuple column, HTuple angleStart, HTuple angleEnd, HTuple radiusStart, HTuple radiusEnd, HTuple widthIn, HTuple heightIn, HTuple width, HTuple height, HTuple interpolation)
		{
			HOperatorSet.PolarTransRegionInv(polarRegion, out HObject XYTransRegion, row, column, angleStart, angleEnd, radiusStart, radiusEnd, widthIn, heightIn, width, height, interpolation);
			return XYTransRegion;
		}
		public static HObject PolarTransRegion (HObject region, HTuple row, HTuple column, HTuple angleStart, HTuple angleEnd, HTuple radiusStart, HTuple radiusEnd, HTuple width, HTuple height, HTuple interpolation)
		{
			HOperatorSet.PolarTransRegion(region, out HObject polarTransRegion, row, column, angleStart, angleEnd, radiusStart, radiusEnd, width, height, interpolation);
			return polarTransRegion;
		}
		public static (HObject currMergedRegions, HObject prevMergedRegions) MergeRegionsLineScan (HObject currRegions, HObject prevRegions, HTuple imageHeight, HTuple mergeBorder, HTuple maxImagesRegion)
		{
			HOperatorSet.MergeRegionsLineScan(currRegions, prevRegions, out HObject currMergedRegions, out HObject prevMergedRegions, imageHeight, mergeBorder, maxImagesRegion);
			return (currMergedRegions,prevMergedRegions);
		}
		public static HObject PartitionRectangle (HObject region, HTuple width, HTuple height)
		{
			HOperatorSet.PartitionRectangle(region, out HObject partitioned, width, height);
			return partitioned;
		}
		public static HObject PartitionDynamic (HObject region, HTuple distance, HTuple percent)
		{
			HOperatorSet.PartitionDynamic(region, out HObject partitioned, distance, percent);
			return partitioned;
		}
		public static HObject RegionToLabel (HObject region, HTuple type, HTuple width, HTuple height)
		{
			HOperatorSet.RegionToLabel(region, out HObject imageLabel, type, width, height);
			return imageLabel;
		}
		public static HObject RegionToBin (HObject region, HTuple foregroundGray, HTuple backgroundGray, HTuple width, HTuple height)
		{
			HOperatorSet.RegionToBin(region, out HObject binImage, foregroundGray, backgroundGray, width, height);
			return binImage;
		}
		public static HObject Union2 (HObject region1, HObject region2)
		{
			HOperatorSet.Union2(region1, region2, out HObject regionUnion);
			return regionUnion;
		}
		public static HObject Union1 (HObject region)
		{
			HOperatorSet.Union1(region, out HObject regionUnion);
			return regionUnion;
		}
		public static (HObject distances, HObject closestPoints) ClosestPointTransform (HObject region, HTuple metric, HTuple foreground, HTuple closestPointMode, HTuple width, HTuple height)
		{
			HOperatorSet.ClosestPointTransform(region, out HObject distances, out HObject closestPoints, metric, foreground, closestPointMode, width, height);
			return (distances,closestPoints);
		}
		public static HObject DistanceTransform (HObject region, HTuple metric, HTuple foreground, HTuple width, HTuple height)
		{
			HOperatorSet.DistanceTransform(region, out HObject distanceImage, metric, foreground, width, height);
			return distanceImage;
		}
		public static HObject Skeleton (HObject region)
		{
			HOperatorSet.Skeleton(region, out HObject skeleton);
			return skeleton;
		}
		public static HObject ProjectiveTransRegion (HObject regions, HTuple homMat2D, HTuple interpolation)
		{
			HOperatorSet.ProjectiveTransRegion(regions, out HObject transRegions, homMat2D, interpolation);
			return transRegions;
		}
		public static HObject AffineTransRegion (HObject region, HTuple homMat2D, HTuple interpolate)
		{
			HOperatorSet.AffineTransRegion(region, out HObject regionAffineTrans, homMat2D, interpolate);
			return regionAffineTrans;
		}
		public static HObject MirrorRegion (HObject region, HTuple mode, HTuple widthHeight)
		{
			HOperatorSet.MirrorRegion(region, out HObject regionMirror, mode, widthHeight);
			return regionMirror;
		}
		public static HObject ZoomRegion (HObject region, HTuple scaleWidth, HTuple scaleHeight)
		{
			HOperatorSet.ZoomRegion(region, out HObject regionZoom, scaleWidth, scaleHeight);
			return regionZoom;
		}
		public static HObject MoveRegion (HObject region, HTuple row, HTuple column)
		{
			HOperatorSet.MoveRegion(region, out HObject regionMoved, row, column);
			return regionMoved;
		}
		public static (HObject endPoints, HObject juncPoints) JunctionsSkeleton (HObject region)
		{
			HOperatorSet.JunctionsSkeleton(region, out HObject endPoints, out HObject juncPoints);
			return (endPoints,juncPoints);
		}
		public static HObject Intersection (HObject region1, HObject region2)
		{
			HOperatorSet.Intersection(region1, region2, out HObject regionIntersection);
			return regionIntersection;
		}
		public static HObject Interjacent (HObject region, HTuple mode)
		{
			HOperatorSet.Interjacent(region, out HObject regionInterjacent, mode);
			return regionInterjacent;
		}
		public static HObject FillUp (HObject region)
		{
			HOperatorSet.FillUp(region, out HObject regionFillUp);
			return regionFillUp;
		}
		public static HObject FillUpShape (HObject region, HTuple feature, HTuple min, HTuple max)
		{
			HOperatorSet.FillUpShape(region, out HObject regionFillUp, feature, min, max);
			return regionFillUp;
		}
		public static HObject ExpandRegion (HObject regions, HObject forbiddenArea, HTuple iterations, HTuple mode)
		{
			HOperatorSet.ExpandRegion(regions, forbiddenArea, out HObject regionExpanded, iterations, mode);
			return regionExpanded;
		}
		public static HObject ClipRegionRel (HObject region, HTuple top, HTuple bottom, HTuple left, HTuple right)
		{
			HOperatorSet.ClipRegionRel(region, out HObject regionClipped, top, bottom, left, right);
			return regionClipped;
		}
		public static HObject ClipRegion (HObject region, HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.ClipRegion(region, out HObject regionClipped, row1, column1, row2, column2);
			return regionClipped;
		}
		public static HObject RankRegion (HObject region, HTuple width, HTuple height, HTuple number)
		{
			HOperatorSet.RankRegion(region, out HObject regionCount, width, height, number);
			return regionCount;
		}
		public static HObject Connection (HObject region)
		{
			HOperatorSet.Connection(region, out HObject connectedRegions);
			return connectedRegions;
		}
		public static HObject SymmDifference (HObject region1, HObject region2)
		{
			HOperatorSet.SymmDifference(region1, region2, out HObject regionDifference);
			return regionDifference;
		}
		public static HObject Difference (HObject region, HObject sub)
		{
			HOperatorSet.Difference(region, sub, out HObject regionDifference);
			return regionDifference;
		}
		public static HObject Complement (HObject region)
		{
			HOperatorSet.Complement(region, out HObject regionComplement);
			return regionComplement;
		}
		public static HObject BackgroundSeg (HObject foreground)
		{
			HOperatorSet.BackgroundSeg(foreground, out HObject backgroundRegions);
			return backgroundRegions;
		}
		public static HObject HammingChangeRegion (HObject inputRegion, HTuple width, HTuple height, HTuple distance)
		{
			HOperatorSet.HammingChangeRegion(inputRegion, out HObject outputRegion, width, height, distance);
			return outputRegion;
		}
		public static HObject RemoveNoiseRegion (HObject inputRegion, HTuple type)
		{
			HOperatorSet.RemoveNoiseRegion(inputRegion, out HObject outputRegion, type);
			return outputRegion;
		}
		public static HObject ShapeTrans (HObject region, HTuple type)
		{
			HOperatorSet.ShapeTrans(region, out HObject regionTrans, type);
			return regionTrans;
		}
		public static HObject ExpandGray (HObject regions, HObject image, HObject forbiddenArea, HTuple iterations, HTuple mode, HTuple threshold)
		{
			HOperatorSet.ExpandGray(regions, image, forbiddenArea, out HObject regionExpand, iterations, mode, threshold);
			return regionExpand;
		}
		public static HObject ExpandGrayRef (HObject regions, HObject image, HObject forbiddenArea, HTuple iterations, HTuple mode, HTuple refGray, HTuple threshold)
		{
			HOperatorSet.ExpandGrayRef(regions, image, forbiddenArea, out HObject regionExpand, iterations, mode, refGray, threshold);
			return regionExpand;
		}
		public static (HTuple beginRow, HTuple beginCol, HTuple endRow, HTuple endCol) SplitSkeletonLines (HObject skeletonRegion, HTuple maxDistance)
		{
			HOperatorSet.SplitSkeletonLines(skeletonRegion, maxDistance, out HTuple beginRow, out HTuple beginCol, out HTuple endRow, out HTuple endCol);
			return (beginRow,beginCol,endRow,endCol);
		}
		public static (HTuple homMat2D, HTuple kappa, HTuple error, HTuple points1, HTuple points2) ProjMatchPointsDistortionRansacGuided (HObject image1, HObject image2, HTuple rows1, HTuple cols1, HTuple rows2, HTuple cols2, HTuple grayMatchMethod, HTuple maskSize, HTuple homMat2DGuide, HTuple kappaGuide, HTuple distanceTolerance, HTuple matchThreshold, HTuple estimationMethod, HTuple distanceThreshold, HTuple randSeed)
		{
			HOperatorSet.ProjMatchPointsDistortionRansacGuided(image1, image2, rows1, cols1, rows2, cols2, grayMatchMethod, maskSize, homMat2DGuide, kappaGuide, distanceTolerance, matchThreshold, estimationMethod, distanceThreshold, randSeed, out HTuple homMat2D, out HTuple kappa, out HTuple error, out HTuple points1, out HTuple points2);
			return (homMat2D,kappa,error,points1,points2);
		}
		public static (HTuple homMat2D, HTuple kappa, HTuple error, HTuple points1, HTuple points2) ProjMatchPointsDistortionRansac (HObject image1, HObject image2, HTuple rows1, HTuple cols1, HTuple rows2, HTuple cols2, HTuple grayMatchMethod, HTuple maskSize, HTuple rowMove, HTuple colMove, HTuple rowTolerance, HTuple colTolerance, HTuple rotation, HTuple matchThreshold, HTuple estimationMethod, HTuple distanceThreshold, HTuple randSeed)
		{
			HOperatorSet.ProjMatchPointsDistortionRansac(image1, image2, rows1, cols1, rows2, cols2, grayMatchMethod, maskSize, rowMove, colMove, rowTolerance, colTolerance, rotation, matchThreshold, estimationMethod, distanceThreshold, randSeed, out HTuple homMat2D, out HTuple kappa, out HTuple error, out HTuple points1, out HTuple points2);
			return (homMat2D,kappa,error,points1,points2);
		}
		public static (HTuple homMat2D, HTuple points1, HTuple points2) ProjMatchPointsRansacGuided (HObject image1, HObject image2, HTuple rows1, HTuple cols1, HTuple rows2, HTuple cols2, HTuple grayMatchMethod, HTuple maskSize, HTuple homMat2DGuide, HTuple distanceTolerance, HTuple matchThreshold, HTuple estimationMethod, HTuple distanceThreshold, HTuple randSeed)
		{
			HOperatorSet.ProjMatchPointsRansacGuided(image1, image2, rows1, cols1, rows2, cols2, grayMatchMethod, maskSize, homMat2DGuide, distanceTolerance, matchThreshold, estimationMethod, distanceThreshold, randSeed, out HTuple homMat2D, out HTuple points1, out HTuple points2);
			return (homMat2D,points1,points2);
		}
		public static (HTuple homMat2D, HTuple points1, HTuple points2) ProjMatchPointsRansac (HObject image1, HObject image2, HTuple rows1, HTuple cols1, HTuple rows2, HTuple cols2, HTuple grayMatchMethod, HTuple maskSize, HTuple rowMove, HTuple colMove, HTuple rowTolerance, HTuple colTolerance, HTuple rotation, HTuple matchThreshold, HTuple estimationMethod, HTuple distanceThreshold, HTuple randSeed)
		{
			HOperatorSet.ProjMatchPointsRansac(image1, image2, rows1, cols1, rows2, cols2, grayMatchMethod, maskSize, rowMove, colMove, rowTolerance, colTolerance, rotation, matchThreshold, estimationMethod, distanceThreshold, randSeed, out HTuple homMat2D, out HTuple points1, out HTuple points2);
			return (homMat2D,points1,points2);
		}
		public static (HTuple homMat2D, HTuple kappa, HTuple error) VectorToProjHomMat2dDistortion (HTuple points1Row, HTuple points1Col, HTuple points2Row, HTuple points2Col, HTuple covRR1, HTuple covRC1, HTuple covCC1, HTuple covRR2, HTuple covRC2, HTuple covCC2, HTuple imageWidth, HTuple imageHeight, HTuple method)
		{
			HOperatorSet.VectorToProjHomMat2dDistortion(points1Row, points1Col, points2Row, points2Col, covRR1, covRC1, covCC1, covRR2, covRC2, covCC2, imageWidth, imageHeight, method, out HTuple homMat2D, out HTuple kappa, out HTuple error);
			return (homMat2D,kappa,error);
		}
		public static HTuple HomVectorToProjHomMat2d (HTuple px, HTuple py, HTuple pw, HTuple qx, HTuple qy, HTuple qw, HTuple method)
		{
			HOperatorSet.HomVectorToProjHomMat2d(px, py, pw, qx, qy, qw, method, out HTuple homMat2D);
			return homMat2D;
		}
		public static (HTuple homMat2D, HTuple covariance) VectorToProjHomMat2d (HTuple px, HTuple py, HTuple qx, HTuple qy, HTuple method, HTuple covXX1, HTuple covYY1, HTuple covXY1, HTuple covXX2, HTuple covYY2, HTuple covXY2)
		{
			HOperatorSet.VectorToProjHomMat2d(px, py, qx, qy, method, covXX1, covYY1, covXY1, covXX2, covYY2, covXY2, out HTuple homMat2D, out HTuple covariance);
			return (homMat2D,covariance);
		}
		public static (HTuple sx, HTuple sy, HTuple phi, HTuple theta, HTuple tx, HTuple ty) HomMat2dToAffinePar (HTuple homMat2D)
		{
			HOperatorSet.HomMat2dToAffinePar(homMat2D, out HTuple sx, out HTuple sy, out HTuple phi, out HTuple theta, out HTuple tx, out HTuple ty);
			return (sx,sy,phi,theta,tx,ty);
		}
		public static HTuple VectorAngleToRigid (HTuple row1, HTuple column1, HTuple angle1, HTuple row2, HTuple column2, HTuple angle2)
		{
			HOperatorSet.VectorAngleToRigid(row1, column1, angle1, row2, column2, angle2, out HTuple homMat2D);
			return homMat2D;
		}
		public static HTuple PointLineToHomMat2d (HTuple transformationType, HTuple px, HTuple py, HTuple l1x, HTuple l1y, HTuple l2x, HTuple l2y)
		{
			HOperatorSet.PointLineToHomMat2d(transformationType, px, py, l1x, l1y, l2x, l2y, out HTuple homMat2D);
			return homMat2D;
		}
		public static HTuple VectorToRigid (HTuple px, HTuple py, HTuple qx, HTuple qy)
		{
			HOperatorSet.VectorToRigid(px, py, qx, qy, out HTuple homMat2D);
			return homMat2D;
		}
		public static HTuple VectorToSimilarity (HTuple px, HTuple py, HTuple qx, HTuple qy)
		{
			HOperatorSet.VectorToSimilarity(px, py, qx, qy, out HTuple homMat2D);
			return homMat2D;
		}
		public static HTuple VectorToAniso (HTuple px, HTuple py, HTuple qx, HTuple qy)
		{
			HOperatorSet.VectorToAniso(px, py, qx, qy, out HTuple homMat2D);
			return homMat2D;
		}
		public static HTuple VectorToHomMat2d (HTuple px, HTuple py, HTuple qx, HTuple qy)
		{
			HOperatorSet.VectorToHomMat2d(px, py, qx, qy, out HTuple homMat2D);
			return homMat2D;
		}
		public static (HTuple rowTrans, HTuple colTrans) ProjectiveTransPixel (HTuple homMat2D, HTuple row, HTuple col)
		{
			HOperatorSet.ProjectiveTransPixel(homMat2D, row, col, out HTuple rowTrans, out HTuple colTrans);
			return (rowTrans,colTrans);
		}
		public static (HTuple qx, HTuple qy, HTuple qw) ProjectiveTransPoint2d (HTuple homMat2D, HTuple px, HTuple py, HTuple pw)
		{
			HOperatorSet.ProjectiveTransPoint2d(homMat2D, px, py, pw, out HTuple qx, out HTuple qy, out HTuple qw);
			return (qx,qy,qw);
		}
		public static (HTuple rowTrans, HTuple colTrans) AffineTransPixel (HTuple homMat2D, HTuple row, HTuple col)
		{
			HOperatorSet.AffineTransPixel(homMat2D, row, col, out HTuple rowTrans, out HTuple colTrans);
			return (rowTrans,colTrans);
		}
		public static (HTuple qx, HTuple qy) AffineTransPoint2d (HTuple homMat2D, HTuple px, HTuple py)
		{
			HOperatorSet.AffineTransPoint2d(homMat2D, px, py, out HTuple qx, out HTuple qy);
			return (qx,qy);
		}
		public static HTuple HomMat2dDeterminant (HTuple homMat2D)
		{
			HOperatorSet.HomMat2dDeterminant(homMat2D, out HTuple determinant);
			return determinant;
		}
		public static HTuple HomMat2dTranspose (HTuple homMat2D)
		{
			HOperatorSet.HomMat2dTranspose(homMat2D, out HTuple homMat2DTranspose);
			return homMat2DTranspose;
		}
		public static HTuple HomMat2dInvert (HTuple homMat2D)
		{
			HOperatorSet.HomMat2dInvert(homMat2D, out HTuple homMat2DInvert);
			return homMat2DInvert;
		}
		public static HTuple HomMat2dCompose (HTuple homMat2DLeft, HTuple homMat2DRight)
		{
			HOperatorSet.HomMat2dCompose(homMat2DLeft, homMat2DRight, out HTuple homMat2DCompose);
			return homMat2DCompose;
		}
		public static HTuple HomMat2dReflectLocal (HTuple homMat2D, HTuple px, HTuple py)
		{
			HOperatorSet.HomMat2dReflectLocal(homMat2D, px, py, out HTuple homMat2DReflect);
			return homMat2DReflect;
		}
		public static HTuple HomMat2dReflect (HTuple homMat2D, HTuple px, HTuple py, HTuple qx, HTuple qy)
		{
			HOperatorSet.HomMat2dReflect(homMat2D, px, py, qx, qy, out HTuple homMat2DReflect);
			return homMat2DReflect;
		}
		public static HTuple HomMat2dSlantLocal (HTuple homMat2D, HTuple theta, HTuple axis)
		{
			HOperatorSet.HomMat2dSlantLocal(homMat2D, theta, axis, out HTuple homMat2DSlant);
			return homMat2DSlant;
		}
		public static HTuple HomMat2dSlant (HTuple homMat2D, HTuple theta, HTuple axis, HTuple px, HTuple py)
		{
			HOperatorSet.HomMat2dSlant(homMat2D, theta, axis, px, py, out HTuple homMat2DSlant);
			return homMat2DSlant;
		}
		public static HTuple HomMat2dRotateLocal (HTuple homMat2D, HTuple phi)
		{
			HOperatorSet.HomMat2dRotateLocal(homMat2D, phi, out HTuple homMat2DRotate);
			return homMat2DRotate;
		}
		public static HTuple HomMat2dRotate (HTuple homMat2D, HTuple phi, HTuple px, HTuple py)
		{
			HOperatorSet.HomMat2dRotate(homMat2D, phi, px, py, out HTuple homMat2DRotate);
			return homMat2DRotate;
		}
		public static HTuple HomMat2dScaleLocal (HTuple homMat2D, HTuple sx, HTuple sy)
		{
			HOperatorSet.HomMat2dScaleLocal(homMat2D, sx, sy, out HTuple homMat2DScale);
			return homMat2DScale;
		}
		public static HTuple HomMat2dScale (HTuple homMat2D, HTuple sx, HTuple sy, HTuple px, HTuple py)
		{
			HOperatorSet.HomMat2dScale(homMat2D, sx, sy, px, py, out HTuple homMat2DScale);
			return homMat2DScale;
		}
		public static HTuple HomMat2dTranslateLocal (HTuple homMat2D, HTuple tx, HTuple ty)
		{
			HOperatorSet.HomMat2dTranslateLocal(homMat2D, tx, ty, out HTuple homMat2DTranslate);
			return homMat2DTranslate;
		}
		public static HTuple HomMat2dTranslate (HTuple homMat2D, HTuple tx, HTuple ty)
		{
			HOperatorSet.HomMat2dTranslate(homMat2D, tx, ty, out HTuple homMat2DTranslate);
			return homMat2DTranslate;
		}
		public static HTuple HomMat2dIdentity ()
		{
			HOperatorSet.HomMat2dIdentity(out HTuple homMat2DIdentity);
			return homMat2DIdentity;
		}
		public static void ClearAllScatteredDataInterpolators ()
		{
			HOperatorSet.ClearAllScatteredDataInterpolators();
		}
		public static void ClearScatteredDataInterpolator (HTuple scatteredDataInterpolatorHandle)
		{
			HOperatorSet.ClearScatteredDataInterpolator(scatteredDataInterpolatorHandle);
		}
		public static HTuple InterpolateScatteredData (HTuple scatteredDataInterpolatorHandle, HTuple row, HTuple column)
		{
			HOperatorSet.InterpolateScatteredData(scatteredDataInterpolatorHandle, row, column, out HTuple valueInterpolated);
			return valueInterpolated;
		}
		public static HTuple CreateScatteredDataInterpolator (HTuple method, HTuple rows, HTuple columns, HTuple values, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.CreateScatteredDataInterpolator(method, rows, columns, values, genParamName, genParamValue, out HTuple scatteredDataInterpolatorHandle);
			return scatteredDataInterpolatorHandle;
		}
		public static HObject InterpolateScatteredDataPointsToImage (HTuple method, HTuple rows, HTuple columns, HTuple values, HTuple width, HTuple height, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.InterpolateScatteredDataPointsToImage(out HObject imageInterpolated, method, rows, columns, values, width, height, genParamName, genParamValue);
			return imageInterpolated;
		}
		public static HObject InterpolateScatteredDataImage (HObject image, HObject regionInterpolate, HTuple method, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.InterpolateScatteredDataImage(image, regionInterpolate, out HObject imageInterpolated, method, genParamName, genParamValue);
			return imageInterpolated;
		}
		public static (HTuple MSecond, HTuple second, HTuple minute, HTuple hour, HTuple day, HTuple YDay, HTuple month, HTuple year) GetSystemTime ()
		{
			HOperatorSet.GetSystemTime(out HTuple MSecond, out HTuple second, out HTuple minute, out HTuple hour, out HTuple day, out HTuple YDay, out HTuple month, out HTuple year);
			return (MSecond,second,minute,hour,day,YDay,month,year);
		}
		public static HTuple GetComputeDeviceParam (HTuple deviceHandle, HTuple genParamName)
		{
			HOperatorSet.GetComputeDeviceParam(deviceHandle, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetComputeDeviceParam (HTuple deviceHandle, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetComputeDeviceParam(deviceHandle, genParamName, genParamValue);
		}
		public static void ReleaseAllComputeDevices ()
		{
			HOperatorSet.ReleaseAllComputeDevices();
		}
		public static void ReleaseComputeDevice (HTuple deviceHandle)
		{
			HOperatorSet.ReleaseComputeDevice(deviceHandle);
		}
		public static void DeactivateAllComputeDevices ()
		{
			HOperatorSet.DeactivateAllComputeDevices();
		}
		public static void DeactivateComputeDevice (HTuple deviceHandle)
		{
			HOperatorSet.DeactivateComputeDevice(deviceHandle);
		}
		public static void ActivateComputeDevice (HTuple deviceHandle)
		{
			HOperatorSet.ActivateComputeDevice(deviceHandle);
		}
		public static void InitComputeDevice (HTuple deviceHandle, HTuple operators)
		{
			HOperatorSet.InitComputeDevice(deviceHandle, operators);
		}
		public static HTuple OpenComputeDevice (HTuple deviceIdentifier)
		{
			HOperatorSet.OpenComputeDevice(deviceIdentifier, out HTuple deviceHandle);
			return deviceHandle;
		}
		public static HTuple GetComputeDeviceInfo (HTuple deviceIdentifier, HTuple infoName)
		{
			HOperatorSet.GetComputeDeviceInfo(deviceIdentifier, infoName, out HTuple info);
			return info;
		}
		public static HTuple QueryAvailableComputeDevices ()
		{
			HOperatorSet.QueryAvailableComputeDevices(out HTuple deviceIdentifier);
			return deviceIdentifier;
		}
		public static void ClearSerial (HTuple serialHandle, HTuple channel)
		{
			HOperatorSet.ClearSerial(serialHandle, channel);
		}
		public static void WriteSerial (HTuple serialHandle, HTuple data)
		{
			HOperatorSet.WriteSerial(serialHandle, data);
		}
		public static HTuple ReadSerial (HTuple serialHandle, HTuple numCharacters)
		{
			HOperatorSet.ReadSerial(serialHandle, numCharacters, out HTuple data);
			return data;
		}
		public static (HTuple baudRate, HTuple dataBits, HTuple flowControl, HTuple parity, HTuple stopBits, HTuple totalTimeOut, HTuple interCharTimeOut) GetSerialParam (HTuple serialHandle)
		{
			HOperatorSet.GetSerialParam(serialHandle, out HTuple baudRate, out HTuple dataBits, out HTuple flowControl, out HTuple parity, out HTuple stopBits, out HTuple totalTimeOut, out HTuple interCharTimeOut);
			return (baudRate,dataBits,flowControl,parity,stopBits,totalTimeOut,interCharTimeOut);
		}
		public static void SetSerialParam (HTuple serialHandle, HTuple baudRate, HTuple dataBits, HTuple flowControl, HTuple parity, HTuple stopBits, HTuple totalTimeOut, HTuple interCharTimeOut)
		{
			HOperatorSet.SetSerialParam(serialHandle, baudRate, dataBits, flowControl, parity, stopBits, totalTimeOut, interCharTimeOut);
		}
		public static void CloseAllSerials ()
		{
			HOperatorSet.CloseAllSerials();
		}
		public static void CloseSerial (HTuple serialHandle)
		{
			HOperatorSet.CloseSerial(serialHandle);
		}
		public static HTuple OpenSerial (HTuple portName)
		{
			HOperatorSet.OpenSerial(portName, out HTuple serialHandle);
			return serialHandle;
		}
		public static void WaitSeconds (HTuple seconds)
		{
			HOperatorSet.WaitSeconds(seconds);
		}
		public static void SystemCall (HTuple command)
		{
			HOperatorSet.SystemCall(command);
		}
		public static void SetSystem (HTuple systemParameter, HTuple value)
		{
			HOperatorSet.SetSystem(systemParameter, value);
		}
		public static void SetCheck (HTuple check)
		{
			HOperatorSet.SetCheck(check);
		}
		public static void ResetObjDb (HTuple defaultImageWidth, HTuple defaultImageHeight, HTuple defaultChannels)
		{
			HOperatorSet.ResetObjDb(defaultImageWidth, defaultImageHeight, defaultChannels);
		}
		public static HTuple GetSystem (HTuple query)
		{
			HOperatorSet.GetSystem(query, out HTuple information);
			return information;
		}
		public static HTuple GetCheck ()
		{
			HOperatorSet.GetCheck(out HTuple check);
			return check;
		}
		public static HTuple GetErrorText (HTuple errorCode)
		{
			HOperatorSet.GetErrorText(errorCode, out HTuple errorMessage);
			return errorMessage;
		}
		public static HTuple CountSeconds ()
		{
			HOperatorSet.CountSeconds(out HTuple seconds);
			return seconds;
		}
		public static HTuple CountRelation (HTuple relationName)
		{
			HOperatorSet.CountRelation(relationName, out HTuple numOfTuples);
			return numOfTuples;
		}
		public static HObject ReceiveImage (HTuple socket)
		{
			HOperatorSet.ReceiveImage(out HObject image, socket);
			return image;
		}
		public static void SendImage (HObject image, HTuple socket)
		{
			HOperatorSet.SendImage(image, socket);
		}
		public static HObject ReceiveRegion (HTuple socket)
		{
			HOperatorSet.ReceiveRegion(out HObject region, socket);
			return region;
		}
		public static void SendRegion (HObject region, HTuple socket)
		{
			HOperatorSet.SendRegion(region, socket);
		}
		public static HObject ReceiveXld (HTuple socket)
		{
			HOperatorSet.ReceiveXld(out HObject XLD, socket);
			return XLD;
		}
		public static void SendXld (HObject XLD, HTuple socket)
		{
			HOperatorSet.SendXld(XLD, socket);
		}
		public static HTuple ReceiveTuple (HTuple socket)
		{
			HOperatorSet.ReceiveTuple(socket, out HTuple tuple);
			return tuple;
		}
		public static void SendTuple (HTuple socket, HTuple tuple)
		{
			HOperatorSet.SendTuple(socket, tuple);
		}
		public static (HTuple data, HTuple from) ReceiveData (HTuple socket, HTuple format)
		{
			HOperatorSet.ReceiveData(socket, format, out HTuple data, out HTuple from);
			return (data,from);
		}
		public static void SendData (HTuple socket, HTuple format, HTuple data, HTuple to)
		{
			HOperatorSet.SendData(socket, format, data, to);
		}
		public static HTuple GetSocketParam (HTuple socket, HTuple genParamName)
		{
			HOperatorSet.GetSocketParam(socket, genParamName, out HTuple genParamValue);
			return genParamValue;
		}
		public static void SetSocketParam (HTuple socket, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.SetSocketParam(socket, genParamName, genParamValue);
		}
		public static HTuple GetNextSocketDataType (HTuple socket)
		{
			HOperatorSet.GetNextSocketDataType(socket, out HTuple dataType);
			return dataType;
		}
		public static HTuple GetSocketDescriptor (HTuple socket)
		{
			HOperatorSet.GetSocketDescriptor(socket, out HTuple socketDescriptor);
			return socketDescriptor;
		}
		public static void CloseAllSockets ()
		{
			HOperatorSet.CloseAllSockets();
		}
		public static void CloseSocket (HTuple socket)
		{
			HOperatorSet.CloseSocket(socket);
		}
		public static HTuple SocketAcceptConnect (HTuple acceptingSocket, HTuple wait)
		{
			HOperatorSet.SocketAcceptConnect(acceptingSocket, wait, out HTuple socket);
			return socket;
		}
		public static HTuple OpenSocketConnect (HTuple hostName, HTuple port, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.OpenSocketConnect(hostName, port, genParamName, genParamValue, out HTuple socket);
			return socket;
		}
		public static HTuple OpenSocketAccept (HTuple port, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.OpenSocketAccept(port, genParamName, genParamValue, out HTuple acceptingSocket);
			return acceptingSocket;
		}
		public static (HTuple operatorName, HTuple errorCode, HTuple errorMessage) GetExtendedErrorInfo ()
		{
			HOperatorSet.GetExtendedErrorInfo(out HTuple operatorName, out HTuple errorCode, out HTuple errorMessage);
			return (operatorName,errorCode,errorMessage);
		}
		public static (HTuple usedModules, HTuple moduleKey) GetModules ()
		{
			HOperatorSet.GetModules(out HTuple usedModules, out HTuple moduleKey);
			return (usedModules,moduleKey);
		}
		public static (HObject distance, HObject score) BinocularDistanceMs (HObject imageRect1, HObject imageRect2, HTuple camParamRect1, HTuple camParamRect2, HTuple relPoseRect, HTuple minDisparity, HTuple maxDisparity, HTuple surfaceSmoothing, HTuple edgeSmoothing, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.BinocularDistanceMs(imageRect1, imageRect2, out HObject distance, out HObject score, camParamRect1, camParamRect2, relPoseRect, minDisparity, maxDisparity, surfaceSmoothing, edgeSmoothing, genParamName, genParamValue);
			return (distance,score);
		}
		public static (HObject disparity, HObject score) BinocularDisparityMs (HObject imageRect1, HObject imageRect2, HTuple minDisparity, HTuple maxDisparity, HTuple surfaceSmoothing, HTuple edgeSmoothing, HTuple genParamName, HTuple genParamValue)
		{
			HOperatorSet.BinocularDisparityMs(imageRect1, imageRect2, out HObject disparity, out HObject score, minDisparity, maxDisparity, surfaceSmoothing, edgeSmoothing, genParamName, genParamValue);
			return (disparity,score);
		}
		public static (HObject distance, HObject score) BinocularDistanceMg (HObject imageRect1, HObject imageRect2, HTuple camParamRect1, HTuple camParamRect2, HTuple relPoseRect, HTuple grayConstancy, HTuple gradientConstancy, HTuple smoothness, HTuple initialGuess, HTuple calculateScore, HTuple MGParamName, HTuple MGParamValue)
		{
			HOperatorSet.BinocularDistanceMg(imageRect1, imageRect2, out HObject distance, out HObject score, camParamRect1, camParamRect2, relPoseRect, grayConstancy, gradientConstancy, smoothness, initialGuess, calculateScore, MGParamName, MGParamValue);
			return (distance,score);
		}
		public static (HObject disparity, HObject score) BinocularDisparityMg (HObject imageRect1, HObject imageRect2, HTuple grayConstancy, HTuple gradientConstancy, HTuple smoothness, HTuple initialGuess, HTuple calculateScore, HTuple MGParamName, HTuple MGParamValue)
		{
			HOperatorSet.BinocularDisparityMg(imageRect1, imageRect2, out HObject disparity, out HObject score, grayConstancy, gradientConstancy, smoothness, initialGuess, calculateScore, MGParamName, MGParamValue);
			return (disparity,score);
		}
		public static (HTuple x, HTuple y, HTuple z, HTuple w, HTuple covXYZW) Reconst3dFromFundamentalMatrix (HTuple rows1, HTuple cols1, HTuple rows2, HTuple cols2, HTuple covRR1, HTuple covRC1, HTuple covCC1, HTuple covRR2, HTuple covRC2, HTuple covCC2, HTuple FMatrix, HTuple covFMat)
		{
			HOperatorSet.Reconst3dFromFundamentalMatrix(rows1, cols1, rows2, cols2, covRR1, covRC1, covCC1, covRR2, covRC2, covCC2, FMatrix, covFMat, out HTuple x, out HTuple y, out HTuple z, out HTuple w, out HTuple covXYZW);
			return (x,y,z,w,covXYZW);
		}
		public static (HObject map1, HObject map2, HTuple covFMatRect, HTuple h1, HTuple h2) GenBinocularProjRectification (HTuple FMatrix, HTuple covFMat, HTuple width1, HTuple height1, HTuple width2, HTuple height2, HTuple subSampling, HTuple mapping)
		{
			HOperatorSet.GenBinocularProjRectification(out HObject map1, out HObject map2, FMatrix, covFMat, width1, height1, width2, height2, subSampling, mapping, out HTuple covFMatRect, out HTuple h1, out HTuple h2);
			return (map1,map2,covFMatRect,h1,h2);
		}
		public static (HTuple FMatrix, HTuple kappa, HTuple error, HTuple x, HTuple y, HTuple z, HTuple w) VectorToFundamentalMatrixDistortion (HTuple rows1, HTuple cols1, HTuple rows2, HTuple cols2, HTuple covRR1, HTuple covRC1, HTuple covCC1, HTuple covRR2, HTuple covRC2, HTuple covCC2, HTuple imageWidth, HTuple imageHeight, HTuple method)
		{
			HOperatorSet.VectorToFundamentalMatrixDistortion(rows1, cols1, rows2, cols2, covRR1, covRC1, covCC1, covRR2, covRC2, covCC2, imageWidth, imageHeight, method, out HTuple FMatrix, out HTuple kappa, out HTuple error, out HTuple x, out HTuple y, out HTuple z, out HTuple w);
			return (FMatrix,kappa,error,x,y,z,w);
		}
		public static (HTuple FMatrix, HTuple covFMat) RelPoseToFundamentalMatrix (HTuple relPose, HTuple covRelPose, HTuple camPar1, HTuple camPar2)
		{
			HOperatorSet.RelPoseToFundamentalMatrix(relPose, covRelPose, camPar1, camPar2, out HTuple FMatrix, out HTuple covFMat);
			return (FMatrix,covFMat);
		}
		public static (HTuple FMatrix, HTuple covFMat) EssentialToFundamentalMatrix (HTuple EMatrix, HTuple covEMat, HTuple camMat1, HTuple camMat2)
		{
			HOperatorSet.EssentialToFundamentalMatrix(EMatrix, covEMat, camMat1, camMat2, out HTuple FMatrix, out HTuple covFMat);
			return (FMatrix,covFMat);
		}
		public static (HTuple relPose, HTuple covRelPose, HTuple error, HTuple x, HTuple y, HTuple z, HTuple covXYZ) VectorToRelPose (HTuple rows1, HTuple cols1, HTuple rows2, HTuple cols2, HTuple covRR1, HTuple covRC1, HTuple covCC1, HTuple covRR2, HTuple covRC2, HTuple covCC2, HTuple camPar1, HTuple camPar2, HTuple method)
		{
			HOperatorSet.VectorToRelPose(rows1, cols1, rows2, cols2, covRR1, covRC1, covCC1, covRR2, covRC2, covCC2, camPar1, camPar2, method, out HTuple relPose, out HTuple covRelPose, out HTuple error, out HTuple x, out HTuple y, out HTuple z, out HTuple covXYZ);
			return (relPose,covRelPose,error,x,y,z,covXYZ);
		}
		public static (HTuple EMatrix, HTuple covEMat, HTuple error, HTuple x, HTuple y, HTuple z, HTuple covXYZ) VectorToEssentialMatrix (HTuple rows1, HTuple cols1, HTuple rows2, HTuple cols2, HTuple covRR1, HTuple covRC1, HTuple covCC1, HTuple covRR2, HTuple covRC2, HTuple covCC2, HTuple camMat1, HTuple camMat2, HTuple method)
		{
			HOperatorSet.VectorToEssentialMatrix(rows1, cols1, rows2, cols2, covRR1, covRC1, covCC1, covRR2, covRC2, covCC2, camMat1, camMat2, method, out HTuple EMatrix, out HTuple covEMat, out HTuple error, out HTuple x, out HTuple y, out HTuple z, out HTuple covXYZ);
			return (EMatrix,covEMat,error,x,y,z,covXYZ);
		}
		public static (HTuple FMatrix, HTuple covFMat, HTuple error, HTuple x, HTuple y, HTuple z, HTuple w, HTuple covXYZW) VectorToFundamentalMatrix (HTuple rows1, HTuple cols1, HTuple rows2, HTuple cols2, HTuple covRR1, HTuple covRC1, HTuple covCC1, HTuple covRR2, HTuple covRC2, HTuple covCC2, HTuple method)
		{
			HOperatorSet.VectorToFundamentalMatrix(rows1, cols1, rows2, cols2, covRR1, covRC1, covCC1, covRR2, covRC2, covCC2, method, out HTuple FMatrix, out HTuple covFMat, out HTuple error, out HTuple x, out HTuple y, out HTuple z, out HTuple w, out HTuple covXYZW);
			return (FMatrix,covFMat,error,x,y,z,w,covXYZW);
		}
		public static (HTuple FMatrix, HTuple kappa, HTuple error, HTuple points1, HTuple points2) MatchFundamentalMatrixDistortionRansac (HObject image1, HObject image2, HTuple rows1, HTuple cols1, HTuple rows2, HTuple cols2, HTuple grayMatchMethod, HTuple maskSize, HTuple rowMove, HTuple colMove, HTuple rowTolerance, HTuple colTolerance, HTuple rotation, HTuple matchThreshold, HTuple estimationMethod, HTuple distanceThreshold, HTuple randSeed)
		{
			HOperatorSet.MatchFundamentalMatrixDistortionRansac(image1, image2, rows1, cols1, rows2, cols2, grayMatchMethod, maskSize, rowMove, colMove, rowTolerance, colTolerance, rotation, matchThreshold, estimationMethod, distanceThreshold, randSeed, out HTuple FMatrix, out HTuple kappa, out HTuple error, out HTuple points1, out HTuple points2);
			return (FMatrix,kappa,error,points1,points2);
		}
		public static (HTuple relPose, HTuple covRelPose, HTuple error, HTuple points1, HTuple points2) MatchRelPoseRansac (HObject image1, HObject image2, HTuple rows1, HTuple cols1, HTuple rows2, HTuple cols2, HTuple camPar1, HTuple camPar2, HTuple grayMatchMethod, HTuple maskSize, HTuple rowMove, HTuple colMove, HTuple rowTolerance, HTuple colTolerance, HTuple rotation, HTuple matchThreshold, HTuple estimationMethod, HTuple distanceThreshold, HTuple randSeed)
		{
			HOperatorSet.MatchRelPoseRansac(image1, image2, rows1, cols1, rows2, cols2, camPar1, camPar2, grayMatchMethod, maskSize, rowMove, colMove, rowTolerance, colTolerance, rotation, matchThreshold, estimationMethod, distanceThreshold, randSeed, out HTuple relPose, out HTuple covRelPose, out HTuple error, out HTuple points1, out HTuple points2);
			return (relPose,covRelPose,error,points1,points2);
		}
		public static (HTuple EMatrix, HTuple covEMat, HTuple error, HTuple points1, HTuple points2) MatchEssentialMatrixRansac (HObject image1, HObject image2, HTuple rows1, HTuple cols1, HTuple rows2, HTuple cols2, HTuple camMat1, HTuple camMat2, HTuple grayMatchMethod, HTuple maskSize, HTuple rowMove, HTuple colMove, HTuple rowTolerance, HTuple colTolerance, HTuple rotation, HTuple matchThreshold, HTuple estimationMethod, HTuple distanceThreshold, HTuple randSeed)
		{
			HOperatorSet.MatchEssentialMatrixRansac(image1, image2, rows1, cols1, rows2, cols2, camMat1, camMat2, grayMatchMethod, maskSize, rowMove, colMove, rowTolerance, colTolerance, rotation, matchThreshold, estimationMethod, distanceThreshold, randSeed, out HTuple EMatrix, out HTuple covEMat, out HTuple error, out HTuple points1, out HTuple points2);
			return (EMatrix,covEMat,error,points1,points2);
		}
		public static (HTuple FMatrix, HTuple covFMat, HTuple error, HTuple points1, HTuple points2) MatchFundamentalMatrixRansac (HObject image1, HObject image2, HTuple rows1, HTuple cols1, HTuple rows2, HTuple cols2, HTuple grayMatchMethod, HTuple maskSize, HTuple rowMove, HTuple colMove, HTuple rowTolerance, HTuple colTolerance, HTuple rotation, HTuple matchThreshold, HTuple estimationMethod, HTuple distanceThreshold, HTuple randSeed)
		{
			HOperatorSet.MatchFundamentalMatrixRansac(image1, image2, rows1, cols1, rows2, cols2, grayMatchMethod, maskSize, rowMove, colMove, rowTolerance, colTolerance, rotation, matchThreshold, estimationMethod, distanceThreshold, randSeed, out HTuple FMatrix, out HTuple covFMat, out HTuple error, out HTuple points1, out HTuple points2);
			return (FMatrix,covFMat,error,points1,points2);
		}
		public static (HObject distance, HObject score) BinocularDistance (HObject imageRect1, HObject imageRect2, HTuple camParamRect1, HTuple camParamRect2, HTuple relPoseRect, HTuple method, HTuple maskWidth, HTuple maskHeight, HTuple textureThresh, HTuple minDisparity, HTuple maxDisparity, HTuple numLevels, HTuple scoreThresh, HTuple filter, HTuple subDistance)
		{
			HOperatorSet.BinocularDistance(imageRect1, imageRect2, out HObject distance, out HObject score, camParamRect1, camParamRect2, relPoseRect, method, maskWidth, maskHeight, textureThresh, minDisparity, maxDisparity, numLevels, scoreThresh, filter, subDistance);
			return (distance,score);
		}
		public static (HObject disparity, HObject score) BinocularDisparity (HObject imageRect1, HObject imageRect2, HTuple method, HTuple maskWidth, HTuple maskHeight, HTuple textureThresh, HTuple minDisparity, HTuple maxDisparity, HTuple numLevels, HTuple scoreThresh, HTuple filter, HTuple subDisparity)
		{
			HOperatorSet.BinocularDisparity(imageRect1, imageRect2, out HObject disparity, out HObject score, method, maskWidth, maskHeight, textureThresh, minDisparity, maxDisparity, numLevels, scoreThresh, filter, subDisparity);
			return (disparity,score);
		}
		public static (HTuple x, HTuple y, HTuple z, HTuple dist) IntersectLinesOfSight (HTuple camParam1, HTuple camParam2, HTuple relPose, HTuple row1, HTuple col1, HTuple row2, HTuple col2)
		{
			HOperatorSet.IntersectLinesOfSight(camParam1, camParam2, relPose, row1, col1, row2, col2, out HTuple x, out HTuple y, out HTuple z, out HTuple dist);
			return (x,y,z,dist);
		}
		public static (HObject x, HObject y, HObject z) DisparityImageToXyz (HObject disparity, HTuple camParamRect1, HTuple camParamRect2, HTuple relPoseRect)
		{
			HOperatorSet.DisparityImageToXyz(disparity, out HObject x, out HObject y, out HObject z, camParamRect1, camParamRect2, relPoseRect);
			return (x,y,z);
		}
		public static (HTuple x, HTuple y, HTuple z) DisparityToPoint3d (HTuple camParamRect1, HTuple camParamRect2, HTuple relPoseRect, HTuple row1, HTuple col1, HTuple disparity)
		{
			HOperatorSet.DisparityToPoint3d(camParamRect1, camParamRect2, relPoseRect, row1, col1, disparity, out HTuple x, out HTuple y, out HTuple z);
			return (x,y,z);
		}
		public static HTuple DisparityToDistance (HTuple camParamRect1, HTuple camParamRect2, HTuple relPoseRect, HTuple disparity)
		{
			HOperatorSet.DisparityToDistance(camParamRect1, camParamRect2, relPoseRect, disparity, out HTuple distance);
			return distance;
		}
		public static HTuple DistanceToDisparity (HTuple camParamRect1, HTuple camParamRect2, HTuple relPoseRect, HTuple distance)
		{
			HOperatorSet.DistanceToDisparity(camParamRect1, camParamRect2, relPoseRect, distance, out HTuple disparity);
			return disparity;
		}
		public static (HObject map1, HObject map2, HTuple camParamRect1, HTuple camParamRect2, HTuple camPoseRect1, HTuple camPoseRect2, HTuple relPoseRect) GenBinocularRectificationMap (HTuple camParam1, HTuple camParam2, HTuple relPose, HTuple subSampling, HTuple method, HTuple mapType)
		{
			HOperatorSet.GenBinocularRectificationMap(out HObject map1, out HObject map2, camParam1, camParam2, relPose, subSampling, method, mapType, out HTuple camParamRect1, out HTuple camParamRect2, out HTuple camPoseRect1, out HTuple camPoseRect2, out HTuple relPoseRect);
			return (map1,map2,camParamRect1,camParamRect2,camPoseRect1,camPoseRect2,relPoseRect);
		}
		public static (HTuple camParam1, HTuple camParam2, HTuple NFinalPose1, HTuple NFinalPose2, HTuple relPose, HTuple errors) BinocularCalibration (HTuple NX, HTuple NY, HTuple NZ, HTuple NRow1, HTuple NCol1, HTuple NRow2, HTuple NCol2, HTuple startCamParam1, HTuple startCamParam2, HTuple NStartPose1, HTuple NStartPose2, HTuple estimateParams)
		{
			HOperatorSet.BinocularCalibration(NX, NY, NZ, NRow1, NCol1, NRow2, NCol2, startCamParam1, startCamParam2, NStartPose1, NStartPose2, estimateParams, out HTuple camParam1, out HTuple camParam2, out HTuple NFinalPose1, out HTuple NFinalPose2, out HTuple relPose, out HTuple errors);
			return (camParam1,camParam2,NFinalPose1,NFinalPose2,relPose,errors);
		}
		public static (HTuple classes, HTuple values) QuerySpy ()
		{
			HOperatorSet.QuerySpy(out HTuple classes, out HTuple values);
			return (classes,values);
		}
		public static void SetSpy (HTuple classVal, HTuple value)
		{
			HOperatorSet.SetSpy(classVal, value);
		}
		public static HTuple GetSpy (HTuple classVal)
		{
			HOperatorSet.GetSpy(classVal, out HTuple value);
			return value;
		}
		public static HTuple ReadSheetOfLightModel (HTuple fileName)
		{
			HOperatorSet.ReadSheetOfLightModel(fileName, out HTuple sheetOfLightModelID);
			return sheetOfLightModelID;
		}
		public static void WriteSheetOfLightModel (HTuple sheetOfLightModelID, HTuple fileName)
		{
			HOperatorSet.WriteSheetOfLightModel(sheetOfLightModelID, fileName);
		}
		public static HTuple DeserializeSheetOfLightModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeSheetOfLightModel(serializedItemHandle, out HTuple sheetOfLightModelID);
			return sheetOfLightModelID;
		}
		public static HTuple SerializeSheetOfLightModel (HTuple sheetOfLightModelID)
		{
			HOperatorSet.SerializeSheetOfLightModel(sheetOfLightModelID, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static void CreateSheetOfLightCalibObject (HTuple width, HTuple length, HTuple heightMin, HTuple heightMax, HTuple fileName)
		{
			HOperatorSet.CreateSheetOfLightCalibObject(width, length, heightMin, heightMax, fileName);
		}
		public static HTuple CalibrateSheetOfLight (HTuple sheetOfLightModelID)
		{
			HOperatorSet.CalibrateSheetOfLight(sheetOfLightModelID, out HTuple error);
			return error;
		}
		public static HTuple GetSheetOfLightResultObjectModel3d (HTuple sheetOfLightModelID)
		{
			HOperatorSet.GetSheetOfLightResultObjectModel3d(sheetOfLightModelID, out HTuple objectModel3D);
			return objectModel3D;
		}
		public static HObject GetSheetOfLightResult (HTuple sheetOfLightModelID, HTuple resultName)
		{
			HOperatorSet.GetSheetOfLightResult(out HObject resultValue, sheetOfLightModelID, resultName);
			return resultValue;
		}
		public static void ApplySheetOfLightCalibration (HObject disparity, HTuple sheetOfLightModelID)
		{
			HOperatorSet.ApplySheetOfLightCalibration(disparity, sheetOfLightModelID);
		}
		public static void SetProfileSheetOfLight (HObject profileDisparityImage, HTuple sheetOfLightModelID, HTuple movementPoses)
		{
			HOperatorSet.SetProfileSheetOfLight(profileDisparityImage, sheetOfLightModelID, movementPoses);
		}
		public static HTuple TupleFindLast (HTuple tuple, HTuple toFind)
		{
			HOperatorSet.TupleFindLast(tuple, toFind, out HTuple index);
			return index;
		}
		public static HTuple TupleFindFirst (HTuple tuple, HTuple toFind)
		{
			HOperatorSet.TupleFindFirst(tuple, toFind, out HTuple index);
			return index;
		}
		public static HTuple TupleFind (HTuple tuple, HTuple toFind)
		{
			HOperatorSet.TupleFind(tuple, toFind, out HTuple indices);
			return indices;
		}
		public static HTuple TupleSortIndex (HTuple tuple)
		{
			HOperatorSet.TupleSortIndex(tuple, out HTuple indices);
			return indices;
		}
		public static HTuple TupleSort (HTuple tuple)
		{
			HOperatorSet.TupleSort(tuple, out HTuple sorted);
			return sorted;
		}
		public static HTuple TupleInverse (HTuple tuple)
		{
			HOperatorSet.TupleInverse(tuple, out HTuple inverted);
			return inverted;
		}
		public static HTuple TupleConcat (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleConcat(t1, t2, out HTuple concat);
			return concat;
		}
		public static HTuple TupleSelectRange (HTuple tuple, HTuple leftindex, HTuple rightindex)
		{
			HOperatorSet.TupleSelectRange(tuple, leftindex, rightindex, out HTuple selected);
			return selected;
		}
		public static HTuple TupleLastN (HTuple tuple, HTuple index)
		{
			HOperatorSet.TupleLastN(tuple, index, out HTuple selected);
			return selected;
		}
		public static HTuple TupleFirstN (HTuple tuple, HTuple index)
		{
			HOperatorSet.TupleFirstN(tuple, index, out HTuple selected);
			return selected;
		}
		public static HTuple TupleInsert (HTuple tuple, HTuple index, HTuple insertTuple)
		{
			HOperatorSet.TupleInsert(tuple, index, insertTuple, out HTuple extended);
			return extended;
		}
		public static HTuple TupleReplace (HTuple tuple, HTuple index, HTuple replaceTuple)
		{
			HOperatorSet.TupleReplace(tuple, index, replaceTuple, out HTuple replaced);
			return replaced;
		}
		public static HTuple TupleRemove (HTuple tuple, HTuple index)
		{
			HOperatorSet.TupleRemove(tuple, index, out HTuple reduced);
			return reduced;
		}
		public static HTuple TupleSelectMask (HTuple tuple, HTuple mask)
		{
			HOperatorSet.TupleSelectMask(tuple, mask, out HTuple selected);
			return selected;
		}
		public static HTuple TupleSelect (HTuple tuple, HTuple index)
		{
			HOperatorSet.TupleSelect(tuple, index, out HTuple selected);
			return selected;
		}
		public static HTuple TupleStrBitSelect (HTuple tuple, HTuple index)
		{
			HOperatorSet.TupleStrBitSelect(tuple, index, out HTuple selected);
			return selected;
		}
		public static HTuple TupleGenSequence (HTuple start, HTuple end, HTuple step)
		{
			HOperatorSet.TupleGenSequence(start, end, step, out HTuple sequence);
			return sequence;
		}
		public static HTuple TupleGenConst (HTuple length, HTuple constVal)
		{
			HOperatorSet.TupleGenConst(length, constVal, out HTuple newtuple);
			return newtuple;
		}
		public static HTuple TupleEnvironment (HTuple names)
		{
			HOperatorSet.TupleEnvironment(names, out HTuple values);
			return values;
		}
		public static HTuple TupleSplit (HTuple stringVal, HTuple separator)
		{
			HOperatorSet.TupleSplit(stringVal, separator, out HTuple substrings);
			return substrings;
		}
		public static HTuple TupleSubstr (HTuple stringVal, HTuple position1, HTuple position2)
		{
			HOperatorSet.TupleSubstr(stringVal, position1, position2, out HTuple substring);
			return substring;
		}
		public static HTuple TupleStrLastN (HTuple stringVal, HTuple position)
		{
			HOperatorSet.TupleStrLastN(stringVal, position, out HTuple substring);
			return substring;
		}
		public static HTuple TupleStrFirstN (HTuple stringVal, HTuple position)
		{
			HOperatorSet.TupleStrFirstN(stringVal, position, out HTuple substring);
			return substring;
		}
		public static HTuple TupleStrrchr (HTuple stringVal, HTuple toFind)
		{
			HOperatorSet.TupleStrrchr(stringVal, toFind, out HTuple position);
			return position;
		}
		public static HTuple TupleStrchr (HTuple stringVal, HTuple toFind)
		{
			HOperatorSet.TupleStrchr(stringVal, toFind, out HTuple position);
			return position;
		}
		public static HTuple TupleStrrstr (HTuple stringVal, HTuple toFind)
		{
			HOperatorSet.TupleStrrstr(stringVal, toFind, out HTuple position);
			return position;
		}
		public static HTuple TupleStrstr (HTuple stringVal, HTuple toFind)
		{
			HOperatorSet.TupleStrstr(stringVal, toFind, out HTuple position);
			return position;
		}
		public static HTuple TupleStrlen (HTuple t1)
		{
			HOperatorSet.TupleStrlen(t1, out HTuple length);
			return length;
		}
		public static HTuple TupleLessEqualElem (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleLessEqualElem(t1, t2, out HTuple lesseq);
			return lesseq;
		}
		public static HTuple TupleLessElem (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleLessElem(t1, t2, out HTuple less);
			return less;
		}
		public static HTuple TupleGreaterEqualElem (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleGreaterEqualElem(t1, t2, out HTuple greatereq);
			return greatereq;
		}
		public static HTuple TupleGreaterElem (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleGreaterElem(t1, t2, out HTuple greater);
			return greater;
		}
		public static HTuple TupleNotEqualElem (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleNotEqualElem(t1, t2, out HTuple nequal);
			return nequal;
		}
		public static HTuple TupleEqualElem (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleEqualElem(t1, t2, out HTuple equal);
			return equal;
		}
		public static HTuple TupleLessEqual (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleLessEqual(t1, t2, out HTuple lesseq);
			return lesseq;
		}
		public static HTuple TupleLess (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleLess(t1, t2, out HTuple less);
			return less;
		}
		public static HTuple TupleGreaterEqual (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleGreaterEqual(t1, t2, out HTuple greatereq);
			return greatereq;
		}
		public static HTuple TupleGreater (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleGreater(t1, t2, out HTuple greater);
			return greater;
		}
		public static HTuple TupleNotEqual (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleNotEqual(t1, t2, out HTuple nequal);
			return nequal;
		}
		public static HTuple TupleEqual (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleEqual(t1, t2, out HTuple equal);
			return equal;
		}
		public static HTuple TupleNot (HTuple t)
		{
			HOperatorSet.TupleNot(t, out HTuple not);
			return not;
		}
		public static HTuple TupleXor (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleXor(t1, t2, out HTuple xor);
			return xor;
		}
		public static HTuple TupleOr (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleOr(t1, t2, out HTuple or);
			return or;
		}
		public static HTuple TupleAnd (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleAnd(t1, t2, out HTuple and);
			return and;
		}
		public static HTuple TupleBnot (HTuple t)
		{
			HOperatorSet.TupleBnot(t, out HTuple BNot);
			return BNot;
		}
		public static HTuple TupleBxor (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleBxor(t1, t2, out HTuple BXor);
			return BXor;
		}
		public static HTuple TupleBor (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleBor(t1, t2, out HTuple BOr);
			return BOr;
		}
		public static HTuple TupleBand (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleBand(t1, t2, out HTuple BAnd);
			return BAnd;
		}
		public static HTuple TupleRsh (HTuple t, HTuple shift)
		{
			HOperatorSet.TupleRsh(t, shift, out HTuple rsh);
			return rsh;
		}
		public static HTuple TupleLsh (HTuple t, HTuple shift)
		{
			HOperatorSet.TupleLsh(t, shift, out HTuple lsh);
			return lsh;
		}
		public static HTuple TupleChrt (HTuple t)
		{
			HOperatorSet.TupleChrt(t, out HTuple chrt);
			return chrt;
		}
		public static HTuple TupleOrds (HTuple t)
		{
			HOperatorSet.TupleOrds(t, out HTuple ords);
			return ords;
		}
		public static HTuple TupleChr (HTuple t)
		{
			HOperatorSet.TupleChr(t, out HTuple chr);
			return chr;
		}
		public static HTuple TupleOrd (HTuple t)
		{
			HOperatorSet.TupleOrd(t, out HTuple ord);
			return ord;
		}
		public static HTuple TupleString (HTuple t, HTuple format)
		{
			HOperatorSet.TupleString(t, format, out HTuple stringVal);
			return stringVal;
		}
		public static HTuple TupleIsNumber (HTuple t)
		{
			HOperatorSet.TupleIsNumber(t, out HTuple isNumber);
			return isNumber;
		}
		public static HTuple TupleNumber (HTuple t)
		{
			HOperatorSet.TupleNumber(t, out HTuple number);
			return number;
		}
		public static HTuple TupleRound (HTuple t)
		{
			HOperatorSet.TupleRound(t, out HTuple round);
			return round;
		}
		public static HTuple TupleInt (HTuple t)
		{
			HOperatorSet.TupleInt(t, out HTuple intVal);
			return intVal;
		}
		public static HTuple TupleReal (HTuple t)
		{
			HOperatorSet.TupleReal(t, out HTuple real);
			return real;
		}
		public static HTuple TupleLdexp (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleLdexp(t1, t2, out HTuple ldexp);
			return ldexp;
		}
		public static HTuple TupleFmod (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleFmod(t1, t2, out HTuple fmod);
			return fmod;
		}
		public static HTuple TupleMod (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleMod(t1, t2, out HTuple mod);
			return mod;
		}
		public static HTuple TupleCeil (HTuple t)
		{
			HOperatorSet.TupleCeil(t, out HTuple ceil);
			return ceil;
		}
		public static HTuple TupleFloor (HTuple t)
		{
			HOperatorSet.TupleFloor(t, out HTuple floor);
			return floor;
		}
		public static HTuple TuplePow (HTuple t1, HTuple t2)
		{
			HOperatorSet.TuplePow(t1, t2, out HTuple pow);
			return pow;
		}
		public static HTuple TupleLog10 (HTuple t)
		{
			HOperatorSet.TupleLog10(t, out HTuple log);
			return log;
		}
		public static HTuple TupleLog (HTuple t)
		{
			HOperatorSet.TupleLog(t, out HTuple log);
			return log;
		}
		public static HTuple TupleExp (HTuple t)
		{
			HOperatorSet.TupleExp(t, out HTuple exp);
			return exp;
		}
		public static HTuple TupleTanh (HTuple t)
		{
			HOperatorSet.TupleTanh(t, out HTuple tanh);
			return tanh;
		}
		public static HTuple TupleCosh (HTuple t)
		{
			HOperatorSet.TupleCosh(t, out HTuple cosh);
			return cosh;
		}
		public static HTuple TupleSinh (HTuple t)
		{
			HOperatorSet.TupleSinh(t, out HTuple sinh);
			return sinh;
		}
		public static HTuple TupleRad (HTuple deg)
		{
			HOperatorSet.TupleRad(deg, out HTuple rad);
			return rad;
		}
		public static HTuple TupleDeg (HTuple rad)
		{
			HOperatorSet.TupleDeg(rad, out HTuple deg);
			return deg;
		}
		public static HTuple TupleAtan2 (HTuple y, HTuple x)
		{
			HOperatorSet.TupleAtan2(y, x, out HTuple ATan);
			return ATan;
		}
		public static HTuple TupleAtan (HTuple t)
		{
			HOperatorSet.TupleAtan(t, out HTuple ATan);
			return ATan;
		}
		public static HTuple TupleAcos (HTuple t)
		{
			HOperatorSet.TupleAcos(t, out HTuple ACos);
			return ACos;
		}
		public static HTuple TupleAsin (HTuple t)
		{
			HOperatorSet.TupleAsin(t, out HTuple ASin);
			return ASin;
		}
		public static HTuple TupleTan (HTuple t)
		{
			HOperatorSet.TupleTan(t, out HTuple tan);
			return tan;
		}
		public static HTuple TupleCos (HTuple t)
		{
			HOperatorSet.TupleCos(t, out HTuple cos);
			return cos;
		}
		public static HTuple TupleSin (HTuple t)
		{
			HOperatorSet.TupleSin(t, out HTuple sin);
			return sin;
		}
		public static HTuple TupleFabs (HTuple t)
		{
			HOperatorSet.TupleFabs(t, out HTuple abs);
			return abs;
		}
		public static HTuple TupleSqrt (HTuple t)
		{
			HOperatorSet.TupleSqrt(t, out HTuple sqrt);
			return sqrt;
		}
		public static HTuple TupleAbs (HTuple t)
		{
			HOperatorSet.TupleAbs(t, out HTuple abs);
			return abs;
		}
		public static HTuple TupleNeg (HTuple t)
		{
			HOperatorSet.TupleNeg(t, out HTuple neg);
			return neg;
		}
		public static HTuple TupleDiv (HTuple q1, HTuple q2)
		{
			HOperatorSet.TupleDiv(q1, q2, out HTuple quot);
			return quot;
		}
		public static HTuple TupleMult (HTuple p1, HTuple p2)
		{
			HOperatorSet.TupleMult(p1, p2, out HTuple prod);
			return prod;
		}
		public static HTuple TupleSub (HTuple d1, HTuple d2)
		{
			HOperatorSet.TupleSub(d1, d2, out HTuple diff);
			return diff;
		}
		public static HTuple TupleAdd (HTuple s1, HTuple s2)
		{
			HOperatorSet.TupleAdd(s1, s2, out HTuple sum);
			return sum;
		}
		public static HTuple DeserializeTuple (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeTuple(serializedItemHandle, out HTuple tuple);
			return tuple;
		}
		public static HTuple SerializeTuple (HTuple tuple)
		{
			HOperatorSet.SerializeTuple(tuple, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static void WriteTuple (HTuple tuple, HTuple fileName)
		{
			HOperatorSet.WriteTuple(tuple, fileName);
		}
		public static HTuple ReadTuple (HTuple fileName)
		{
			HOperatorSet.ReadTuple(fileName, out HTuple tuple);
			return tuple;
		}
		public static (HTuple averagePose, HTuple quality) PoseAverage (HTuple poses, HTuple weights, HTuple mode, HTuple sigmaT, HTuple sigmaR)
		{
			HOperatorSet.PoseAverage(poses, weights, mode, sigmaT, sigmaR, out HTuple averagePose, out HTuple quality);
			return (averagePose,quality);
		}
		public static (HTuple qx, HTuple qy, HTuple qz) QuatRotatePoint3d (HTuple quaternion, HTuple px, HTuple py, HTuple pz)
		{
			HOperatorSet.QuatRotatePoint3d(quaternion, px, py, pz, out HTuple qx, out HTuple qy, out HTuple qz);
			return (qx,qy,qz);
		}
		public static HTuple QuatConjugate (HTuple quaternion)
		{
			HOperatorSet.QuatConjugate(quaternion, out HTuple conjugatedQuaternion);
			return conjugatedQuaternion;
		}
		public static HTuple QuatNormalize (HTuple quaternion)
		{
			HOperatorSet.QuatNormalize(quaternion, out HTuple normalizedQuaternion);
			return normalizedQuaternion;
		}
		public static HTuple AxisAngleToQuat (HTuple axisX, HTuple axisY, HTuple axisZ, HTuple angle)
		{
			HOperatorSet.AxisAngleToQuat(axisX, axisY, axisZ, angle, out HTuple quaternion);
			return quaternion;
		}
		public static HTuple QuatToPose (HTuple quaternion)
		{
			HOperatorSet.QuatToPose(quaternion, out HTuple pose);
			return pose;
		}
		public static HTuple PoseInvert (HTuple pose)
		{
			HOperatorSet.PoseInvert(pose, out HTuple poseInvert);
			return poseInvert;
		}
		public static HTuple PoseCompose (HTuple poseLeft, HTuple poseRight)
		{
			HOperatorSet.PoseCompose(poseLeft, poseRight, out HTuple poseCompose);
			return poseCompose;
		}
		public static HTuple QuatToHomMat3d (HTuple quaternion)
		{
			HOperatorSet.QuatToHomMat3d(quaternion, out HTuple rotationMatrix);
			return rotationMatrix;
		}
		public static HTuple PoseToQuat (HTuple pose)
		{
			HOperatorSet.PoseToQuat(pose, out HTuple quaternion);
			return quaternion;
		}
		public static HTuple QuatInterpolate (HTuple quaternionStart, HTuple quaternionEnd, HTuple interpPos)
		{
			HOperatorSet.QuatInterpolate(quaternionStart, quaternionEnd, interpPos, out HTuple quaternionInterpolated);
			return quaternionInterpolated;
		}
		public static HTuple QuatCompose (HTuple quaternionLeft, HTuple quaternionRight)
		{
			HOperatorSet.QuatCompose(quaternionLeft, quaternionRight, out HTuple quaternionComposed);
			return quaternionComposed;
		}
		public static HTuple DeserializeHomMat3d (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeHomMat3d(serializedItemHandle, out HTuple homMat3D);
			return homMat3D;
		}
		public static HTuple SerializeHomMat3d (HTuple homMat3D)
		{
			HOperatorSet.SerializeHomMat3d(homMat3D, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple DeserializeHomMat2d (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeHomMat2d(serializedItemHandle, out HTuple homMat2D);
			return homMat2D;
		}
		public static HTuple SerializeHomMat2d (HTuple homMat2D)
		{
			HOperatorSet.SerializeHomMat2d(homMat2D, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple DeserializeQuat (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeQuat(serializedItemHandle, out HTuple quaternion);
			return quaternion;
		}
		public static HTuple SerializeQuat (HTuple quaternion)
		{
			HOperatorSet.SerializeQuat(quaternion, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static (HTuple qx, HTuple qy, HTuple qz, HTuple qw) ProjectiveTransHomPoint3d (HTuple homMat3D, HTuple px, HTuple py, HTuple pz, HTuple pw)
		{
			HOperatorSet.ProjectiveTransHomPoint3d(homMat3D, px, py, pz, pw, out HTuple qx, out HTuple qy, out HTuple qz, out HTuple qw);
			return (qx,qy,qz,qw);
		}
		public static (HTuple qx, HTuple qy, HTuple qz) ProjectiveTransPoint3d (HTuple homMat3D, HTuple px, HTuple py, HTuple pz)
		{
			HOperatorSet.ProjectiveTransPoint3d(homMat3D, px, py, pz, out HTuple qx, out HTuple qy, out HTuple qz);
			return (qx,qy,qz);
		}
		public static (HTuple qx, HTuple qy, HTuple qz) AffineTransPoint3d (HTuple homMat3D, HTuple px, HTuple py, HTuple pz)
		{
			HOperatorSet.AffineTransPoint3d(homMat3D, px, py, pz, out HTuple qx, out HTuple qy, out HTuple qz);
			return (qx,qy,qz);
		}
		public static HTuple VectorToHomMat3d (HTuple transformationType, HTuple px, HTuple py, HTuple pz, HTuple qx, HTuple qy, HTuple qz)
		{
			HOperatorSet.VectorToHomMat3d(transformationType, px, py, pz, qx, qy, qz, out HTuple homMat3D);
			return homMat3D;
		}
		public static HTuple HomMat3dDeterminant (HTuple homMat3D)
		{
			HOperatorSet.HomMat3dDeterminant(homMat3D, out HTuple determinant);
			return determinant;
		}
		public static HTuple HomMat3dTranspose (HTuple homMat3D)
		{
			HOperatorSet.HomMat3dTranspose(homMat3D, out HTuple homMat3DTranspose);
			return homMat3DTranspose;
		}
		public static HTuple HomMat3dInvert (HTuple homMat3D)
		{
			HOperatorSet.HomMat3dInvert(homMat3D, out HTuple homMat3DInvert);
			return homMat3DInvert;
		}
		public static HTuple HomMat3dCompose (HTuple homMat3DLeft, HTuple homMat3DRight)
		{
			HOperatorSet.HomMat3dCompose(homMat3DLeft, homMat3DRight, out HTuple homMat3DCompose);
			return homMat3DCompose;
		}
		public static HTuple HomMat3dRotateLocal (HTuple homMat3D, HTuple phi, HTuple axis)
		{
			HOperatorSet.HomMat3dRotateLocal(homMat3D, phi, axis, out HTuple homMat3DRotate);
			return homMat3DRotate;
		}
		public static HTuple HomMat3dRotate (HTuple homMat3D, HTuple phi, HTuple axis, HTuple px, HTuple py, HTuple pz)
		{
			HOperatorSet.HomMat3dRotate(homMat3D, phi, axis, px, py, pz, out HTuple homMat3DRotate);
			return homMat3DRotate;
		}
		public static HTuple HomMat3dScaleLocal (HTuple homMat3D, HTuple sx, HTuple sy, HTuple sz)
		{
			HOperatorSet.HomMat3dScaleLocal(homMat3D, sx, sy, sz, out HTuple homMat3DScale);
			return homMat3DScale;
		}
		public static HTuple HomMat3dScale (HTuple homMat3D, HTuple sx, HTuple sy, HTuple sz, HTuple px, HTuple py, HTuple pz)
		{
			HOperatorSet.HomMat3dScale(homMat3D, sx, sy, sz, px, py, pz, out HTuple homMat3DScale);
			return homMat3DScale;
		}
		public static HTuple HomMat3dTranslateLocal (HTuple homMat3D, HTuple tx, HTuple ty, HTuple tz)
		{
			HOperatorSet.HomMat3dTranslateLocal(homMat3D, tx, ty, tz, out HTuple homMat3DTranslate);
			return homMat3DTranslate;
		}
		public static HTuple HomMat3dTranslate (HTuple homMat3D, HTuple tx, HTuple ty, HTuple tz)
		{
			HOperatorSet.HomMat3dTranslate(homMat3D, tx, ty, tz, out HTuple homMat3DTranslate);
			return homMat3DTranslate;
		}
		public static HTuple HomMat3dIdentity ()
		{
			HOperatorSet.HomMat3dIdentity(out HTuple homMat3DIdentity);
			return homMat3DIdentity;
		}
		public static HTuple HomMat3dProject (HTuple homMat3D, HTuple principalPointRow, HTuple principalPointCol, HTuple focus)
		{
			HOperatorSet.HomMat3dProject(homMat3D, principalPointRow, principalPointCol, focus, out HTuple homMat2D);
			return homMat2D;
		}
		public static (HTuple mosaicMatrices2D, HTuple rows, HTuple cols, HTuple error) BundleAdjustMosaic (HTuple numImages, HTuple referenceImage, HTuple mappingSource, HTuple mappingDest, HTuple homMatrices2D, HTuple rows1, HTuple cols1, HTuple rows2, HTuple cols2, HTuple numCorrespondences, HTuple transformation)
		{
			HOperatorSet.BundleAdjustMosaic(numImages, referenceImage, mappingSource, mappingDest, homMatrices2D, rows1, cols1, rows2, cols2, numCorrespondences, transformation, out HTuple mosaicMatrices2D, out HTuple rows, out HTuple cols, out HTuple error);
			return (mosaicMatrices2D,rows,cols,error);
		}
		public static HObject UnionCotangentialContoursXld (HObject contours, HTuple fitClippingLength, HTuple fitLength, HTuple maxTangAngle, HTuple maxDist, HTuple maxDistPerp, HTuple maxOverlap, HTuple mode)
		{
			HOperatorSet.UnionCotangentialContoursXld(contours, out HObject unionContours, fitClippingLength, fitLength, maxTangAngle, maxDist, maxDistPerp, maxOverlap, mode);
			return unionContours;
		}
		public static HObject PolarTransContourXldInv (HObject polarContour, HTuple row, HTuple column, HTuple angleStart, HTuple angleEnd, HTuple radiusStart, HTuple radiusEnd, HTuple widthIn, HTuple heightIn, HTuple width, HTuple height)
		{
			HOperatorSet.PolarTransContourXldInv(polarContour, out HObject XYTransContour, row, column, angleStart, angleEnd, radiusStart, radiusEnd, widthIn, heightIn, width, height);
			return XYTransContour;
		}
		public static HObject PolarTransContourXld (HObject contour, HTuple row, HTuple column, HTuple angleStart, HTuple angleEnd, HTuple radiusStart, HTuple radiusEnd, HTuple width, HTuple height)
		{
			HOperatorSet.PolarTransContourXld(contour, out HObject polarTransContour, row, column, angleStart, angleEnd, radiusStart, radiusEnd, width, height);
			return polarTransContour;
		}
		public static (HTuple ctrlRows, HTuple ctrlCols, HTuple knots) GenNurbsInterp (HTuple rows, HTuple cols, HTuple tangents, HTuple degree)
		{
			HOperatorSet.GenNurbsInterp(rows, cols, tangents, degree, out HTuple ctrlRows, out HTuple ctrlCols, out HTuple knots);
			return (ctrlRows,ctrlCols,knots);
		}
		public static HObject GenContourNurbsXld (HTuple rows, HTuple cols, HTuple knots, HTuple weights, HTuple degree, HTuple maxError, HTuple maxDistance)
		{
			HOperatorSet.GenContourNurbsXld(out HObject contour, rows, cols, knots, weights, degree, maxError, maxDistance);
			return contour;
		}
		public static HObject Union2ClosedPolygonsXld (HObject polygons1, HObject polygons2)
		{
			HOperatorSet.Union2ClosedPolygonsXld(polygons1, polygons2, out HObject polygonsUnion);
			return polygonsUnion;
		}
		public static HObject Union2ClosedContoursXld (HObject contours1, HObject contours2)
		{
			HOperatorSet.Union2ClosedContoursXld(contours1, contours2, out HObject contoursUnion);
			return contoursUnion;
		}
		public static HObject SymmDifferenceClosedPolygonsXld (HObject polygons1, HObject polygons2)
		{
			HOperatorSet.SymmDifferenceClosedPolygonsXld(polygons1, polygons2, out HObject polygonsDifference);
			return polygonsDifference;
		}
		public static HObject SymmDifferenceClosedContoursXld (HObject contours1, HObject contours2)
		{
			HOperatorSet.SymmDifferenceClosedContoursXld(contours1, contours2, out HObject contoursDifference);
			return contoursDifference;
		}
		public static HObject DifferenceClosedPolygonsXld (HObject polygons, HObject sub)
		{
			HOperatorSet.DifferenceClosedPolygonsXld(polygons, sub, out HObject polygonsDifference);
			return polygonsDifference;
		}
		public static HObject DifferenceClosedContoursXld (HObject contours, HObject sub)
		{
			HOperatorSet.DifferenceClosedContoursXld(contours, sub, out HObject contoursDifference);
			return contoursDifference;
		}
		public static HObject IntersectionClosedPolygonsXld (HObject polygons1, HObject polygons2)
		{
			HOperatorSet.IntersectionClosedPolygonsXld(polygons1, polygons2, out HObject polygonsIntersection);
			return polygonsIntersection;
		}
		public static HObject IntersectionClosedContoursXld (HObject contours1, HObject contours2)
		{
			HOperatorSet.IntersectionClosedContoursXld(contours1, contours2, out HObject contoursIntersection);
			return contoursIntersection;
		}
		public static HObject UnionCocircularContoursXld (HObject contours, HTuple maxArcAngleDiff, HTuple maxArcOverlap, HTuple maxTangentAngle, HTuple maxDist, HTuple maxRadiusDiff, HTuple maxCenterDist, HTuple mergeSmallContours, HTuple iterations)
		{
			HOperatorSet.UnionCocircularContoursXld(contours, out HObject unionContours, maxArcAngleDiff, maxArcOverlap, maxTangentAngle, maxDist, maxRadiusDiff, maxCenterDist, mergeSmallContours, iterations);
			return unionContours;
		}
		public static HObject CropContoursXld (HObject contours, HTuple row1, HTuple col1, HTuple row2, HTuple col2, HTuple closeContours)
		{
			HOperatorSet.CropContoursXld(contours, out HObject croppedContours, row1, col1, row2, col2, closeContours);
			return croppedContours;
		}
		public static HObject GenCrossContourXld (HTuple row, HTuple col, HTuple size, HTuple angle)
		{
			HOperatorSet.GenCrossContourXld(out HObject cross, row, col, size, angle);
			return cross;
		}
		public static HObject SortContoursXld (HObject contours, HTuple sortMode, HTuple order, HTuple rowOrCol)
		{
			HOperatorSet.SortContoursXld(contours, out HObject sortedContours, sortMode, order, rowOrCol);
			return sortedContours;
		}
		public static (HObject currMergedConts, HObject prevMergedConts) MergeContLineScanXld (HObject currConts, HObject prevConts, HTuple imageHeight, HTuple margin, HTuple mergeBorder, HTuple maxImagesCont)
		{
			HOperatorSet.MergeContLineScanXld(currConts, prevConts, out HObject currMergedConts, out HObject prevMergedConts, imageHeight, margin, mergeBorder, maxImagesCont);
			return (currMergedConts,prevMergedConts);
		}
		public static HObject ReadPolygonXldArcInfo (HTuple fileName)
		{
			HOperatorSet.ReadPolygonXldArcInfo(out HObject polygons, fileName);
			return polygons;
		}
		public static void WritePolygonXldArcInfo (HObject polygons, HTuple fileName)
		{
			HOperatorSet.WritePolygonXldArcInfo(polygons, fileName);
		}
		public static HObject ReadContourXldArcInfo (HTuple fileName)
		{
			HOperatorSet.ReadContourXldArcInfo(out HObject contours, fileName);
			return contours;
		}
		public static void WriteContourXldArcInfo (HObject contours, HTuple fileName)
		{
			HOperatorSet.WriteContourXldArcInfo(contours, fileName);
		}
		public static HTuple ReadWorldFile (HTuple fileName)
		{
			HOperatorSet.ReadWorldFile(fileName, out HTuple worldTransformation);
			return worldTransformation;
		}
		public static HObject GenParallelContourXld (HObject contours, HTuple mode, HTuple distance)
		{
			HOperatorSet.GenParallelContourXld(contours, out HObject parallelContours, mode, distance);
			return parallelContours;
		}
		public static HObject GenRectangle2ContourXld (HTuple row, HTuple column, HTuple phi, HTuple length1, HTuple length2)
		{
			HOperatorSet.GenRectangle2ContourXld(out HObject rectangle, row, column, phi, length1, length2);
			return rectangle;
		}
		public static HTuple DistRectangle2ContourPointsXld (HObject contour, HTuple clippingEndPoints, HTuple row, HTuple column, HTuple phi, HTuple length1, HTuple length2)
		{
			HOperatorSet.DistRectangle2ContourPointsXld(contour, clippingEndPoints, row, column, phi, length1, length2, out HTuple distances);
			return distances;
		}
		public static (HTuple row, HTuple column, HTuple phi, HTuple length1, HTuple length2, HTuple pointOrder) FitRectangle2ContourXld (HObject contours, HTuple algorithm, HTuple maxNumPoints, HTuple maxClosureDist, HTuple clippingEndPoints, HTuple iterations, HTuple clippingFactor)
		{
			HOperatorSet.FitRectangle2ContourXld(contours, algorithm, maxNumPoints, maxClosureDist, clippingEndPoints, iterations, clippingFactor, out HTuple row, out HTuple column, out HTuple phi, out HTuple length1, out HTuple length2, out HTuple pointOrder);
			return (row,column,phi,length1,length2,pointOrder);
		}
		public static HObject SegmentContourAttribXld (HObject contour, HTuple attribute, HTuple operation, HTuple min, HTuple max)
		{
			HOperatorSet.SegmentContourAttribXld(contour, out HObject contourPart, attribute, operation, min, max);
			return contourPart;
		}
		public static HObject SegmentContoursXld (HObject contours, HTuple mode, HTuple smoothCont, HTuple maxLineDist1, HTuple maxLineDist2)
		{
			HOperatorSet.SegmentContoursXld(contours, out HObject contoursSplit, mode, smoothCont, maxLineDist1, maxLineDist2);
			return contoursSplit;
		}
		public static (HTuple row, HTuple column, HTuple radius, HTuple startPhi, HTuple endPhi, HTuple pointOrder) FitCircleContourXld (HObject contours, HTuple algorithm, HTuple maxNumPoints, HTuple maxClosureDist, HTuple clippingEndPoints, HTuple iterations, HTuple clippingFactor)
		{
			HOperatorSet.FitCircleContourXld(contours, algorithm, maxNumPoints, maxClosureDist, clippingEndPoints, iterations, clippingFactor, out HTuple row, out HTuple column, out HTuple radius, out HTuple startPhi, out HTuple endPhi, out HTuple pointOrder);
			return (row,column,radius,startPhi,endPhi,pointOrder);
		}
		public static (HTuple rowBegin, HTuple colBegin, HTuple rowEnd, HTuple colEnd, HTuple nr, HTuple nc, HTuple dist) FitLineContourXld (HObject contours, HTuple algorithm, HTuple maxNumPoints, HTuple clippingEndPoints, HTuple iterations, HTuple clippingFactor)
		{
			HOperatorSet.FitLineContourXld(contours, algorithm, maxNumPoints, clippingEndPoints, iterations, clippingFactor, out HTuple rowBegin, out HTuple colBegin, out HTuple rowEnd, out HTuple colEnd, out HTuple nr, out HTuple nc, out HTuple dist);
			return (rowBegin,colBegin,rowEnd,colEnd,nr,nc,dist);
		}
		public static HTuple DistEllipseContourPointsXld (HObject contour, HTuple distanceMode, HTuple clippingEndPoints, HTuple row, HTuple column, HTuple phi, HTuple radius1, HTuple radius2)
		{
			HOperatorSet.DistEllipseContourPointsXld(contour, distanceMode, clippingEndPoints, row, column, phi, radius1, radius2, out HTuple distances);
			return distances;
		}
		public static (HTuple minDist, HTuple maxDist, HTuple avgDist, HTuple sigmaDist) DistEllipseContourXld (HObject contours, HTuple mode, HTuple maxNumPoints, HTuple clippingEndPoints, HTuple row, HTuple column, HTuple phi, HTuple radius1, HTuple radius2)
		{
			HOperatorSet.DistEllipseContourXld(contours, mode, maxNumPoints, clippingEndPoints, row, column, phi, radius1, radius2, out HTuple minDist, out HTuple maxDist, out HTuple avgDist, out HTuple sigmaDist);
			return (minDist,maxDist,avgDist,sigmaDist);
		}
		public static (HTuple row, HTuple column, HTuple phi, HTuple radius1, HTuple radius2, HTuple startPhi, HTuple endPhi, HTuple pointOrder) FitEllipseContourXld (HObject contours, HTuple algorithm, HTuple maxNumPoints, HTuple maxClosureDist, HTuple clippingEndPoints, HTuple vossTabSize, HTuple iterations, HTuple clippingFactor)
		{
			HOperatorSet.FitEllipseContourXld(contours, algorithm, maxNumPoints, maxClosureDist, clippingEndPoints, vossTabSize, iterations, clippingFactor, out HTuple row, out HTuple column, out HTuple phi, out HTuple radius1, out HTuple radius2, out HTuple startPhi, out HTuple endPhi, out HTuple pointOrder);
			return (row,column,phi,radius1,radius2,startPhi,endPhi,pointOrder);
		}
		public static HObject GenCircleContourXld (HTuple row, HTuple column, HTuple radius, HTuple startPhi, HTuple endPhi, HTuple pointOrder, HTuple resolution)
		{
			HOperatorSet.GenCircleContourXld(out HObject contCircle, row, column, radius, startPhi, endPhi, pointOrder, resolution);
			return contCircle;
		}
		public static HObject GenEllipseContourXld (HTuple row, HTuple column, HTuple phi, HTuple radius1, HTuple radius2, HTuple startPhi, HTuple endPhi, HTuple pointOrder, HTuple resolution)
		{
			HOperatorSet.GenEllipseContourXld(out HObject contEllipse, row, column, phi, radius1, radius2, startPhi, endPhi, pointOrder, resolution);
			return contEllipse;
		}
		public static HObject AddNoiseWhiteContourXld (HObject contours, HTuple numRegrPoints, HTuple amp)
		{
			HOperatorSet.AddNoiseWhiteContourXld(contours, out HObject noisyContours, numRegrPoints, amp);
			return noisyContours;
		}
		public static HObject CombineRoadsXld (HObject edgePolygons, HObject modParallels, HObject extParallels, HObject centerLines, HTuple maxAngleParallel, HTuple maxAngleColinear, HTuple maxDistanceParallel, HTuple maxDistanceColinear)
		{
			HOperatorSet.CombineRoadsXld(edgePolygons, modParallels, extParallels, centerLines, out HObject roadSides, maxAngleParallel, maxAngleColinear, maxDistanceParallel, maxDistanceColinear);
			return roadSides;
		}
		public static HObject MaxParallelsXld (HObject extParallels)
		{
			HOperatorSet.MaxParallelsXld(extParallels, out HObject maxPolygons);
			return maxPolygons;
		}
		public static (HObject modParallels, HObject extParallels) ModParallelsXld (HObject parallels, HObject image, HTuple quality, HTuple minGray, HTuple maxGray, HTuple maxStandard)
		{
			HOperatorSet.ModParallelsXld(parallels, image, out HObject modParallels, out HObject extParallels, quality, minGray, maxGray, maxStandard);
			return (modParallels,extParallels);
		}
		public static (HTuple qualityMin, HTuple qualityMax, HTuple grayMin, HTuple grayMax, HTuple standardMin, HTuple standardMax) InfoParallelsXld (HObject parallels, HObject image)
		{
			HOperatorSet.InfoParallelsXld(parallels, image, out HTuple qualityMin, out HTuple qualityMax, out HTuple grayMin, out HTuple grayMax, out HTuple standardMin, out HTuple standardMax);
			return (qualityMin,qualityMax,grayMin,grayMax,standardMin,standardMax);
		}
		public static (HTuple row1, HTuple col1, HTuple length1, HTuple phi1, HTuple row2, HTuple col2, HTuple length2, HTuple phi2) GetParallelsXld (HObject parallels)
		{
			HOperatorSet.GetParallelsXld(parallels, out HTuple row1, out HTuple col1, out HTuple length1, out HTuple phi1, out HTuple row2, out HTuple col2, out HTuple length2, out HTuple phi2);
			return (row1,col1,length1,phi1,row2,col2,length2,phi2);
		}
		public static HObject GenParallelsXld (HObject polygons, HTuple len, HTuple dist, HTuple alpha, HTuple merge)
		{
			HOperatorSet.GenParallelsXld(polygons, out HObject parallels, len, dist, alpha, merge);
			return parallels;
		}
		public static (HTuple beginRow, HTuple beginCol, HTuple endRow, HTuple endCol, HTuple length, HTuple phi) GetLinesXld (HObject polygon)
		{
			HOperatorSet.GetLinesXld(polygon, out HTuple beginRow, out HTuple beginCol, out HTuple endRow, out HTuple endCol, out HTuple length, out HTuple phi);
			return (beginRow,beginCol,endRow,endCol,length,phi);
		}
		public static (HTuple row, HTuple col, HTuple length, HTuple phi) GetPolygonXld (HObject polygon)
		{
			HOperatorSet.GetPolygonXld(polygon, out HTuple row, out HTuple col, out HTuple length, out HTuple phi);
			return (row,col,length,phi);
		}
		public static HObject GenPolygonsXld (HObject contours, HTuple type, HTuple alpha)
		{
			HOperatorSet.GenPolygonsXld(contours, out HObject polygons, type, alpha);
			return polygons;
		}
		public static HObject SplitContoursXld (HObject polygons, HTuple mode, HTuple weight, HTuple smooth)
		{
			HOperatorSet.SplitContoursXld(polygons, out HObject contours, mode, weight, smooth);
			return contours;
		}
		public static HObject ProjectiveTransContourXld (HObject contours, HTuple homMat2D)
		{
			HOperatorSet.ProjectiveTransContourXld(contours, out HObject contoursProjTrans, homMat2D);
			return contoursProjTrans;
		}
		public static HObject AffineTransPolygonXld (HObject polygons, HTuple homMat2D)
		{
			HOperatorSet.AffineTransPolygonXld(polygons, out HObject polygonsAffineTrans, homMat2D);
			return polygonsAffineTrans;
		}
		public static HObject AffineTransContourXld (HObject contours, HTuple homMat2D)
		{
			HOperatorSet.AffineTransContourXld(contours, out HObject contoursAffineTrans, homMat2D);
			return contoursAffineTrans;
		}
		public static HObject CloseContoursXld (HObject contours)
		{
			HOperatorSet.CloseContoursXld(contours, out HObject closedContours);
			return closedContours;
		}
		public static HObject ClipEndPointsContoursXld (HObject contours, HTuple mode, HTuple length)
		{
			HOperatorSet.ClipEndPointsContoursXld(contours, out HObject clippedContours, mode, length);
			return clippedContours;
		}
		public static HObject ClipContoursXld (HObject contours, HTuple row1, HTuple column1, HTuple row2, HTuple column2)
		{
			HOperatorSet.ClipContoursXld(contours, out HObject clippedContours, row1, column1, row2, column2);
			return clippedContours;
		}
		public static HObject LocalMaxContoursXld (HObject contours, HObject image, HTuple minPercent, HTuple minDiff, HTuple distance)
		{
			HOperatorSet.LocalMaxContoursXld(contours, image, out HObject localMaxContours, minPercent, minDiff, distance);
			return localMaxContours;
		}
		public static (HObject unionContours, HObject selectedContours, HTuple histoValues) UnionStraightContoursHistoXld (HObject contours, HTuple refLineStartRow, HTuple refLineStartColumn, HTuple refLineEndRow, HTuple refLineEndColumn, HTuple width, HTuple maxWidth, HTuple filterSize)
		{
			HOperatorSet.UnionStraightContoursHistoXld(contours, out HObject unionContours, out HObject selectedContours, refLineStartRow, refLineStartColumn, refLineEndRow, refLineEndColumn, width, maxWidth, filterSize, out HTuple histoValues);
			return (unionContours,selectedContours,histoValues);
		}
		public static HObject UnionStraightContoursXld (HObject contours, HTuple maxDist, HTuple maxDiff, HTuple percent, HTuple mode, HTuple iterations)
		{
			HOperatorSet.UnionStraightContoursXld(contours, out HObject unionContours, maxDist, maxDiff, percent, mode, iterations);
			return unionContours;
		}
		public static HObject UnionCollinearContoursExtXld (HObject contours, HTuple maxDistAbs, HTuple maxDistRel, HTuple maxShift, HTuple maxAngle, HTuple maxOverlap, HTuple maxRegrError, HTuple maxCosts, HTuple weightDist, HTuple weightShift, HTuple weightAngle, HTuple weightLink, HTuple weightRegr, HTuple mode)
		{
			HOperatorSet.UnionCollinearContoursExtXld(contours, out HObject unionContours, maxDistAbs, maxDistRel, maxShift, maxAngle, maxOverlap, maxRegrError, maxCosts, weightDist, weightShift, weightAngle, weightLink, weightRegr, mode);
			return unionContours;
		}
		public static HObject UnionCollinearContoursXld (HObject contours, HTuple maxDistAbs, HTuple maxDistRel, HTuple maxShift, HTuple maxAngle, HTuple mode)
		{
			HOperatorSet.UnionCollinearContoursXld(contours, out HObject unionContours, maxDistAbs, maxDistRel, maxShift, maxAngle, mode);
			return unionContours;
		}
		public static HObject UnionAdjacentContoursXld (HObject contours, HTuple maxDistAbs, HTuple maxDistRel, HTuple mode)
		{
			HOperatorSet.UnionAdjacentContoursXld(contours, out HObject unionContours, maxDistAbs, maxDistRel, mode);
			return unionContours;
		}
		public static HObject SelectContoursXld (HObject contours, HTuple feature, HTuple min1, HTuple max1, HTuple min2, HTuple max2)
		{
			HOperatorSet.SelectContoursXld(contours, out HObject selectedContours, feature, min1, max1, min2, max2);
			return selectedContours;
		}
		public static (HTuple length, HTuple nx, HTuple ny, HTuple dist, HTuple fpx, HTuple fpy, HTuple lpx, HTuple lpy, HTuple mean, HTuple deviation) GetRegressParamsXld (HObject contours)
		{
			HOperatorSet.GetRegressParamsXld(contours, out HTuple length, out HTuple nx, out HTuple ny, out HTuple dist, out HTuple fpx, out HTuple fpy, out HTuple lpx, out HTuple lpy, out HTuple mean, out HTuple deviation);
			return (length,nx,ny,dist,fpx,fpy,lpx,lpy,mean,deviation);
		}
		public static HObject RegressContoursXld (HObject contours, HTuple mode, HTuple iterations)
		{
			HOperatorSet.RegressContoursXld(contours, out HObject regressContours, mode, iterations);
			return regressContours;
		}
		public static HTuple GetContourAngleXld (HObject contour, HTuple angleMode, HTuple calcMode, HTuple lookaround)
		{
			HOperatorSet.GetContourAngleXld(contour, angleMode, calcMode, lookaround, out HTuple angles);
			return angles;
		}
		public static HObject SmoothContoursXld (HObject contours, HTuple numRegrPoints)
		{
			HOperatorSet.SmoothContoursXld(contours, out HObject smoothedContours, numRegrPoints);
			return smoothedContours;
		}
		public static HTuple ContourPointNumXld (HObject contour)
		{
			HOperatorSet.ContourPointNumXld(contour, out HTuple length);
			return length;
		}
		public static HTuple QueryContourGlobalAttribsXld (HObject contour)
		{
			HOperatorSet.QueryContourGlobalAttribsXld(contour, out HTuple attribs);
			return attribs;
		}
		public static HTuple GetContourGlobalAttribXld (HObject contour, HTuple name)
		{
			HOperatorSet.GetContourGlobalAttribXld(contour, name, out HTuple attrib);
			return attrib;
		}
		public static HTuple QueryContourAttribsXld (HObject contour)
		{
			HOperatorSet.QueryContourAttribsXld(contour, out HTuple attribs);
			return attribs;
		}
		public static HTuple GetContourAttribXld (HObject contour, HTuple name)
		{
			HOperatorSet.GetContourAttribXld(contour, name, out HTuple attrib);
			return attrib;
		}
		public static (HTuple row, HTuple col) GetContourXld (HObject contour)
		{
			HOperatorSet.GetContourXld(contour, out HTuple row, out HTuple col);
			return (row,col);
		}
		public static HObject GenContourRegionXld (HObject regions, HTuple mode)
		{
			HOperatorSet.GenContourRegionXld(regions, out HObject contours, mode);
			return contours;
		}
		public static HObject GenContourPolygonRoundedXld (HTuple row, HTuple col, HTuple radius, HTuple samplingInterval)
		{
			HOperatorSet.GenContourPolygonRoundedXld(out HObject contour, row, col, radius, samplingInterval);
			return contour;
		}
		public static HObject GenContourPolygonXld (HTuple row, HTuple col)
		{
			HOperatorSet.GenContourPolygonXld(out HObject contour, row, col);
			return contour;
		}
		public static HObject GenContoursSkeletonXld (HObject skeleton, HTuple length, HTuple mode)
		{
			HOperatorSet.GenContoursSkeletonXld(skeleton, out HObject contours, length, mode);
			return contours;
		}
		public static void DispXld (HObject XLDObject, HTuple windowHandle)
		{
			HOperatorSet.DispXld(XLDObject, windowHandle);
		}
		public static HObject WienerFilterNi (HObject image, HObject psf, HObject noiseRegion, HTuple maskWidth, HTuple maskHeight)
		{
			HOperatorSet.WienerFilterNi(image, psf, noiseRegion, out HObject restoredImage, maskWidth, maskHeight);
			return restoredImage;
		}
		public static HObject WienerFilter (HObject image, HObject psf, HObject filteredImage)
		{
			HOperatorSet.WienerFilter(image, psf, filteredImage, out HObject restoredImage);
			return restoredImage;
		}
		public static HObject GenPsfMotion (HTuple PSFwidth, HTuple PSFheight, HTuple blurring, HTuple angle, HTuple type)
		{
			HOperatorSet.GenPsfMotion(out HObject psf, PSFwidth, PSFheight, blurring, angle, type);
			return psf;
		}
		public static HObject SimulateMotion (HObject image, HTuple blurring, HTuple angle, HTuple type)
		{
			HOperatorSet.SimulateMotion(image, out HObject movedImage, blurring, angle, type);
			return movedImage;
		}
		public static HObject GenPsfDefocus (HTuple PSFwidth, HTuple PSFheight, HTuple blurring)
		{
			HOperatorSet.GenPsfDefocus(out HObject psf, PSFwidth, PSFheight, blurring);
			return psf;
		}
		public static HObject SimulateDefocus (HObject image, HTuple blurring)
		{
			HOperatorSet.SimulateDefocus(image, out HObject defocusedImage, blurring);
			return defocusedImage;
		}
		public static HTuple DeserializeVariationModel (HTuple serializedItemHandle)
		{
			HOperatorSet.DeserializeVariationModel(serializedItemHandle, out HTuple modelID);
			return modelID;
		}
		public static HTuple SerializeVariationModel (HTuple modelID)
		{
			HOperatorSet.SerializeVariationModel(modelID, out HTuple serializedItemHandle);
			return serializedItemHandle;
		}
		public static HTuple ReadVariationModel (HTuple fileName)
		{
			HOperatorSet.ReadVariationModel(fileName, out HTuple modelID);
			return modelID;
		}
		public static void WriteVariationModel (HTuple modelID, HTuple fileName)
		{
			HOperatorSet.WriteVariationModel(modelID, fileName);
		}
		public static (HObject minImage, HObject maxImage) GetThreshImagesVariationModel (HTuple modelID)
		{
			HOperatorSet.GetThreshImagesVariationModel(out HObject minImage, out HObject maxImage, modelID);
			return (minImage,maxImage);
		}
		public static (HObject image, HObject varImage) GetVariationModel (HTuple modelID)
		{
			HOperatorSet.GetVariationModel(out HObject image, out HObject varImage, modelID);
			return (image,varImage);
		}
		public static HObject CompareExtVariationModel (HObject image, HTuple modelID, HTuple mode)
		{
			HOperatorSet.CompareExtVariationModel(image, out HObject region, modelID, mode);
			return region;
		}
		public static HObject CompareVariationModel (HObject image, HTuple modelID)
		{
			HOperatorSet.CompareVariationModel(image, out HObject region, modelID);
			return region;
		}
		public static void PrepareDirectVariationModel (HObject refImage, HObject varImage, HTuple modelID, HTuple absThreshold, HTuple varThreshold)
		{
			HOperatorSet.PrepareDirectVariationModel(refImage, varImage, modelID, absThreshold, varThreshold);
		}
		public static void PrepareVariationModel (HTuple modelID, HTuple absThreshold, HTuple varThreshold)
		{
			HOperatorSet.PrepareVariationModel(modelID, absThreshold, varThreshold);
		}
		public static void TrainVariationModel (HObject images, HTuple modelID)
		{
			HOperatorSet.TrainVariationModel(images, modelID);
		}
		public static void ClearAllVariationModels ()
		{
			HOperatorSet.ClearAllVariationModels();
		}
		public static void ClearVariationModel (HTuple modelID)
		{
			HOperatorSet.ClearVariationModel(modelID);
		}
		public static void ClearTrainDataVariationModel (HTuple modelID)
		{
			HOperatorSet.ClearTrainDataVariationModel(modelID);
		}
		public static HTuple CreateVariationModel (HTuple width, HTuple height, HTuple type, HTuple mode)
		{
			HOperatorSet.CreateVariationModel(width, height, type, mode, out HTuple modelID);
			return modelID;
		}
		public static HTuple TupleUnion (HTuple set1, HTuple set2)
		{
			HOperatorSet.TupleUnion(set1, set2, out HTuple union);
			return union;
		}
		public static HTuple TupleIntersection (HTuple set1, HTuple set2)
		{
			HOperatorSet.TupleIntersection(set1, set2, out HTuple intersection);
			return intersection;
		}
		public static HTuple TupleDifference (HTuple set1, HTuple set2)
		{
			HOperatorSet.TupleDifference(set1, set2, out HTuple difference);
			return difference;
		}
		public static HTuple TupleSymmdiff (HTuple set1, HTuple set2)
		{
			HOperatorSet.TupleSymmdiff(set1, set2, out HTuple symmDiff);
			return symmDiff;
		}
		public static HTuple TupleIsStringElem (HTuple t)
		{
			HOperatorSet.TupleIsStringElem(t, out HTuple isString);
			return isString;
		}
		public static HTuple TupleIsRealElem (HTuple t)
		{
			HOperatorSet.TupleIsRealElem(t, out HTuple isReal);
			return isReal;
		}
		public static HTuple TupleIsIntElem (HTuple t)
		{
			HOperatorSet.TupleIsIntElem(t, out HTuple isInt);
			return isInt;
		}
		public static HTuple TupleTypeElem (HTuple t)
		{
			HOperatorSet.TupleTypeElem(t, out HTuple types);
			return types;
		}
		public static HTuple TupleIsMixed (HTuple t)
		{
			HOperatorSet.TupleIsMixed(t, out HTuple isMixed);
			return isMixed;
		}
		public static HTuple TupleIsString (HTuple t)
		{
			HOperatorSet.TupleIsString(t, out HTuple isString);
			return isString;
		}
		public static HTuple TupleIsReal (HTuple t)
		{
			HOperatorSet.TupleIsReal(t, out HTuple isReal);
			return isReal;
		}
		public static HTuple TupleIsInt (HTuple t)
		{
			HOperatorSet.TupleIsInt(t, out HTuple isInt);
			return isInt;
		}
		public static HTuple TupleType (HTuple t)
		{
			HOperatorSet.TupleType(t, out HTuple type);
			return type;
		}
		public static (HTuple histo, HTuple binSize) TupleHistoRange (HTuple tuple, HTuple min, HTuple max, HTuple numBins)
		{
			HOperatorSet.TupleHistoRange(tuple, min, max, numBins, out HTuple histo, out HTuple binSize);
			return (histo,binSize);
		}
		public static HTuple TupleRegexpSelect (HTuple data, HTuple expression)
		{
			HOperatorSet.TupleRegexpSelect(data, expression, out HTuple selection);
			return selection;
		}
		public static HTuple TupleRegexpTest (HTuple data, HTuple expression)
		{
			HOperatorSet.TupleRegexpTest(data, expression, out HTuple numMatches);
			return numMatches;
		}
		public static HTuple TupleRegexpReplace (HTuple data, HTuple expression, HTuple replace)
		{
			HOperatorSet.TupleRegexpReplace(data, expression, replace, out HTuple result);
			return result;
		}
		public static HTuple TupleRegexpMatch (HTuple data, HTuple expression)
		{
			HOperatorSet.TupleRegexpMatch(data, expression, out HTuple matches);
			return matches;
		}
		public static HTuple TupleRand (HTuple length)
		{
			HOperatorSet.TupleRand(length, out HTuple rand);
			return rand;
		}
		public static HTuple TupleLength (HTuple tuple)
		{
			HOperatorSet.TupleLength(tuple, out HTuple length);
			return length;
		}
		public static HTuple TupleSgn (HTuple t)
		{
			HOperatorSet.TupleSgn(t, out HTuple sgn);
			return sgn;
		}
		public static HTuple TupleMax2 (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleMax2(t1, t2, out HTuple max2);
			return max2;
		}
		public static HTuple TupleMin2 (HTuple t1, HTuple t2)
		{
			HOperatorSet.TupleMin2(t1, t2, out HTuple min2);
			return min2;
		}
		public static HTuple TupleMax (HTuple tuple)
		{
			HOperatorSet.TupleMax(tuple, out HTuple max);
			return max;
		}
		public static HTuple TupleMin (HTuple tuple)
		{
			HOperatorSet.TupleMin(tuple, out HTuple min);
			return min;
		}
		public static HTuple TupleCumul (HTuple tuple)
		{
			HOperatorSet.TupleCumul(tuple, out HTuple cumul);
			return cumul;
		}
		public static HTuple TupleSelectRank (HTuple tuple, HTuple rankIndex)
		{
			HOperatorSet.TupleSelectRank(tuple, rankIndex, out HTuple selected);
			return selected;
		}
		public static HTuple TupleMedian (HTuple tuple)
		{
			HOperatorSet.TupleMedian(tuple, out HTuple median);
			return median;
		}
		public static HTuple TupleSum (HTuple tuple)
		{
			HOperatorSet.TupleSum(tuple, out HTuple sum);
			return sum;
		}
		public static HTuple TupleMean (HTuple tuple)
		{
			HOperatorSet.TupleMean(tuple, out HTuple mean);
			return mean;
		}
		public static HTuple TupleDeviation (HTuple tuple)
		{
			HOperatorSet.TupleDeviation(tuple, out HTuple deviation);
			return deviation;
		}
		public static HTuple TupleUniq (HTuple tuple)
		{
			HOperatorSet.TupleUniq(tuple, out HTuple uniq);
			return uniq;
		}
	}
}
