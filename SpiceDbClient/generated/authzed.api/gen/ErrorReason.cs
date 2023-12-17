// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: authzed/api/v1/error_reason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Authzed.Api.V1 {

  /// <summary>Holder for reflection information generated from authzed/api/v1/error_reason.proto</summary>
  public static partial class ErrorReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for authzed/api/v1/error_reason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ErrorReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFhdXRoemVkL2FwaS92MS9lcnJvcl9yZWFzb24ucHJvdG8SDmF1dGh6ZWQu",
            "YXBpLnYxKvAGCgtFcnJvclJlYXNvbhIcChhFUlJPUl9SRUFTT05fVU5TUEVD",
            "SUZJRUQQABIjCh9FUlJPUl9SRUFTT05fU0NIRU1BX1BBUlNFX0VSUk9SEAES",
            "IgoeRVJST1JfUkVBU09OX1NDSEVNQV9UWVBFX0VSUk9SEAISIwofRVJST1Jf",
            "UkVBU09OX1VOS05PV05fREVGSU5JVElPThADEi8KK0VSUk9SX1JFQVNPTl9V",
            "TktOT1dOX1JFTEFUSU9OX09SX1BFUk1JU1NJT04QBBIsCihFUlJPUl9SRUFT",
            "T05fVE9PX01BTllfVVBEQVRFU19JTl9SRVFVRVNUEAUSMgouRVJST1JfUkVB",
            "U09OX1RPT19NQU5ZX1BSRUNPTkRJVElPTlNfSU5fUkVRVUVTVBAGEjUKMUVS",
            "Uk9SX1JFQVNPTl9XUklURV9PUl9ERUxFVEVfUFJFQ09ORElUSU9OX0ZBSUxV",
            "UkUQBxIiCh5FUlJPUl9SRUFTT05fU0VSVklDRV9SRUFEX09OTFkQCBIfChtF",
            "UlJPUl9SRUFTT05fVU5LTk9XTl9DQVZFQVQQCRIlCiFFUlJPUl9SRUFTT05f",
            "SU5WQUxJRF9TVUJKRUNUX1RZUEUQChIsCihFUlJPUl9SRUFTT05fQ0FWRUFU",
            "X1BBUkFNRVRFUl9UWVBFX0VSUk9SEAsSLQopRVJST1JfUkVBU09OX1VQREFU",
            "RVNfT05fU0FNRV9SRUxBVElPTlNISVAQDBIpCiVFUlJPUl9SRUFTT05fQ0FO",
            "Tk9UX1VQREFURV9QRVJNSVNTSU9OEA0SKAokRVJST1JfUkVBU09OX0NBVkVB",
            "VF9FVkFMVUFUSU9OX0VSUk9SEA4SHwobRVJST1JfUkVBU09OX0lOVkFMSURf",
            "Q1VSU09SEA8SQAo8RVJST1JfUkVBU09OX1RPT19NQU5ZX1JFTEFUSU9OU0hJ",
            "UFNfRk9SX1RSQU5TQUNUSU9OQUxfREVMRVRFEBASLgoqRVJST1JfUkVBU09O",
            "X01BWF9SRUxBVElPTlNISVBfQ09OVEVYVF9TSVpFEBESMQotRVJST1JfUkVB",
            "U09OX0FUVEVNUFRfVE9fUkVDUkVBVEVfUkVMQVRJT05TSElQEBISJwojRVJS",
            "T1JfUkVBU09OX01BWElNVU1fREVQVEhfRVhDRUVERUQQE0JIChJjb20uYXV0",
            "aHplZC5hcGkudjFaMmdpdGh1Yi5jb20vYXV0aHplZC9hdXRoemVkLWdvL3By",
            "b3RvL2F1dGh6ZWQvYXBpL3YxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Authzed.Api.V1.ErrorReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Defines the supported values for `google.rpc.ErrorInfo.reason` for the
  /// `authzed.com` error domain.
  /// </summary>
  public enum ErrorReason {
    /// <summary>
    /// Do not use this default value.
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// The request gave a schema that could not be parsed.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     { 
    ///       "reason": "ERROR_REASON_SCHEMA_PARSE_ERROR",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "start_line_number": "1",
    ///         "start_column_position": "19",
    ///         "end_line_number": "1",
    ///         "end_column_position": "19",
    ///         "source_code": "somedefinition",
    ///       }
    ///     }
    ///
    /// The line numbers and column positions are 0-indexed and may not be present.
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_SCHEMA_PARSE_ERROR")] SchemaParseError = 1,
    /// <summary>
    /// The request contains a schema with a type error.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {  
    ///       "reason": "ERROR_REASON_SCHEMA_TYPE_ERROR",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "definition_name": "somedefinition",
    ///         ... additional keys based on the kind of type error ...
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_SCHEMA_TYPE_ERROR")] SchemaTypeError = 2,
    /// <summary>
    /// The request referenced an unknown object definition in the schema.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {  
    ///       "reason": "ERROR_REASON_UNKNOWN_DEFINITION",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "definition_name": "somedefinition"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_UNKNOWN_DEFINITION")] UnknownDefinition = 3,
    /// <summary>
    /// The request referenced an unknown relation or permission under a definition in the schema.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {  
    ///       "reason": "ERROR_REASON_UNKNOWN_RELATION_OR_PERMISSION",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "definition_name": "somedefinition",
    ///         "relation_or_permission_name": "somepermission"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_UNKNOWN_RELATION_OR_PERMISSION")] UnknownRelationOrPermission = 4,
    /// <summary>
    /// The WriteRelationships request contained more updates than the maximum configured.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     { "reason": "ERROR_REASON_TOO_MANY_UPDATES_IN_REQUEST",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "update_count": "525",
    ///         "maximum_updates_allowed": "500",
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_TOO_MANY_UPDATES_IN_REQUEST")] TooManyUpdatesInRequest = 5,
    /// <summary>
    /// The request contained more preconditions than the maximum configured.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {  
    ///       "reason": "ERROR_REASON_TOO_MANY_PRECONDITIONS_IN_REQUEST",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "precondition_count": "525",
    ///         "maximum_preconditions_allowed": "500",
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_TOO_MANY_PRECONDITIONS_IN_REQUEST")] TooManyPreconditionsInRequest = 6,
    /// <summary>
    /// The request contained a precondition that failed.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {  
    ///       "reason": "ERROR_REASON_WRITE_OR_DELETE_PRECONDITION_FAILURE",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "precondition_resource_type": "document",
    ///         ... other fields for the filter ...
    ///         "precondition_operation": "MUST_EXIST",
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_WRITE_OR_DELETE_PRECONDITION_FAILURE")] WriteOrDeletePreconditionFailure = 7,
    /// <summary>
    /// A write or delete request was made to an instance that is deployed in read-only mode.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {  
    ///       "reason": "ERROR_REASON_SERVICE_READ_ONLY",
    ///       "domain": "authzed.com"
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_SERVICE_READ_ONLY")] ServiceReadOnly = 8,
    /// <summary>
    /// The request referenced an unknown caveat in the schema.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {  
    ///       "reason": "ERROR_REASON_UNKNOWN_CAVEAT",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "caveat_name": "somecaveat"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_UNKNOWN_CAVEAT")] UnknownCaveat = 9,
    /// <summary>
    /// The request tries to use a subject type that was not valid for a relation.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {  
    ///       "reason": "ERROR_REASON_INVALID_SUBJECT_TYPE",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "definition_name": "somedefinition",
    ///         "relation_name": "somerelation",
    ///         "subject_type": "user:*"
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_INVALID_SUBJECT_TYPE")] InvalidSubjectType = 10,
    /// <summary>
    /// The request tries to specify a caveat parameter value with the wrong type.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {  
    ///       "reason": "ERROR_REASON_CAVEAT_PARAMETER_TYPE_ERROR",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "definition_name": "somedefinition",
    ///         "relation_name": "somerelation",
    ///         "caveat_name": "somecaveat",
    ///         "parameter_name": "someparameter",
    ///         "expected_type": "int",
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_CAVEAT_PARAMETER_TYPE_ERROR")] CaveatParameterTypeError = 11,
    /// <summary>
    /// The request tries to perform two or more updates on the same relationship in the same WriteRelationships call.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {  
    ///       "reason": "ERROR_REASON_UPDATES_ON_SAME_RELATIONSHIP",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "definition_name": "somedefinition",
    ///         "relationship": "somerelationship",
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_UPDATES_ON_SAME_RELATIONSHIP")] UpdatesOnSameRelationship = 12,
    /// <summary>
    /// The request tries to write a relationship on a permission instead of a relation.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {  
    ///       "reason": "ERROR_REASON_CANNOT_UPDATE_PERMISSION",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "definition_name": "somedefinition",
    ///         "permission_name": "somerelation",
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_CANNOT_UPDATE_PERMISSION")] CannotUpdatePermission = 13,
    /// <summary>
    /// The request failed to evaluate a caveat expression due to an error.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {  
    ///       "reason": "ERROR_REASON_CAVEAT_EVALUATION_ERROR",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "caveat_name": "somecaveat",
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_CAVEAT_EVALUATION_ERROR")] CaveatEvaluationError = 14,
    /// <summary>
    /// The request failed because the provided cursor was invalid in some way.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {  
    ///       "reason": "ERROR_REASON_INVALID_CURSOR",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///          ... additional keys based on the kind of cursor error ...
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_INVALID_CURSOR")] InvalidCursor = 15,
    /// <summary>
    /// The request failed because there are too many matching relationships to be
    /// deleted within a single transactional deletion call. To avoid, set
    /// `optional_allow_partial_deletions` to true on the DeleteRelationships call.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {  
    ///       "reason": "ERROR_REASON_TOO_MANY_RELATIONSHIPS_FOR_TRANSACTIONAL_DELETE",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///          ... fields for the filter ...
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_TOO_MANY_RELATIONSHIPS_FOR_TRANSACTIONAL_DELETE")] TooManyRelationshipsForTransactionalDelete = 16,
    /// <summary>
    /// The request failed because the client attempted to write a relationship
    /// with a context that exceeded the configured server limit.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {
    ///       "reason": "ERROR_REASON_MAX_RELATIONSHIP_CONTEXT_SIZE",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "relationship":     "relationship_exceeding_the_limit",
    ///         "max_allowed_size": "server_max_allowed_context_size",
    ///         "context_size":     "actual_relationship_context_size" ,
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_MAX_RELATIONSHIP_CONTEXT_SIZE")] MaxRelationshipContextSize = 17,
    /// <summary>
    /// The request failed because a relationship marked to be CREATEd
    /// was already present within the datastore.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {
    ///       "reason": "ERROR_REASON_ATTEMPT_TO_RECREATE_RELATIONSHIP",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "relationship":          "relationship_that_already_existed",
    ///         "resource_type":         "resource type",
    ///         "resource_object_id":    "resource object id",
    ///         ... additional decomposed relationship fields ...
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_ATTEMPT_TO_RECREATE_RELATIONSHIP")] AttemptToRecreateRelationship = 18,
    /// <summary>
    /// The request failed because it caused the maximum depth allowed to be
    /// exceeded. This typically indicates that there is a circular data traversal
    /// somewhere in the schema, but can also be raised if the data traversal is simply
    /// too deep.
    ///
    /// Example of an ErrorInfo:
    ///
    ///     {
    ///       "reason": "ERROR_REASON_MAXIMUM_DEPTH_EXCEEDED",
    ///       "domain": "authzed.com",
    ///       "metadata": {
    ///         "maximum_depth_allowed": "50",
    ///         ... additional fields based on request type ...
    ///       }
    ///     }
    /// </summary>
    [pbr::OriginalName("ERROR_REASON_MAXIMUM_DEPTH_EXCEEDED")] MaximumDepthExceeded = 19,
  }

  #endregion

}

#endregion Designer generated code
